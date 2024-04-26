using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_do_Esas
{
    public class GerirAcoesListView
    {
        public static void CriarColunasLstComida(ListView lstComida)
        {
            lstComida.View = View.Details;
            lstComida.LabelEdit = true;
            lstComida.AllowColumnReorder = true;
            lstComida.FullRowSelect = true;
            lstComida.GridLines = true;

            lstComida.Columns.Add("Nome", 158, HorizontalAlignment.Left);
            lstComida.Columns.Add("Valor", 80, HorizontalAlignment.Left);
            lstComida.Columns.Add("Quantidade", 80, HorizontalAlignment.Left);
        }

        public static void AdicionarItemNoListView(int[] idComida, NumericUpDown qntItem, ListView lstComida, Label lblTotal)
        {
            try
            {
                using (MySqlConnection conexao = BaseDados.ConectarBD())
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = @"SELECT Descricao_Comida, Valor_Comida FROM infocomida WHERE Cod_Comida = @idComida";
                        cmd.Parameters.AddWithValue("@idComida", idComida[0]);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var descricaoComida = reader.GetString(0);
                                var valorComida = reader.GetDecimal(1).ToString("N2");
                                var quantidadeString = qntItem.Value.ToString();
                                string[] row = { descricaoComida, valorComida, quantidadeString };

                                lstComida.Items.Add(new ListViewItem(row));
                            }
                        }
                    }
                }
                ValorTotalAdicionado(idComida, lstComida, 0, lblTotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void ValorTotalAdicionado(int[] idComida, ListView lstComida, decimal totalAcumulado, Label lblTotal)
        {
            decimal total = 0;

            Array.Resize(ref idComida, lstComida.Items.Count);

            foreach (ListViewItem item in lstComida.Items)
            {
                //remove the items from your respectives columns and atribute your value in variable
                var valorString = item.SubItems[1].Text;
                var quantidadeString = item.SubItems[2].Text;

                if (decimal.TryParse(valorString, out decimal valor) && int.TryParse(quantidadeString, out int quantidade))
                {
                    total += valor * quantidade;
                }
            }
            totalAcumulado = total;
            lblTotal.Text = totalAcumulado.ToString("N2");
        }

        public static void ValorTotalRemovido(decimal totalAcumulado, decimal somarValorFaltante, ListView lstComida, Label lblTotal, Label lblSaldoAluno)
        {
            totalAcumulado = 0;

            foreach (ListViewItem item in lstComida.SelectedItems)
            {
                totalAcumulado = decimal.Parse(item.SubItems[1].Text) * int.Parse(item.SubItems[2].Text);
                lstComida.Items.Remove(item);

            }

            somarValorFaltante = Convert.ToDecimal(lblSaldoAluno.Text) + Convert.ToDecimal(totalAcumulado);
            lblSaldoAluno.Text = somarValorFaltante.ToString("N2");

            lblTotal.Text = Convert.ToString(Convert.ToDecimal(lblTotal.Text) - totalAcumulado);
        }

        public void ChecarSaldoAluno(int[] idComida,ListView lstComida,Label lblSaldoAluno,Label lblTotal,NumericUpDown qntItem)
        {
            decimal valorComidaSelecionada = 0;

            int quantidade = Convert.ToInt32(qntItem.Value);
            decimal saldoAluno = Convert.ToDecimal(lblSaldoAluno.Text);

            using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
            {
                conexao.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conexao;
                    cmd.CommandText = "SELECT Valor_Comida FROM infocomida WHERE Cod_Comida = @id";

                    //Select the value when the id is equals a idComidaSelecionada
                    cmd.Parameters.AddWithValue("@id", idComida[0]);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Search the column in the database
                            valorComidaSelecionada = reader.GetDecimal("Valor_Comida");

                            //Sum the value the food * quantity solicited
                            valorComidaSelecionada *= Convert.ToDecimal(quantidade);

                            if (valorComidaSelecionada <= saldoAluno)
                            {
                                AdicionarItemNoListView(idComida, qntItem, lstComida, lblTotal);

                                //after add a item, subtract the value in your balance in an abstract way
                                saldoAluno -= valorComidaSelecionada;
                                lblSaldoAluno.Text = saldoAluno.ToString("N2");
                            }
                            else MessageBox.Show("Seu saldo é inferior ao saldo requisitado", "Saldo Insuficiente");
                        }
                    }
                }
            }
        }
    }
}
