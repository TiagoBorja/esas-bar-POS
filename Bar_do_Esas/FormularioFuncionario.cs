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

            carregarFuncionario();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = @"INSERT INTO Funcionario 
                                            VALUES(@codigo,@nome,@entrada,@saida)";
                        cmd.Parameters.AddWithValue("@codigo",txtCodigo.Text);
                        cmd.Parameters.AddWithValue("@nome",txtNome.Text);
                        cmd.Parameters.AddWithValue("@entrada",txtEntrada.Text);
                        cmd.Parameters.AddWithValue("@saida",txtSaida.Text);
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

                                string entradaStr = entrada.ToString("yyyy-MM-dd HH:mm-ss");
                                string saidaStr = entrada.ToString("yyyy-MM-dd HH:mm-ss");

                                string[] row = {codigo,nome,entradaStr,saidaStr};
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
    }
}
