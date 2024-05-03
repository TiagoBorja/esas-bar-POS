using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_do_Esas
{
    public partial class FormularioFuncionario : Form
    {
        TextBoxConfig txtConfig = new TextBoxConfig();
        Funcionario funcionario = new Funcionario();
        bool modoEdicaoAtivado = false;
        public FormularioFuncionario()
        {
            InitializeComponent();

            GerirAcoesLstFuncionario.CriarColunasLstFuncionario(lstFuncionario);

            funcionario.CarregarFuncionario(lstFuncionario);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CriarFuncionario f = new CriarFuncionario();
            f.ShowDialog();
            funcionario.CarregarFuncionario(lstFuncionario);
        }
        private void adicionarReadOnly()
        {
            txtNome.ReadOnly = true;
            txtCodigo.ReadOnly = true;

            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!modoEdicaoAtivado)
                {
                    TextBoxConfig.HabilitarEdicao(txtNome);
                    modoEdicaoAtivado = true;
                    btnUpdate.Text = "Salvar Alterações";
                }
                else
                {
                    if (txtConfig.ChecarCamposVazios(this))
                    {
                        int codigo = Convert.ToInt32(txtCodigo.Text);
                        string nome = txtNome.Text;

                        funcionario.AtualizarFuncionario(codigo, nome);
                    }
                }
                    
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        private void lstAluno_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lstFuncionario.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                txtCodigo.Text = item.SubItems[0].Text;
                txtNome.Text = item.SubItems[1].Text;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult msg = MessageBox.Show("Confirmar exclusão?", "Excluir Aluno", MessageBoxButtons.YesNo);

                if(msg == DialogResult.Yes)
                {
                    using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                    {
                        conexao.Open();

                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.Connection = conexao;
                            cmd.CommandText = @"DELETE FROM dados_funcionario
                                           WHERE N_Funcionario = @codigo";
                            cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Funcionário deletado com sucesso!");
                        }
                    }
                    funcionario.CarregarFuncionario(lstFuncionario);
                    adicionarReadOnly();
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
