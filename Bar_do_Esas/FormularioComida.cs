using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_do_Esas
{
    public partial class FormularioComida : Form
    {
        TextBoxConfig txtConfig = new TextBoxConfig();
        bool modoEdicaoAtivado = false;
        public FormularioComida()
        {
            InitializeComponent();

            GerirAcoesLstComida.CriarColunasLstComida(lstComida);
            carregarComida();
        }

        private void carregarComida()
        {
            try
            {
                //Clear a ListView before load all studentes, for that not have a redundance of data.
                lstComida.Items.Clear();
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = @"SELECT * FROM infocomida ORDER BY Cod_Comida";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string codigo = reader.GetInt32(0).ToString();
                                string nome = reader.GetString(1);
                                string valor = reader.GetDouble(2).ToString();

                                string[] row = { codigo, nome, valor };
                                var linha_lstView = new ListViewItem(row);
                                lstComida.Items.Add(linha_lstView);
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
        private void lstComida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var codigo = txtCodigo.Text;
            var nome = txtNome.Text;
            var valor = txtValor.Text;
            try
            {
                if (!modoEdicaoAtivado)
                {
                    TextBoxConfig.HabilitarEdicao(txtNome,txtValor);
                    modoEdicaoAtivado = true;
                }
                else
                {

                    if (txtConfig.ChecarCamposVazios(this))
                    {
                        using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                        {
                            //Open the conection
                            conexao.Open();
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                cmd.Connection = conexao;
                                cmd.CommandText = @"INSERT INTO infocomida (Cod_Comida,Descricao_Comida,Valor_Comida)
                                                   VALUES (@codigo,@descricao,@valor)";
                                cmd.Parameters.AddWithValue("@codigo", codigo);
                                cmd.Parameters.AddWithValue("@descricao", nome);
                                cmd.Parameters.AddWithValue("@valor", valor);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Novo item inserido","Inserido com sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                                //After insert, uptade the list view
                                carregarComida();
                            }   
                        }
                    }
                    TextBoxConfig.DesabilitarEdicao(txtNome,txtValor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var codigo = txtCodigo.Text;
            var nome = txtNome.Text;
            var valor = txtValor.Text;
            try
            {
                if (!modoEdicaoAtivado)
                {
                    TextBoxConfig.HabilitarEdicao(txtNome,txtValor);
                    modoEdicaoAtivado = true;
                    btnUpdate.Text = "Salvar Alterações";
                }
                else
                {
                    if (txtConfig.ChecarCamposVazios(this))
                    {
                        DialogResult msg = MessageBox.Show("Confirmar atualização?", "Atualizar Comida", MessageBoxButtons.YesNo);

                        // Check if the user want realize update in the student.
                        if (msg == DialogResult.Yes)
                        {
                            using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                            {
                                conexao.Open();
                                using (MySqlCommand cmd = new MySqlCommand())
                                {
                                    cmd.Connection = conexao;
                                    cmd.CommandText = @"UPDATE infocomida
                                                    SET Descricao_Comida = @descricao, Valor_Comida = @valor
                                                    WHERE Cod_Comida = @codigo";
                                    cmd.Parameters.AddWithValue("@codigo", codigo);
                                    cmd.Parameters.AddWithValue("@descricao", nome);
                                    cmd.Parameters.AddWithValue("@valor", Convert.ToDouble(valor));
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Comida atualizado com sucesso!");

                                    //After insert, uptade the list view
                                    carregarComida();
                                }
                            }
                        }
                        else MessageBox.Show("Nenhum dado foi alterado.");   
                    }

                    TextBoxConfig.DesabilitarEdicao(txtNome,txtValor);
                    modoEdicaoAtivado = false;
                    btnUpdate.Text = "Atualizar Comida";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult msg = MessageBox.Show("Confirmar exclusão?", "Excluir Aluno", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                {
                    using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                    {
                        conexao.Open();
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.Connection = conexao;
                            cmd.CommandText = @"DELETE FROM infocomida
                                            WHERE Cod_Comida = @codigo";
                            cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                            cmd.ExecuteNonQuery();

                            //After insert, uptade the list view
                            carregarComida();
                        }
                    }
                }
                else MessageBox.Show("Nenhum item foi excluido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstComida_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lstComida.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                txtCodigo.Text = item.SubItems[0].Text;
                txtNome.Text = item.SubItems[1].Text;
                txtValor.Text = item.SubItems[2].Text;
            }
        }
    }
}

