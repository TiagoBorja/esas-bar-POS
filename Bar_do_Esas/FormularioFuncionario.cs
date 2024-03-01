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
        public FormularioFuncionario()
        {
            InitializeComponent();

            lstFuncionario.View = View.Details;
            lstFuncionario.LabelEdit = true;
            lstFuncionario.AllowColumnReorder = true;
            lstFuncionario.FullRowSelect = true;
            lstFuncionario.GridLines = true;

            lstFuncionario.Columns.Add("Código", 60, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("Nome", 120, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("Senha", 120, HorizontalAlignment.Left);

            carregarFuncionario();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var codigo = txtCodigo.Text;
            var nome = txtNome.Text;
            var senha = BCrypt.Net.BCrypt.EnhancedHashPassword(txtSenha.Text, 13);
            try
            {
                if (!txtNome.ReadOnly == false && !txtCodigo.ReadOnly == false && !txtSenha.ReadOnly == false)
                {
                    tirarReadOnly();
                }
                else
                {
                    if (!String.IsNullOrEmpty(codigo) && !String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(senha))
                    {
                        using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                        {
                            conexao.Open();

                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                cmd.Connection = conexao;
                                cmd.CommandText = @"INSERT INTO dados_funcionario
                                           VALUES(@codigo,@nome,@senha)";
                                cmd.Parameters.AddWithValue("@codigo", codigo);
                                cmd.Parameters.AddWithValue("@nome", nome);
                                cmd.Parameters.AddWithValue("@senha", senha);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Funcionário criado com sucesso!");
                            }
                            carregarFuncionario();
                            adicionarReadOnly();
                        }
                    }
                    else MessageBox.Show("Sem dados suficientes para a inserção de dados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tirarReadOnly()
        {
            txtCodigo.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtSenha.ReadOnly = false;

            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha.Clear();
        }
        private void adicionarReadOnly()
        {
            txtNome.ReadOnly = true;
            txtCodigo.ReadOnly = true;
            txtSenha.ReadOnly = true;

            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha.Clear();
        }

        private void tirarReadOnlyEmUpdate()
        {
            txtNome.ReadOnly = false;
            txtSenha.ReadOnly = false;
        }
        private void adicionarReadOnlyEmUpdate()
        {
            txtNome.ReadOnly = true;           
            txtSenha.ReadOnly = true;

            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var codigo = txtCodigo.Text;
            var nome = txtNome.Text;
            var senha = BCrypt.Net.BCrypt.EnhancedHashPassword(txtSenha.Text, 13);

            try
            {
                if (!txtNome.ReadOnly == false && !txtSenha.ReadOnly == false)
                {
                    tirarReadOnlyEmUpdate();
                }
                else
                {
                    if (!String.IsNullOrEmpty(codigo) && !String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(senha))
                    {
                        DialogResult msg = MessageBox.Show("Confirmar atualização?", "Atualizar Aluno", MessageBoxButtons.YesNo);

                        if (msg == DialogResult.Yes)
                        {
                            using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                            {
                                conexao.Open();
                                using (MySqlCommand cmd = new MySqlCommand())
                                {
                                    cmd.Connection = conexao;
                                    cmd.CommandText = @"UPDATE dados_funcionario
                                                    SET Nome_Funcionario = @nome, Senha = @senha
                                                    WHERE N_Funcionario = @codigo";
                                    cmd.Parameters.AddWithValue("@codigo", codigo);
                                    cmd.Parameters.AddWithValue("@nome", nome);
                                    cmd.Parameters.AddWithValue("@senha", senha);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Funcionário atualizado com sucesso!");
                                }
                            }
                            carregarFuncionario();
                            adicionarReadOnlyEmUpdate();
                        }
                        else MessageBox.Show("Nenhum dado foi alterado.");
                        
                    }
                    else MessageBox.Show("Sem dados suficientes para a atualização dos dados.");
                }
                    
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void carregarFuncionario()
        {
            try
            {
                lstFuncionario.Items.Clear();
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = @"SELECT * FROM dados_funcionario ORDER BY Nome_Funcionario";
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string codigo = reader.GetInt32(0).ToString();
                                string nome = reader.GetString(1).ToString();
                                string senha = reader.GetString(2).ToString();
                                string[] row = { codigo, nome, senha};
                                var linha_lstView = new ListViewItem(row);
                                lstFuncionario.Items.Add(linha_lstView);
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

        private void lstAluno_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lstFuncionario.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                txtCodigo.Text = item.SubItems[0].Text;
                txtNome.Text = item.SubItems[1].Text;
                txtSenha.Text = item.SubItems[2].Text;
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
                        cmd.Connection = conexao;
                        cmd.CommandText = @"DELETE FROM dados_funcionario
                                           WHERE N_Funcionario = @codigo";
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Funcionário deletado com sucesso!");
                    }
                }
                carregarFuncionario();
                adicionarReadOnly();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
