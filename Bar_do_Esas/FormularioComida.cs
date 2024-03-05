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
        public FormularioComida()
        {
            InitializeComponent();

            lstComida.View = View.Details;
            lstComida.LabelEdit = true;
            lstComida.AllowColumnReorder = true;
            lstComida.FullRowSelect = true;
            lstComida.GridLines = true;

            lstComida.Columns.Add("Código", 60, HorizontalAlignment.Left);
            lstComida.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            lstComida.Columns.Add("Valor", 60, HorizontalAlignment.Left);

            carregarComida();
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
        private void tirarReadOnly()
        {
            txtNome.ReadOnly = false;
            txtValor.ReadOnly = false;
            txtCodigo.ReadOnly = false;

            txtCodigo.Clear();
            txtNome.Clear();
            txtValor.Clear();
        }
        private void adicionarReadOnly()
        {
            txtNome.ReadOnly = true;
            txtValor.ReadOnly = true;
            txtCodigo.ReadOnly = true;

            txtCodigo.Clear();
            txtNome.Clear();
            txtValor.Clear();
        }

        private void tirarReadOnlyEmUpdate()
        {
            txtValor.ReadOnly = false;
            txtNome.ReadOnly = false;
        }
        private void adicionarReadOnlyEmUpdate()
        {
            txtNome.ReadOnly = true;
            txtValor.ReadOnly = true;
            txtCodigo.ReadOnly = true;

            txtCodigo.Clear();
            txtNome.Clear();
            txtValor.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var codigo = txtCodigo.Text;
            var nome = txtNome.Text;
            var valor = txtValor.Text;
            try
            {
                if (!txtNome.ReadOnly == false && !txtCodigo.ReadOnly == false && !txtValor.ReadOnly == false)
                {
                    tirarReadOnly();
                }
                else
                {
                    if (!String.IsNullOrEmpty(codigo) && !String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(valor))
                    {
                        using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                        {
                            conexao.Open();
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                cmd.Connection = conexao;
                                cmd.CommandText = @"INSERT INTO infocomida (Cod_Comida,Descricao_Comida,Valor_Comida)
                                                   VALUES (@codigo,@descricao,@valor)";
                                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                                cmd.Parameters.AddWithValue("@descricao", txtNome.Text);
                                cmd.Parameters.AddWithValue("@valor", Convert.ToDouble(txtValor.Text));

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Comida inserida com sucesso!!!");
                            }
                            carregarComida();       
                        }
                    }
                    else MessageBox.Show("Sem dados suficientes para a inserção de dados.");
                    adicionarReadOnly();
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
                if (!txtNome.ReadOnly == false && !txtValor.ReadOnly == false)
                {
                    tirarReadOnlyEmUpdate();
                }
                else
                {
                    if (!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(valor))
                    {
                        DialogResult msg = MessageBox.Show("Confirmar atualização?", "Atualizar Comida", MessageBoxButtons.YesNo);

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
                                }
                            }
                            carregarComida();
                        }
                        else MessageBox.Show("Nenhum dado foi alterado.");   
                    }
                    else MessageBox.Show("Sem dados suficientes para a atualização dos dados.");
                    adicionarReadOnlyEmUpdate();
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
                            carregarComida();
                        }
                    }
                }
                else MessageBox.Show("Nenhum item foi excluido.");
                adicionarReadOnly();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

