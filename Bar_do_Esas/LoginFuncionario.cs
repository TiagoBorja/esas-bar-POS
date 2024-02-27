﻿using System;
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

        private void btnGuna_Click(object sender, EventArgs e)
        {
            var codigo = txtGunaCodigo.Text;
            var senha =  BCrypt.Net.BCrypt.EnhancedHashPassword(txtGunaSenha.Text,13);

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    // Check if the textboxes are not null or empty
                    if (!String.IsNullOrEmpty(codigo) || !String.IsNullOrEmpty(senha))
                    {
                        conexao.Open();
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.Connection = conexao;

                            // Search for an employee with the given Code and Password
                            cmd.CommandText = @"SELECT * FROM Funcionario
                                           WHERE N_Funcionario = @codigo AND Senha = @senha";
                            cmd.Parameters.AddWithValue("@codigo", codigo);
                            cmd.Parameters.AddWithValue("@senha", senha);

                          

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                MessageBox.Show(senha);
                                if (reader.Read())
                                {
                                    string senhaHash = reader.GetString("Senha");
                                    bool senhaCorreta = BCrypt.Net.BCrypt.EnhancedVerify(senha, senhaHash);

                                    if (senhaCorreta)
                                    {
                                        MessageBox.Show("Login bem sucedido!!!");
                                        this.Close();

                                        string nomeFuncionario = reader.GetString("Nome_Funcionario");
                                        form1.lblNome.Text = nomeFuncionario;

                                        // Set a variable indicating that the user is logged in and update a picture box with a green LED
                                        Globais.logado = true;
                                        form1.pb_ledLogado.Image = Properties.Resources.led_verde;
                                    }
                                    else MessageBox.Show("Dados Incorretos!!!");
                                    
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
                txtGunaSenha.PasswordChar = '\0';
            }
            else
            {
                txtGunaSenha.PasswordChar = '*';
            }
        }
    }
}
