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
    }
}
