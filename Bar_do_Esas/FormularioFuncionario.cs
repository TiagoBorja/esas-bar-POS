using MySql.Data.MySqlClient;
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var codigo = txtCodigo.Text;
            var nome = txtNome.Text;
            var senha = BCrypt.Net.BCrypt.EnhancedHashPassword(txtSenha.Text, 13);
            try
            {
                if (!txtNome.ReadOnly == false && !txtCodigo.ReadOnly == false && !txtSenha.ReadOnly == false)
                {
                    tirarReadOnly();
                }
                else
                {
                    if (!String.IsNullOrEmpty(codigo) && !String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(senha))
                    {
                        using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                        {
                            conexao.Open();

                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                cmd.Connection = conexao;
                                cmd.CommandText = @"INSERT INTO dados_funcionario
                                           VALUES(@codigo,@nome,@senha)";
                                cmd.Parameters.AddWithValue("@codigo", codigo);
                                cmd.Parameters.AddWithValue("@nome", nome);
                                cmd.Parameters.AddWithValue("@senha", senha);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Funcionário criado com sucesso!");
                            }
                        }
                    }
                    else MessageBox.Show("Sem dados suficientes para a inserção de dados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tirarReadOnly()
        {
            txtCodigo.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtSenha.ReadOnly = false;

            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha.Clear();
        }
        private void adicionarReadOnly()
        {
            txtNome.ReadOnly = true;
            txtCodigo.ReadOnly = true;
            txtSenha.ReadOnly = true;

            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha.Clear();
        }

        private void tirarReadOnlyEmUpdate()
        {
            txtNome.ReadOnly = false;
            txtSenha.ReadOnly = false;
        }
        private void adicionarReadOnlyEmUpdate()
        {
            txtNome.ReadOnly = true;           
            txtSenha.ReadOnly = true;

            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha.Clear();
        }
    }

}
