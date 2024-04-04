using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

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
    }
}
