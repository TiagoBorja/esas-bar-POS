using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Bar_do_Esas
{
    internal class BaseDados
    {
        public static MySqlConnection ConectarBD()
        {
            MySqlConnection conexao = new MySqlConnection(Globais.data_source);

            try
            {
                conexao.Open();
                return conexao;
            }
            catch
            {
                conexao.Dispose(); 
                return null;
            }
        }

        public static void AtualizarSaldoAluno(decimal novoSaldo, int N_Aluno)
        {
            try
            {
                using (MySqlConnection conexao = ConectarBD())
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = @"UPDATE aluno
                                        SET Saldo = @novoSaldo
                                        WHERE N_Aluno = @N_Aluno";
                        cmd.Parameters.AddWithValue("@novoSaldo",novoSaldo);
                        cmd.Parameters.AddWithValue("@N_Aluno",N_Aluno);
                        cmd.ExecuteNonQuery();
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
