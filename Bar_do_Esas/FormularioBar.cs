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
    public partial class FormularioBar : Form
    {

        DataSet comida;

        public FormularioBar()
        {
            InitializeComponent();

            LoginFuncionario f_login = new LoginFuncionario(this);
            f_login.ShowDialog();

            preencherCombo();

            lstComida.View = View.Details;
            lstComida.LabelEdit = true;
            lstComida.AllowColumnReorder = true;
            lstComida.FullRowSelect = true;
            lstComida.GridLines = true;

            lstComida.Columns.Add("Nome", 158, HorizontalAlignment.Left);
            lstComida.Columns.Add("Valor", 80, HorizontalAlignment.Left);
            lstComida.Columns.Add("Quantidade", 80, HorizontalAlignment.Left);

            
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            FormularioAluno f_aluno = new FormularioAluno();
            f_aluno.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add items from combo box in the list view
            //lstComida.Items.Add(comboBox1.SelectedItem.ToString());

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                    using(MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = @"SELECT Descricao_Comida,Valor_Comida FROM infocomida Where Cod_Comida = @id";
                        cmd.Parameters.AddWithValue("@id",comboBox1.SelectedValue.ToString());

                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var comida = reader.GetString(0);
                                var valor = reader.GetDouble(1).ToString();
                                var quantidade = qntItem.Value.ToString();
                                string[] row = {comida, valor, quantidade};

                                lstComida.Items.Add(new ListViewItem(row));
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Insira o código do aluno.", "Código Aluno"));

                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = @"SELECT N_Aluno,Nome_Aluno,Saldo FROM aluno
                                            WHERE N_Aluno = @codigo";
                        cmd.Parameters.AddWithValue("@codigo", numero);
                        
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lblCodigoAluno.Text = reader.GetInt32(0).ToString();
                                lblNomeAluno.Text = reader.GetString(1);
                                lblSaldoAluno.Text = reader.GetDouble(2).ToString();

                                lblCodigoAluno.Visible = true;
                                lblNomeAluno.Visible = true;
                                lblSaldoAluno.Visible = true;
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

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FormularioFuncionario f = new FormularioFuncionario();

            //Open the FormularioFuncionario.
            f.ShowDialog();
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            FormularioComida f = new FormularioComida();
            f.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCodigoAluno.ResetText();
            lblNomeAluno.ResetText();
            lblSaldoAluno.ResetText();
        }

        private void preencherCombo()
        {
            string sql = "SELECT * FROM infocomida";
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                    using (MySqlDataAdapter daComida = new MySqlDataAdapter(sql, conexao))
                    {
                        comida = new DataSet();
                        daComida.Fill(comida);
                        comboBox1.DataSource = comida.Tables[0];
                        comboBox1.ValueMember = "Cod_Comida";
                        comboBox1.DisplayMember = "Descricao_Comida";
                        comboBox1.SelectedIndex = -1;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstComida_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstComida.SelectedItems)
            {
                lstComida.Items.Remove(item);
            }  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.lblHora.Text = DateTime.Now.ToString("yyyy-MM-dd : HH:mm:ss");
        }

        private void lstComida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
