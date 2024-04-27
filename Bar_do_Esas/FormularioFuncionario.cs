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
        TextBoxConfig txtConfig = new TextBoxConfig();
        bool modoEdicaoAtivado = false;
        public FormularioFuncionario()
        {
            InitializeComponent();

            GerirAcoesLstFuncionario.CriarColunasLstFuncionario(lstFuncionario);

            carregarFuncionario();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CriarFuncionario f = new CriarFuncionario();
            f.ShowDialog();
            carregarFuncionario();
        }
        private void adicionarReadOnly()
        {
            txtNome.ReadOnly = true;
            txtCodigo.ReadOnly = true;

            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void tirarReadOnlyEmUpdate()
        {
            txtNome.ReadOnly = false;
        }
        private void adicionarReadOnlyEmUpdate()
        {
            txtNome.ReadOnly = true;                    

            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var codigo = txtCodigo.Text;
            var nome = txtNome.Text;

            try
            {
                if (!modoEdicaoAtivado)
                {
                    TextBoxConfig.HabilitarEdicao(txtNome);
                    modoEdicaoAtivado = true;
                    btnUpdate.Text = "Salvar Alterações";
                }
                else
                {
                    if (txtConfig.ChecarCamposVazios(this))
                    {
                        DialogResult msg = MessageBox.Show("Confirmar atualização?", "Atualizar Aluno", MessageBoxButtons.YesNo);

                        if (msg == DialogResult.Yes)
                        {
                            using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                            {
                                conexao.Open();
                                using (MySqlCommand cmd = new MySqlCommand())
                                {
                                    cmd.Connection = conexao;
                                    cmd.CommandText = @"UPDATE dados_funcionario
                                                    SET Nome_Funcionario = @nome
                                                    WHERE N_Funcionario = @codigo";
                                    cmd.Parameters.AddWithValue("@codigo", codigo);
                                    cmd.Parameters.AddWithValue("@nome", nome);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Funcionário atualizado com sucesso!");
                                }
                            }
                            carregarFuncionario();

                            TextBoxConfig.DesabilitarEdicao(txtNome);
                            modoEdicaoAtivado = false;
                            btnUpdate.Text = "Atualizar Funcionário";
                        }
                        else MessageBox.Show("Nenhum dado foi alterado.");
                        
                    }
                }
                    
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void carregarFuncionario()
        {
            try
            {
                lstFuncionario.Items.Clear();
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = @"SELECT * FROM dados_funcionario ORDER BY Nome_Funcionario";
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string codigo = reader.GetInt32(0).ToString();
                                string nome = reader.GetString(1).ToString();
                                string senha = reader.GetString(2).ToString();
                                string[] row = { codigo, nome, senha};
                                var linha_lstView = new ListViewItem(row);
                                lstFuncionario.Items.Add(linha_lstView);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstAluno_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lstFuncionario.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                txtCodigo.Text = item.SubItems[0].Text;
                txtNome.Text = item.SubItems[1].Text;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult msg = MessageBox.Show("Confirmar exclusão?", "Excluir Aluno", MessageBoxButtons.YesNo);

                if(msg == DialogResult.Yes)
                {
                    using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                    {
                        conexao.Open();

                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.Connection = conexao;
                            cmd.CommandText = @"DELETE FROM dados_funcionario
                                           WHERE N_Funcionario = @codigo";
                            cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Funcionário deletado com sucesso!");
                        }
                    }
                    carregarFuncionario();
                    adicionarReadOnly();
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
