using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using Org.BouncyCastle.Crypto.Generators;

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
            lstFuncionario.Columns.Add("Data de Entrada", 111, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("Data de Saída", 111, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("Senha", 80, HorizontalAlignment.Left);

            carregarFuncionario();
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.ReadOnly == false && !txtEntrada.ReadOnly == false && !txtSaida.ReadOnly == false && !txtCodigo.ReadOnly == false && !txtSenha.ReadOnly == false)
                {
                    tirarReadOnly();
                }
                else
                {
                    var codigo = txtCodigo.Text;
                    var nome = txtNome.Text;
                    var entrada = txtEntrada.Text;
                    var saida = txtSaida.Text;
                    var senha = BCrypt.Net.BCrypt.EnhancedHashPassword(txtSenha.Text, 13);

                    
                    using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                    {
                        conexao.Open();

                        //Check if all text boxes and all txtMaskedBox are Null or Empty
                        if (!String.IsNullOrEmpty(codigo) && !String.IsNullOrEmpty(nome) && !txtEntrada.Text.Trim().Equals(String.Empty) && !txtSaida.Text.Trim().Equals(String.Empty) && !String.IsNullOrEmpty(senha))
                        {
                            
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                cmd.Connection = conexao;
                                cmd.CommandText = @"INSERT INTO funcionario (N_Funcionario,
                                                                     Nome_Funcionario,
                                                                     Data_Entrada,
                                                                     Data_Saida,
                                                                     Senha) 
                                            VALUES(@codigo,@nome,@entrada,@saida,@senha)";

                                cmd.Parameters.AddWithValue("@codigo", codigo);
                                cmd.Parameters.AddWithValue("@nome", nome);
                                cmd.Parameters.AddWithValue("@entrada", entrada);
                                cmd.Parameters.AddWithValue("@saida", saida);
                                cmd.Parameters.AddWithValue("@senha", senha);
                                cmd.ExecuteNonQuery();

                                

                                adicionarReadOnly();
                                carregarFuncionario();
                            }
                        }
                        else MessageBox.Show("Sem dados suficientes para a inserção de dados.");
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
         
            }
        }

        private void lstFuncionario_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lstFuncionario.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                txtCodigo.Text = item.SubItems[0].Text;
                txtNome.Text = item.SubItems[1].Text;
                txtEntrada.Text = item.SubItems[2].Text;
                txtSaida.Text = item.SubItems[3].Text;
                txtSenha.Text = item.SubItems[4].Text;
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
                        cmd.CommandText = @"SELECT * FROM funcionario ORDER BY Nome_Funcionario";
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string codigo = reader.GetInt32(0).ToString();
                                string nome = reader.GetString(1).ToString();
                                DateTime entrada = reader.GetDateTime(2);
                                DateTime saida = reader.GetDateTime(3);

                                string senha = reader.GetString(4).ToString();
                                //Set "entrada" and "saida" with year,month,day and Hour,minute and seconds.
                                string entradaStr = entrada.ToString("yyyy-MM-dd HH:mm-ss");
                                string saidaStr = saida.ToString("yyyy-MM-dd HH:mm-ss");

                                string[] row = {codigo,nome,entradaStr,saidaStr,senha};
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.ReadOnly == false && !txtEntrada.ReadOnly == false && !txtSaida.ReadOnly == false && !txtSenha.ReadOnly == false)
                {
                    tirarReadOnlyEmUpdate();
                }
                else
                {
                    DialogResult msg = MessageBox.Show("Confirmar atualização?", "Atualizar Funcionário", MessageBoxButtons.YesNo);

                    if (msg == DialogResult.Yes)
                    {
                        using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                        {
                            conexao.Open();
                            using (MySqlCommand cmd = conexao.CreateCommand())
                            {
                                cmd.Connection = conexao;
                                cmd.CommandText = @"UPDATE funcionario
                                                   SET N_Funcionario = @codigo,
                                                   Nome_Funcionario = @nome,
                                                   Data_Entrada = @entrada,
                                                   Data_Saida = @saida,
                                                   Senha = @senha
                                                   WHERE N_Funcionario = @codigo";

                                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                                cmd.Parameters.AddWithValue("@entrada", txtEntrada.Text);
                                cmd.Parameters.AddWithValue("@saida", txtSaida.Text);

                                var senha = BCrypt.Net.BCrypt.EnhancedHashPassword(txtSenha.Text, 13);
                                cmd.Parameters.AddWithValue("@senha", senha);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Dados atualizados com sucesso!");
                                carregarFuncionario();
                            }
                        }
                    }
                    else MessageBox.Show("Nenhum dado foi alterado.");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult msg = MessageBox.Show("Confirmar exclusão?", "Deletar Aluno", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                {
                    using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                    {
                        conexao.Open();
                        using (MySqlCommand cmd = conexao.CreateCommand())
                        {
                            cmd.Connection = conexao;
                            cmd.CommandText = @"DELETE FROM funcionario
                                           WHERE N_Funcionario = @codigo";
                            cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Dados deletados com sucesso!");
                            carregarFuncionario();
                        }
                    }
                }
                else MessageBox.Show("Nenhum dado foi deletado.");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tirarReadOnly()
        {
            txtCodigo.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtEntrada.ReadOnly = false;
            txtSaida.ReadOnly = false;
            txtSenha.ReadOnly = false;  

            txtCodigo.Clear();
            txtNome.Clear();
            txtEntrada.Clear();
            txtSaida.Clear();
            txtSenha.Clear();
        }
        private void adicionarReadOnly()
        {
            txtNome.ReadOnly = true;
            txtEntrada.ReadOnly = true;
            txtSaida.ReadOnly = true;
            txtCodigo.ReadOnly = true;
            txtSenha.ReadOnly = true;

            txtCodigo.Clear();
            txtNome.Clear();
            txtEntrada.Clear();
            txtSaida.Clear();
            txtSenha.Clear();
        }

        private void tirarReadOnlyEmUpdate()
        {
            txtNome.ReadOnly = false;
            txtEntrada.ReadOnly = false;
            txtSaida.ReadOnly = false;
            txtSenha.ReadOnly = false;
        }
        private void adicionarReadOnlyEmUpdate()
        {
            txtNome.ReadOnly = true;
            txtEntrada.ReadOnly = true;
            txtSaida.ReadOnly = true;
            txtSenha.ReadOnly = true;

            txtCodigo.Clear();
            txtNome.Clear();
            txtEntrada.Clear();
            txtSaida.Clear();
            txtSenha.Clear();
        }
    }
}
