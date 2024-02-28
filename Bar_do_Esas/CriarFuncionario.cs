using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace Bar_do_Esas
{
    public partial class CriarFuncionario : Form
    {
        public CriarFuncionario()
        {
            InitializeComponent();
        }

        private void btnGuna_Click(object sender, EventArgs e)
        {
            string senha = BCrypt.Net.BCrypt.EnhancedHashPassword(txtGunaSenha.Text, 13);
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();

                    using(MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = @"INSERT INTO dados_funcionario
                                           VALUES(@codigo,@nome,@senha)";
                        cmd.Parameters.AddWithValue("@codigo", txtGunaCodigo.Text);
                        cmd.Parameters.AddWithValue("@nome", txtGunaNome.Text);
                        cmd.Parameters.AddWithValue("@senha", senha);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Funcionário criado com sucesso!");
                    }
                }
            }catch(Exception ex)
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
