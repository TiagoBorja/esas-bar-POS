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
        TextBoxConfig txtConfig = new TextBoxConfig();
        Funcionario funcionario;
        public CriarFuncionario()
        {
            InitializeComponent();

            txtGunaCodigo.KeyPress += txtConfig.SomenteNumeros;
            txtGunaSenha.KeyPress += txtConfig.SomenteNumeros;
            txtGunaNome.KeyPress += txtConfig.SomenteLetrasGuna;
            
            txtGunaCodigo.TextChanged += txtConfig.RemoverEspacosGuna;            
            txtGunaSenha.TextChanged += txtConfig.RemoverEspacosGuna;

            funcionario = new Funcionario();
        }

        private void btnGuna_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfig.ChecarCamposVaziosGuna(this))
                {
                    int codigo = Convert.ToInt32(txtGunaCodigo.Text);
                    string nome = txtGunaNome.Text;
                    string senha = txtGunaSenha.Text;

                    funcionario.CriarNovoFuncionario(codigo,nome,senha);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSenha.Checked)
                txtGunaSenha.PasswordChar = '\0';
            else
                txtGunaSenha.PasswordChar = '*';
        }
    }
}
