using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_do_Esas
{
    public class Aluno
    {
        public int N_Aluno { get; set; }
        public string Nome_Aluno { get; set; }
        public DateTime Data_Nasc { get; set; }
        public decimal Saldo { get; set; }

        public void CriarNovoAluno(int codigo, string nome, DateTime dataNascimento, decimal saldo)
        {
            try
            {
                TextBoxConfig txtConfig = new TextBoxConfig();
                using (MySqlConnection conexao = BaseDados.ConectarBD())
                {
                    // Verifica se a conexão foi aberta com sucesso
                    if (conexao.State == ConnectionState.Open)
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.Connection = conexao;
                            cmd.CommandText = @"INSERT INTO aluno (N_Aluno,Nome_Aluno,Data_Nasc,Saldo)
                                                VALUES (@codigo, @nome, @data, @saldo)";

                            cmd.Parameters.AddWithValue("@codigo", codigo);
                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@data", dataNascimento);
                            cmd.Parameters.AddWithValue("@saldo", saldo);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Aluno criado com sucesso!", "Aluno Criado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }   
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível abrir a conexão com o banco de dados!", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar aluno: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AtualizarAluno(int codigo, string nome, DateTime dataNascimento, decimal saldo)
        {
            try
            {
                TextBoxConfig txtConfig = new TextBoxConfig();
                using (MySqlConnection conexao = BaseDados.ConectarBD())
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        if (conexao.State == ConnectionState.Open)
                        {
                            DialogResult msg = MessageBox.Show("Confirmar atualização?", "Atualizar Aluno", MessageBoxButtons.YesNo);

                            if (msg == DialogResult.Yes)
                            {
                                cmd.Connection = conexao;
                                cmd.CommandText = @"UPDATE aluno 
                                            SET Nome_Aluno = @nome, Data_Nasc = @data, Saldo = @saldo
                                            WHERE N_Aluno = @codigo";
                                cmd.Parameters.AddWithValue("@codigo", codigo);
                                cmd.Parameters.AddWithValue("@nome", nome);
                                cmd.Parameters.AddWithValue("@data", dataNascimento);
                                cmd.Parameters.AddWithValue("@saldo", saldo);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Aluno atualizado com sucesso!", "Aluno Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else MessageBox.Show("Nenhum dado alterado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível abrir a conexão com o banco de dados!", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar aluno: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CarregarAluno(ListView lstAluno)
        {
            try
            {
                //Clear a ListView before load all studentes, for that not have a redundance of data.
                lstAluno.Items.Clear();
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = @"SELECT * FROM aluno ORDER BY Nome_Aluno";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string codigo = reader.GetInt32(0).ToString();
                                string nome = reader.GetString(1);
                                DateTime dataNascimento = reader.GetDateTime(2);

                                string dataNascimentoStr = dataNascimento.ToString("yyyy-MM-dd");

                                string saldo = reader.GetDouble(3).ToString();

                                string[] row = { codigo, nome, dataNascimentoStr, saldo };
                                var linha_lstView = new ListViewItem(row);
                                lstAluno.Items.Add(linha_lstView);
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
    }
}
