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
    }
}
