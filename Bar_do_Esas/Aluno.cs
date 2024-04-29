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

        public void CriarNovoAluno(string codigo, string nome, DateTime dataNascimento, decimal saldo)
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


    }
}
