using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace Bar_do_Esas
{
    public class BaseDados
    {
        public static MySqlConnection ConectarBD()
        {
            MySqlConnection conexao = new MySqlConnection(Globais.data_source);

            try
            {
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                return null;
            }
        }

        public static void AtualizarSaldoAluno(decimal novoSaldo, int N_Aluno)
        {
            using (MySqlConnection conexao = ConectarBD())
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
