using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bar_do_Esas
{
    public partial class FormularioAluno : Form
    {
        TextBoxConfig txtConfig = new TextBoxConfig();
        bool modoEdicaoAtivado = false;
        
        public FormularioAluno()
        {
            InitializeComponent();
            GerirAcoesLstAluno.CriarColunasLstAluno(lstAluno);

            Aluno aluno = new Aluno();
            aluno.CarregarAluno(lstAluno);
        }
        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno();

                if (!modoEdicaoAtivado)
                {
                    TextBoxConfig.HabilitarEdicao(txtCodigo, txtNome, txtSaldo, txtData);
                    modoEdicaoAtivado = true;
                }
                else
                {
                    
                    if(txtConfig.ChecarCamposVazios(this))
                    {
                        int codigo = Convert.ToInt32(txtCodigo.Text);
                        string nome = txtNome.Text;
                        DateTime dataNascimento = DateTime.Parse(txtData.Text);
                        decimal saldo = decimal.Parse(txtSaldo.Text);

                        aluno.CriarNovoAluno(codigo,nome,dataNascimento,saldo);
                    }
                    
                    TextBoxConfig.DesabilitarEdicao(txtCodigo, txtNome, txtData, txtSaldo);
                    modoEdicaoAtivado = false;
                    aluno.CarregarAluno(lstAluno);
                    txtConfig.LimparTextBox(txtCodigo, txtNome, txtSaldo, txtData);
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            if (!modoEdicaoAtivado)
            {
                TextBoxConfig.HabilitarEdicao(txtNome, txtSaldo, txtData);
                modoEdicaoAtivado = true;
            }
            else
            {

                if (txtConfig.ChecarCamposVazios(this))
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);
                    string nome = txtNome.Text;
                    DateTime dataNascimento = DateTime.Parse(txtData.Text);
                    decimal saldo = decimal.Parse(txtSaldo.Text);

                    aluno.AtualizarAluno(codigo, nome, dataNascimento, saldo);
                }

                TextBoxConfig.DesabilitarEdicao(txtNome, txtData, txtSaldo);
                modoEdicaoAtivado = false;
                aluno.CarregarAluno(lstAluno);
                txtConfig.LimparTextBox(txtCodigo, txtNome, txtSaldo, txtData);
            }
        }

        private void lstAluno_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lstAluno.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                txtCodigo.Text = item.SubItems[0].Text;
                txtNome.Text = item.SubItems[1].Text;
                txtData.Text = item.SubItems[2].Text;
                txtSaldo.Text = item.SubItems[3].Text;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno();
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        //Check if the user really want delete a student.
                        DialogResult msg = MessageBox.Show("Confirmar exclusão?", "Deletar Aluno", MessageBoxButtons.YesNo);

                        if (msg == DialogResult.Yes)
                        {
                            cmd.Connection = conexao;
                            cmd.CommandText = @"DELETE FROM aluno
                                           WHERE N_Aluno = @codigo";
                            cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Dados deletados com sucesso!");
                            aluno.CarregarAluno(lstAluno);
                        }
                        else MessageBox.Show("Nenhum dado foi deletado.");
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
