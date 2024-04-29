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

            carregarAluno();
        }

        private void lbl_Aluno_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                //check if the text box "readOnly" are active. If are, set all text box true.
                if (!modoEdicaoAtivado)
                {
                    TextBoxConfig.HabilitarEdicao(txtCodigo, txtNome, txtSaldo, txtData);
                    modoEdicaoAtivado = true;
                }
                else
                {
                    Aluno aluno = new Aluno();
                    if(txtConfig.ChecarCamposVazios(this))
                    {
                        string codigo = txtCodigo.Text;
                        string nome = txtNome.Text;
                        DateTime dataNascimento = DateTime.Parse(txtData.Text);
                        decimal saldo = decimal.Parse(txtSaldo.Text);

                        aluno.CriarNovoAluno(codigo,nome,dataNascimento,saldo);
                    }
                    
                    TextBoxConfig.DesabilitarEdicao(txtCodigo, txtNome, txtData, txtSaldo);
                    modoEdicaoAtivado = false;
                    carregarAluno();
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormularioAluno_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void carregarAluno()
        {
            try
            {
                //Clear a ListView before load all studentes, for that not have a redundance of data.
                lstAluno.Items.Clear();
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = @"SELECT * FROM aluno ORDER BY Nome_Aluno";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string codigo = reader.GetInt32(0).ToString();
                                string nome = reader.GetString(1);
                                DateTime dataNascimento = reader.GetDateTime(2);

                                string dataNascimentoStr = dataNascimento.ToString("yyyy-MM-dd");

                                string saldo = reader.GetDouble(3).ToString();

                                string[] row = { codigo, nome, dataNascimentoStr, saldo };
                                var linha_lstView = new ListViewItem(row);
                                lstAluno.Items.Add(linha_lstView);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        if (!txtNome.ReadOnly == false && !txtData.ReadOnly == false && !txtSaldo.ReadOnly == false && !txtCodigo.ReadOnly == false)
                        {
                            tirarReadOnlyEmUpdate();
                        }
                        else
                        {
                            DialogResult msg = MessageBox.Show("Confirmar atualização?", "Atualizar Aluno", MessageBoxButtons.YesNo);

                            if (msg == DialogResult.Yes)
                            {
                                cmd.Connection = conexao;
                                cmd.CommandText = @"UPDATE aluno 
                                            SET Nome_Aluno = @nome, Data_Nasc = @data, Saldo = @saldo
                                            WHERE N_Aluno = @codigo";
                                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                                cmd.Parameters.AddWithValue("@data", txtData.Text);
                                cmd.Parameters.AddWithValue("@saldo", Convert.ToDouble(txtSaldo.Text));
                                cmd.ExecuteNonQuery();

                                adicionarReadOnlyEmUpdate();

                                MessageBox.Show("Dados atualizados com sucesso!!!");
                                carregarAluno();
                            }
                            else MessageBox.Show("Nenhum dado foi alterado.");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                            carregarAluno();
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

        private void tirarReadOnly()
        {
            txtNome.ReadOnly = false;
            txtData.ReadOnly = false;
            txtSaldo.ReadOnly = false;
            txtCodigo.ReadOnly = false;

            txtCodigo.Clear();
            txtNome.Clear();
            txtData.Clear();
            txtSaldo.Clear();
        }
        private void adicionarReadOnly()
        {
            txtNome.ReadOnly = true;
            txtData.ReadOnly = true;
            txtSaldo.ReadOnly = true;
            txtCodigo.ReadOnly = true;

            txtCodigo.Clear();
            txtNome.Clear();
            txtData.Clear();
            txtSaldo.Clear();
        }

        private void tirarReadOnlyEmUpdate()
        {
            txtData.ReadOnly = false;
            txtSaldo.ReadOnly = false;
            txtNome.ReadOnly = false;
        }
        private void adicionarReadOnlyEmUpdate()
        {
            txtNome.ReadOnly = true;
            txtData.ReadOnly = true;
            txtSaldo.ReadOnly = true;
            txtCodigo.ReadOnly = true;

            txtCodigo.Clear();
            txtNome.Clear();
            txtData.Clear();
            txtSaldo.Clear();
        }
    }
}
