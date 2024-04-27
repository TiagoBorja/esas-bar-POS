using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_do_Esas
{
    public class TextBoxConfig
    {
        #region Functions TextBox
        public bool ChecarCamposVazios(Form form)
        {
            if (form.Controls.OfType<TextBox>().Any(f => string.IsNullOrWhiteSpace(f.Text)))
            {
                MessageBox.Show("É necessário preencher todos os campos antes de prosseguir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
                return true;
        }
        public void SomenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        public void SomenteLetras(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                // Se não for uma letra, um espaço ou uma tecla de controle, cancela o evento de pressionar tecla
                e.Handled = true;
        }
        public void RemoverEspacos(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace(" ", "");
        }
        public static void HabilitarEdicao(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.ReadOnly = false;
                textBox.BackColor = Color.White;
            }
        }
        public static void DesabilitarEdicao(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.ReadOnly = true;
                textBox.BackColor = SystemColors.Control;
            }
        }
        #endregion

        #region Functions GunaTextBox
        public bool ChecarCamposVaziosGuna(Form form)
        {
            if (form.Controls.OfType<Guna2TextBox>().Any(f => string.IsNullOrWhiteSpace(f.Text)))
            {
                MessageBox.Show("É necessário preencher todos os campos antes de prosseguir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
                return true;
        }
        public void SomenteLetrasGuna(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox txt = (Guna2TextBox)sender;

            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                // Se não for uma letra, um espaço ou uma tecla de controle, cancela o evento de pressionar tecla
                e.Handled = true;
        }
        public void RemoverEspacosGuna(object sender, EventArgs e)
        {
            Guna2TextBox txt = (Guna2TextBox)sender;

            txt.Text = txt.Text.Replace(" ", "");
        }
        #endregion
    }
}
