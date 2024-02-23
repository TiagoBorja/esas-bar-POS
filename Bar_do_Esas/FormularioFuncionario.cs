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
            lstFuncionario.Columns.Add("Data de Entrada", 100, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("Data de Saída", 100, HorizontalAlignment.Left);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
