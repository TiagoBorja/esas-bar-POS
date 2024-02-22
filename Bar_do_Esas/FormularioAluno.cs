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
        public FormularioAluno()
        {
            InitializeComponent();

            lstAluno.View = View.Details;
            lstAluno.LabelEdit = true;
            lstAluno.AllowColumnReorder = true;
            lstAluno.FullRowSelect = true;
            lstAluno.GridLines = true;

            lstAluno.Columns.Add("Código", 60, HorizontalAlignment.Left);
            lstAluno.Columns.Add("Nome", 120, HorizontalAlignment.Left);
            lstAluno.Columns.Add("Data de Nascimento", 100, HorizontalAlignment.Left);
            lstAluno.Columns.Add("Saldo", 60, HorizontalAlignment.Left);

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
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = @"INSERT INTO aluno VALUES (@codigo,@nome,@data,@saldo)";
                        cmd.Parameters.AddWithValue("@codigo",txtCodigo.Text);
                        cmd.Parameters.AddWithValue("@nome",txtNome.Text);
                        cmd.Parameters.AddWithValue("@data",txtData.Text);
                        cmd.Parameters.AddWithValue("@saldo",txtSaldo.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!!!");
                        carregarAluno();
                    }
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
                        cmd.Connection = conexao;
                        cmd.CommandText = @"UPDATE aluno 
                                            SET Nome_Aluno = @nome, Data_Nasc = @data, Saldo = @saldo
                                            WHERE N_Aluno = @codigo";
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@data", txtData.Text);
                        cmd.Parameters.AddWithValue("@saldo", Convert.ToDouble(txtSaldo.Text));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Dados atualizados com sucesso!!!");
                        carregarAluno();
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
    }
}
