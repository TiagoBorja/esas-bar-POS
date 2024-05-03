using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.IsisMtt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_do_Esas
{
    public class Funcionario : BaseDados
    {
        public int N_Funcionario { get; set; }
        public string Nome_Funcionario { get; set; }
        public int Senha { get; set; }

        public void CriarNovoFuncionario(int codigo, string nome, string senha)
        {
            try
            {
                senha = BCrypt.Net.BCrypt.EnhancedHashPassword(senha, 13);
                using (ConectarBD())
                {

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.CommandText = @"INSERT INTO dados_funcionario
                                           VALUES(@codigo,@nome,@senha)";
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@senha", senha);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Funcionário criado com sucesso!", "Funcionário Criado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AtualizarFuncionario(int codigo, string nome)
        {
            try
            {
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
                                cmd.CommandText = @"UPDATE dados_funcionario
                                                    SET Nome_Funcionario = @nome
                                                    WHERE N_Funcionario = @codigo";
                                cmd.Parameters.AddWithValue("@codigo", codigo);
                                cmd.Parameters.AddWithValue("@nome", nome);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Funcionário atualizado com sucesso!", "Funcionário Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void ExcluirFuncionario(int codigo)
        {
            try
            {
                using(MySqlConnection conexao = BaseDados.ConectarBD())
                {
                    if(conexao.State == ConnectionState.Open)
                    {
                        using(MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.Connection = conexao;
                            cmd.CommandText = @"DELETE FROM dados_funcionario
                                                WHERE N_Funcionario = @codigo";
                            cmd.Parameters.AddWithValue("@codigo",codigo);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Funcionário excluido com sucesso!", "Funcionário Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Erro ao criar funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void FazerLogin(int codigo,string senha, Label lblNome)
        {
            try
            {
                using (var conexao = ConectarBD())
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        // Search for an employee with the given Code and Password
                        cmd.CommandText = @"SELECT * FROM dados_funcionario
                                            WHERE N_Funcionario = @codigo";
                        cmd.Parameters.AddWithValue("@codigo", codigo);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                //Search column "senha" and read a password hashed
                                string senhaHash = reader.GetString("Senha");

                                //Check if the password hashed are correct
                                bool senhaCorreta = BCrypt.Net.BCrypt.EnhancedVerify(senha, senhaHash);
                                if (senhaCorreta)
                                {
                                    MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    string nomeFuncionario = reader.GetString("Nome_Funcionario");
                                    lblNome.Text = nomeFuncionario;
                                }
                                else
                                {
                                    MessageBox.Show("Funcionário não encontrado.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Funcionário não encontrado.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void CarregarFuncionario(ListView lstFuncionario)
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
                                string[] row = { codigo, nome, senha };
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
    }
}
