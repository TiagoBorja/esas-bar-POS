using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bar_do_Esas
{
    public partial class LoginFuncionario : Form
    {
       Form1 form1;
        public LoginFuncionario(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            //var codigo = txtCodigo.Text;
            //var senha = txtSenha.Text;
            //try
            //{
            //    using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
            //    {
            //        if (!String.IsNullOrEmpty(codigo) || !String.IsNullOrEmpty(senha))
            //        {
            //            conexao.Open();
            //            using (MySqlCommand cmd = new MySqlCommand())
            //            {
            //                cmd.Connection = conexao;
            //                cmd.CommandText = @"SELECT * FROM Funcionario
            //                               WHERE N_Funcionario = @codigo AND Senha = @senha";
            //                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
            //                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

            //                using (MySqlDataReader reader = cmd.ExecuteReader())
            //                {
            //                    if (reader.Read())
            //                    {
            //                        MessageBox.Show("Login bem sucedido!!!");
            //                        this.Close();

            //                        string nomeFuncionario = reader.GetString("Nome_Funcionario");
            //                        form1.lblNome.Text = nomeFuncionario;
            //                        form1.pb_ledLogado.Image = Properties.Resources.led_verde;
            //                        Globais.logado = true;
            //                    }
            //                    else MessageBox.Show("Dados Incorretos!!!");
            //                }
            //            }
            //        }
            //        else MessageBox.Show("Insira dados para poder prosseguir.");
                    
            //    }
            //}catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnGuna_Click(object sender, EventArgs e)
        {
            var codigo = txtGunaCodigo.Text;
            var senha = txtGunaSenha.Text;
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    if (!String.IsNullOrEmpty(codigo) || !String.IsNullOrEmpty(senha))
                    {
                        conexao.Open();
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.Connection = conexao;
                            cmd.CommandText = @"SELECT * FROM Funcionario
                                           WHERE N_Funcionario = @codigo AND Senha = @senha";
                            cmd.Parameters.AddWithValue("@codigo", txtGunaCodigo.Text);
                            cmd.Parameters.AddWithValue("@senha", txtGunaSenha.Text);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    MessageBox.Show("Login bem sucedido!!!");
                                    this.Close();

                                    string nomeFuncionario = reader.GetString("Nome_Funcionario");
                                    form1.lblNome.Text = nomeFuncionario;
                                    form1.pb_ledLogado.Image = Properties.Resources.led_verde;
                                    Globais.logado = true;
                                }
                                else MessageBox.Show("Dados Incorretos!!!");
                            }
                        }
                    }
                    else MessageBox.Show("Insira dados para poder prosseguir.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSenha.Checked)
            {
                txtGunaSenha.PasswordChar = '\0'; // Configura para exibir os caracteres da senha
            }
            else
            {
                txtGunaSenha.PasswordChar = '*'; // Substitua '*' pelo caractere desejado para ocultar os caracteres da senha
            }
        }
    }
}
