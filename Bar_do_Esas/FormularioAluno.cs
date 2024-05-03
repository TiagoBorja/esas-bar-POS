using System;
using System.Windows.Forms;

namespace Bar_do_Esas
{
    public partial class FormularioAluno : Form
    {
        TextBoxConfig txtConfig = new TextBoxConfig();
        bool modoEdicaoAtivado = false;
        Aluno aluno;
        public FormularioAluno()
        {
            InitializeComponent();
            GerirAcoesLstAluno.CriarColunasLstAluno(lstAluno);

            aluno = new Aluno();
            aluno.CarregarAluno(lstAluno);

            txtCodigo.KeyPress += txtConfig.SomenteNumeros;
            txtSaldo.KeyPress += txtConfig.SomenteNumeros;
            txtData.KeyPress += txtConfig.SomenteNumeros;
            txtNome.KeyPress += txtConfig.SomenteLetras;
            
        }
        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                if (!modoEdicaoAtivado)
                {
                    TextBoxConfig.HabilitarEdicao(txtCodigo, txtNome, txtSaldo, txtData);
                    modoEdicaoAtivado = true;
                }
                else
                {
                    
                    if(txtConfig.ChecarCamposVazios(this))
                    {
                        int codigo = Convert.ToInt32(txtCodigo.Text);
                        string nome = txtNome.Text;
                        DateTime dataNascimento = DateTime.Parse(txtData.Text);
                        decimal saldo = decimal.Parse(txtSaldo.Text);

                        aluno.CriarNovoAluno(codigo,nome,dataNascimento,saldo);
                    }
                    
                    TextBoxConfig.DesabilitarEdicao(txtCodigo, txtNome, txtData, txtSaldo);
                    modoEdicaoAtivado = false;
                    aluno.CarregarAluno(lstAluno);
                    txtConfig.LimparTextBox(txtCodigo, txtNome, txtSaldo, txtData);
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!modoEdicaoAtivado)
            {
                TextBoxConfig.HabilitarEdicao(txtNome, txtSaldo, txtData);
                modoEdicaoAtivado = true;
            }
            else
            {

                if (txtConfig.ChecarCamposVazios(this))
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);
                    string nome = txtNome.Text;
                    DateTime dataNascimento = DateTime.Parse(txtData.Text);
                    decimal saldo = decimal.Parse(txtSaldo.Text);

                    aluno.AtualizarAluno(codigo, nome, dataNascimento, saldo);
                }

                TextBoxConfig.DesabilitarEdicao(txtNome, txtData, txtSaldo);
                modoEdicaoAtivado = false;
                aluno.CarregarAluno(lstAluno);
                txtConfig.LimparTextBox(txtCodigo, txtNome, txtSaldo, txtData);
            }
        }

        private void lstAluno_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lstAluno.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                txtCodigo.Text = item.SubItems[0].Text;
                txtNome.Text = item.SubItems[1].Text;
                txtData.Text = item.SubItems[2].Text;
                txtSaldo.Text = item.SubItems[3].Text;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!modoEdicaoAtivado)
            {
                TextBoxConfig.HabilitarEdicao(txtNome, txtSaldo, txtData);
                modoEdicaoAtivado = true;
            }
            else
            {
                if (txtConfig.ChecarCamposVazios(this))
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);
                    aluno.ExcluirAluno(codigo);
                }

                aluno.CarregarAluno(lstAluno);
                txtConfig.LimparTextBox(txtCodigo, txtNome, txtSaldo, txtData);
            }   
        }
    }
}
