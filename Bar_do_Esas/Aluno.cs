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
                using (MySqlConnection conexao = BaseDados.ConectarBD())
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
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar aluno: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ExcluirAluno(int codigo)
        {
            try
            {
                using (MySqlConnection conexao = BaseDados.ConectarBD())
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        DialogResult msg = MessageBox.Show("Confirmar exclusão?", "Excluir Aluno", MessageBoxButtons.YesNo);

                        if (msg == DialogResult.Yes)
                        {
                            cmd.Connection = conexao;
                            cmd.CommandText = @"DELETE FROM aluno
                                           WHERE N_Aluno = @codigo";
                            cmd.Parameters.AddWithValue("@codigo", codigo);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Aluno excluido com sucesso!", "Aluno Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Nenhum dado alterado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir aluno: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CarregarAluno(ListView lstAluno)
        {
            try
            {
                //Clear a ListView before load all studentes, for that not have a redundance of data.
                lstAluno.Items.Clear();
                using (MySqlConnection conexao = BaseDados.ConectarBD())
                {
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
        public static void AtualizarSaldoAluno(decimal novoSaldo, int N_Aluno)
        {
            using (MySqlConnection conexao = BaseDados.ConectarBD())
            {
                if (conexao == null)
                {
                    MessageBox.Show("Não foi possível conectar ao banco de dados.");
                    return;
                }

                MySqlTransaction transaction = null;
                try
                {
                    transaction = conexao.BeginTransaction();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.Transaction = transaction;
                        cmd.CommandText = @"UPDATE aluno
                                            SET Saldo = @novoSaldo
                                            WHERE N_Aluno = @N_Aluno";
                        cmd.Parameters.AddWithValue("@novoSaldo", novoSaldo);
                        cmd.Parameters.AddWithValue("@N_Aluno", N_Aluno);
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                        transaction.Rollback();
                    MessageBox.Show("Erro ao atualizar saldo do aluno: " + ex.Message);
                }
            }
        }

    }
}
