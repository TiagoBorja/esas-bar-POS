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
        FormularioBar formularioBar;
        TextBoxConfig txtConfig = new TextBoxConfig();
        Funcionario funcionario = new Funcionario();
        public LoginFuncionario(FormularioBar formularioBar, int id)
        {
            InitializeComponent();
            this.formularioBar = formularioBar;
            this.txtGunaCodigo.Text = id.ToString();
        }

        private void btnGuna_Click(object sender, EventArgs e)
        {
            if (txtConfig.ChecarCamposVaziosGuna(this))
            {
                int codigo = Convert.ToInt32(txtGunaCodigo.Text);
                string senha = txtGunaSenha.Text;
                Label lblNome = formularioBar.lblNome;

                funcionario.FazerLogin(codigo, senha, lblNome);
                this.Close();
                FuncionarioLogado();
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

        private void label3_Click(object sender, EventArgs e)
        {
            CriarFuncionario funcionario = new CriarFuncionario();
            funcionario.ShowDialog();
        }

        private void FuncionarioLogado()
        {
            Globais.logado = true;
            formularioBar.pb_ledLogado.Image = Properties.Resources.led_verde;
            formularioBar.N_Funcionario = Convert.ToInt32(txtGunaCodigo.Text);
            formularioBar.btnEntrarSair.Text = "Sair";
        }

    }
}
