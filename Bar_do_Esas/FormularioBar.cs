using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bar_do_Esas
{
    public partial class FormularioBar : Form
    {    
        decimal totalAcumulado = 0; //variable that stores the balances        
        decimal somarValorFaltante = 0;  //Sum the value in your balance when you remove a item
        public int N_Funcionario;

        int[] idComidaTeste = new int[1];
      
        public FormularioBar()
        {
            InitializeComponent();

            LoginFuncionario f_login = new LoginFuncionario(this,N_Funcionario);
            f_login.ShowDialog();
            lstComida.View = View.Details;
            lstComida.LabelEdit = true;
            lstComida.AllowColumnReorder = true;
            lstComida.FullRowSelect = true;
            lstComida.GridLines = true;

            lstComida.Columns.Add("Nome", 158, HorizontalAlignment.Left);
            lstComida.Columns.Add("Valor", 80, HorizontalAlignment.Left);
            lstComida.Columns.Add("Quantidade", 80, HorizontalAlignment.Left);

            //Pupulation the combo
            preencherCombo();
        }
     
        #region Buttons
        private void btnAluno_Click(object sender, EventArgs e)
        {
            FormularioAluno f_aluno = new FormularioAluno();
            ChecarLogin(f_aluno);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checarSaldo_addItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Search code from someone student
                int numero = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Insira o código do aluno.", "Código Aluno"));

                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = @"SELECT N_Aluno,Nome_Aluno,Saldo FROM aluno
                                            WHERE N_Aluno = @codigo";
                        cmd.Parameters.AddWithValue("@codigo", numero);
                        
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lblCodigoAluno.Text = reader.GetInt32(0).ToString();
                                lblNomeAluno.Text = reader.GetString(1);
                                lblSaldoAluno.Text = reader.GetDouble(2).ToString();

                                lblCodigoAluno.Visible = true;
                                lblNomeAluno.Visible = true;
                                lblSaldoAluno.Visible = true;
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

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FormularioFuncionario f = new FormularioFuncionario();
            ChecarLogin(f);
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            FormularioComida f = new FormularioComida();       
            ChecarLogin(f);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            limparTudo();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {         
            totalRemovido();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.lblHora.Text = DateTime.Now.ToString("yyyy-MM-dd : HH:mm:ss");
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();

                    foreach (ListViewItem item in lstComida.Items)
                    {
                        var valorString = item.SubItems[1].Text;
                        var quantidadeString = item.SubItems[2].Text;

                        if (decimal.TryParse(valorString, out decimal valor) && int.TryParse(quantidadeString, out int quantidade))
                        {
                            total = valor * quantidade;
                        }

                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.Connection = conexao;
                            cmd.CommandText = @"INSERT INTO bar (N_Aluno, Cod_Comida,Data_Compra,N_Funcionario, Valor_Gasto, Quantidade) 
                                        VALUES (@N_Aluno, @Cod_Comida, @data_compra, @N_Funcionario, @valorGasto, @quantidade)";

                            cmd.Parameters.AddWithValue("@N_Aluno", lblCodigoAluno.Text);

                            // Use o Cod_Comida associado ao item do ListView a partir da lista idComidaLista
                            int index = lstComida.Items.IndexOf(item);
                            cmd.Parameters.AddWithValue("@Cod_Comida", idComidaLista[index]);

                            cmd.Parameters.AddWithValue("@data_compra", DateTime.Now);
                            cmd.Parameters.AddWithValue("@N_Funcionario", N_Funcionario);
                            cmd.Parameters.AddWithValue("@valorGasto", total);
                            cmd.Parameters.AddWithValue("@quantidade", quantidadeString);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        List<int> idComidaLista = new List<int>();
        private void addItem()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = @"SELECT Descricao_Comida,Valor_Comida FROM infocomida WHERE Cod_Comida = @id";
                        cmd.Parameters.AddWithValue("@id", idComidaTeste[0]);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var comida = reader.GetString(0);
                                var valor = reader.GetDouble(1).ToString();
                                var quantidade = qntItem.Value.ToString();
                                string[] row = { comida, valor, quantidade };

                                lstComida.Items.Add(new ListViewItem(row));
                                // Adiciona o Cod_Comida correspondente ao item do ListView à lista
                                idComidaLista.Add(idComidaTeste[0]);

                            }
                        }
                    }
                }
                totalAdicionado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChecarLogin(Form f)
        {
            if (Globais.logado == true)
            {
                f.ShowDialog();
            }
            else MessageBox.Show("Necessário um login.");
        }
        #endregion

        #region Functions

        //Reset all items 
        private void limparTudo()
        {
            lblCodigoAluno.ResetText();
            lblNomeAluno.ResetText();
            lblSaldoAluno.ResetText();
            lstComida.Items.Clear();
            lblTotal.Text = "0,00 €";
            qntItem.Refresh();
            comboBox1.ResetText();
        }

        //Sum value insert in the lstComida and sum value in the lblTotal
        private void totalAdicionado()
        {
            decimal total = 0;

            //Expand the array based in the total item in the lstComida

            Array.Resize(ref idComidaTeste, lstComida.Items.Count);
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

            //Variable receive the total value when something is added
            totalAcumulado = total;
            lblTotal.Text = totalAcumulado.ToString();
        }

        //Remove item in the lstComida and subtract value in the lblTotal
        private void totalRemovido()
        {
            totalAcumulado = 0;

            foreach (ListViewItem item in lstComida.SelectedItems)
            {
                totalAcumulado = decimal.Parse(item.SubItems[1].Text) * int.Parse(item.SubItems[2].Text);
                lstComida.Items.Remove(item);

            }

            somarValorFaltante = Convert.ToDecimal(lblSaldoAluno.Text) + Convert.ToDecimal(totalAcumulado);
            lblSaldoAluno.Text = somarValorFaltante.ToString();

            lblTotal.Text = Convert.ToString(Convert.ToDecimal(lblTotal.Text) - totalAcumulado);
        }

        //Read the all items in the table "infocomida" and add in the combobox
        private void preencherCombo()
        {
            string sql = "SELECT * FROM infocomida";
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                   using(MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = sql;
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox1.Items.Add(reader["Descricao_Comida"]).ToString();
                                comboBox1.DisplayMember = reader["Descricao_Comida"].ToString();
                                comboBox1.ValueMember = reader["Cod_Comida"].ToString();
                                comboBox1.SelectedIndex = -1;
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

        
        private void checarSaldo_addItem()
        {
            try
            {
                //This variable holds the id when one has an item selected
                double valorComidaSelecionada = 0;

                int quantidade = Convert.ToInt32(qntItem.Value);
                double saldoAluno = Convert.ToDouble(lblSaldoAluno.Text);
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = "SELECT Valor_Comida FROM infocomida WHERE Cod_Comida = @id";

                        //Select the value when the id is equals a idComidaSelecionada
                        cmd.Parameters.AddWithValue("@id", idComidaTeste[0]);

                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Search the column in the database
                                valorComidaSelecionada = reader.GetDouble("Valor_Comida");

                                //Sum the value the food * quantity solicited
                                valorComidaSelecionada *= Convert.ToDouble(quantidade);
                                
                                if (valorComidaSelecionada <= saldoAluno)
                                {
                                    addItem();

                                    //after add a item, subtract the value in your balance in an abstract way
                                    saldoAluno -= valorComidaSelecionada;
                                    lblSaldoAluno.Text = saldoAluno.ToString();
                                }
                                else MessageBox.Show("Seu saldo é inferior ao saldo requisitado", "Saldo Insuficiente");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Keep the name food in the combo
            string nomeComida = comboBox1.SelectedItem.ToString();           
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Globais.data_source))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = "SELECT Cod_Comida FROM infocomida WHERE Descricao_Comida = @nomeComida";

                        //Remove the Cod_Comida (id) when the food name is equal to the variable
                        cmd.Parameters.AddWithValue("@nomeComida", nomeComida);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Set the id from select item in the combo box
                                idComidaTeste[0] = reader.GetInt32("Cod_Comida");
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
        #endregion

        #region Dont Used

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lstComida_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }


        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(btnEntrarSair.Text == "Entrar")
            {
                LoginFuncionario f = new LoginFuncionario(this, N_Funcionario);
                f.ShowDialog();
                btnEntrarSair.Text = "Sair";
               
            }else
            {
                btnEntrarSair.Text = "Entrar";
                pb_ledLogado.Image = Properties.Resources.led_vermelho;
                lblNome.Text = "---";
                Globais.logado = false;
                N_Funcionario = 0;
            }
        }

        private void lstComida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
