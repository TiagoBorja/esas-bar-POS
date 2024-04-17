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
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace Bar_do_Esas
{
    public partial class CriarFuncionario : Form
    {
        public CriarFuncionario()
        {
            InitializeComponent();

            txtGunaCodigo.KeyPress += SomenteNumeros;
            txtGunaSenha.KeyPress += SomenteNumeros;
            txtGunaNome.KeyPress += SomenteLetras;
            
            txtGunaCodigo.TextChanged += RemoverEspacos;
            txtGunaNome.TextChanged += RemoverEspacos;
            txtGunaSenha.TextChanged += RemoverEspacos;
        }

        private void btnGuna_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Controls.OfType<Guna2TextBox>().Any(f => string.IsNullOrEmpty(f.Text)))                
                    MessageBox.Show("É necessário preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
                else                
                    NovoFuncionario();
                
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

        private void RemoverEspacos(object sender, EventArgs e)
        {
            Guna2TextBox txt = (Guna2TextBox)sender;

            txt.Text = txt.Text.Replace(" ", "");
        }

        private void SomenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))           
                e.Handled = true;            
        }

        private void SomenteLetras(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox txt = (Guna2TextBox)sender;

            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                // Se não for uma letra, um espaço ou uma tecla de controle, cancela o evento de pressionar tecla
                e.Handled = true;            
        }
        
        private void NovoFuncionario()
        {
            using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
            {
                conexao.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conexao;
                    cmd.CommandText = @"INSERT INTO dados_funcionario
                                           VALUES(@codigo,@nome,@senha)";
                    cmd.Parameters.AddWithValue("@codigo", txtGunaCodigo.Text);
                    cmd.Parameters.AddWithValue("@nome", txtGunaNome.Text);
                    cmd.Parameters.AddWithValue("@senha", txtGunaSenha.Text);
                    cmd.ExecuteNonQuery();

                    this.Close();
                    MessageBox.Show("Funcionário criado com sucesso!");
                }
            }
        }
    }
}
