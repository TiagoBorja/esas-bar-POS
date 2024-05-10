using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_do_Esas
{
    public class Bar
    {
        public int N_Aluno { get; set; }
        public int Cod_Comida { get; set; }
        public DateTime Data_Compra { get; set; } = DateTime.Now;
        public decimal Valor_Gasto { get; set; }
        public int Quantidade { get; set; }   
    }
}
