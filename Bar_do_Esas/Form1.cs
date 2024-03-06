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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoginFuncionario f_login = new LoginFuncionario(this);
            f_login.ShowDialog();
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
            MessageBox.Show("Testando Git!");
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
    }
}
