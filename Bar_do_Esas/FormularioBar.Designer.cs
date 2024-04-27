namespace Bar_do_Esas
{
    partial class FormularioBar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_ledLogado = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEntrarSair = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnComida = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.lbl_Aluno = new System.Windows.Forms.Label();
            this.lbl_Comida = new System.Windows.Forms.Label();
            this.lbl_Funcionario = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qntItem = new System.Windows.Forms.NumericUpDown();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lstBar = new System.Windows.Forms.ListView();
            this.lblCodigoAluno = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.lblSaldoAluno = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnConcluir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qntItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_ledLogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 648);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 39);
            this.panel1.TabIndex = 0;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(888, 11);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(156, 20);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "0000/00/00 00:00";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(167, 11);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(24, 20);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "---";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Funcionário:";
            // 
            // pb_ledLogado
            // 
            this.pb_ledLogado.Image = global::Bar_do_Esas.Properties.Resources.led_vermelho;
            this.pb_ledLogado.Location = new System.Drawing.Point(0, 0);
            this.pb_ledLogado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_ledLogado.Name = "pb_ledLogado";
            this.pb_ledLogado.Size = new System.Drawing.Size(40, 39);
            this.pb_ledLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ledLogado.TabIndex = 1;
            this.pb_ledLogado.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnEntrarSair);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnFuncionario);
            this.panel2.Controls.Add(this.btnComida);
            this.panel2.Controls.Add(this.btnAluno);
            this.panel2.Controls.Add(this.lbl_Aluno);
            this.panel2.Controls.Add(this.lbl_Comida);
            this.panel2.Controls.Add(this.lbl_Funcionario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 648);
            this.panel2.TabIndex = 1;
            // 
            // btnEntrarSair
            // 
            this.btnEntrarSair.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.btnEntrarSair.Location = new System.Drawing.Point(20, 576);
            this.btnEntrarSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntrarSair.Name = "btnEntrarSair";
            this.btnEntrarSair.Size = new System.Drawing.Size(165, 32);
            this.btnEntrarSair.TabIndex = 11;
            this.btnEntrarSair.Text = "Entrar";
            this.btnEntrarSair.UseVisualStyleBackColor = true;
            this.btnEntrarSair.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(21, 140);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 32);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Inserir Código";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Location = new System.Drawing.Point(20, 527);
            this.btnFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(165, 32);
            this.btnFuncionario.TabIndex = 8;
            this.btnFuncionario.Text = "Checar Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnComida
            // 
            this.btnComida.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComida.Location = new System.Drawing.Point(21, 299);
            this.btnComida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(165, 32);
            this.btnComida.TabIndex = 7;
            this.btnComida.Text = "Checar Comida";
            this.btnComida.UseVisualStyleBackColor = true;
            this.btnComida.Click += new System.EventHandler(this.btnComida_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.Location = new System.Drawing.Point(21, 177);
            this.btnAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(165, 32);
            this.btnAluno.TabIndex = 6;
            this.btnAluno.Text = "Checar Alunos";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // lbl_Aluno
            // 
            this.lbl_Aluno.AutoSize = true;
            this.lbl_Aluno.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aluno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Aluno.Location = new System.Drawing.Point(59, 62);
            this.lbl_Aluno.Name = "lbl_Aluno";
            this.lbl_Aluno.Size = new System.Drawing.Size(82, 26);
            this.lbl_Aluno.TabIndex = 5;
            this.lbl_Aluno.Text = "Aluno";
            // 
            // lbl_Comida
            // 
            this.lbl_Comida.AutoSize = true;
            this.lbl_Comida.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Comida.Location = new System.Drawing.Point(51, 258);
            this.lbl_Comida.Name = "lbl_Comida";
            this.lbl_Comida.Size = new System.Drawing.Size(101, 26);
            this.lbl_Comida.TabIndex = 4;
            this.lbl_Comida.Text = "Comida";
            // 
            // lbl_Funcionario
            // 
            this.lbl_Funcionario.AutoSize = true;
            this.lbl_Funcionario.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Funcionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Funcionario.Location = new System.Drawing.Point(17, 497);
            this.lbl_Funcionario.Name = "lbl_Funcionario";
            this.lbl_Funcionario.Size = new System.Drawing.Size(150, 26);
            this.lbl_Funcionario.TabIndex = 3;
            this.lbl_Funcionario.Text = "Funcionário";
            this.lbl_Funcionario.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.ForeColor = System.Drawing.Color.Black;
            this.lblAluno.Location = new System.Drawing.Point(7, 86);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(138, 23);
            this.lblAluno.TabIndex = 6;
            this.lblAluno.Text = "Nome Aluno:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(7, 43);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(147, 23);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código Aluno:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Black;
            this.lblSaldo.Location = new System.Drawing.Point(7, 128);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(68, 23);
            this.lblSaldo.TabIndex = 8;
            this.lblSaldo.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(345, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Itens Selecionados";
            // 
            // qntItem
            // 
            this.qntItem.Location = new System.Drawing.Point(928, 298);
            this.qntItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qntItem.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.qntItem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qntItem.Name = "qntItem";
            this.qntItem.ReadOnly = true;
            this.qntItem.Size = new System.Drawing.Size(147, 22);
            this.qntItem.TabIndex = 11;
            this.qntItem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(695, 297);
            this.cbItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(212, 24);
            this.cbItem.TabIndex = 12;
            this.cbItem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(999, 11);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(69, 23);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "0,00 €";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.lblItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItem.Location = new System.Drawing.Point(771, 272);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(49, 20);
            this.lblItem.TabIndex = 14;
            this.lblItem.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(944, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantidade";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(695, 512);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 32);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemover.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(909, 512);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(165, 32);
            this.btnRemover.TabIndex = 17;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lstBar
            // 
            this.lstBar.HideSelection = false;
            this.lstBar.Location = new System.Drawing.Point(233, 300);
            this.lstBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBar.Name = "lstBar";
            this.lstBar.Size = new System.Drawing.Size(415, 323);
            this.lstBar.TabIndex = 18;
            this.lstBar.UseCompatibleStateImageBehavior = false;
            this.lstBar.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstComida_ItemSelectionChanged);
            this.lstBar.SelectedIndexChanged += new System.EventHandler(this.lstComida_SelectedIndexChanged);
            // 
            // lblCodigoAluno
            // 
            this.lblCodigoAluno.AutoSize = true;
            this.lblCodigoAluno.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAluno.ForeColor = System.Drawing.Color.White;
            this.lblCodigoAluno.Location = new System.Drawing.Point(159, 46);
            this.lblCodigoAluno.Name = "lblCodigoAluno";
            this.lblCodigoAluno.Size = new System.Drawing.Size(0, 20);
            this.lblCodigoAluno.TabIndex = 19;
            this.lblCodigoAluno.Visible = false;
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.ForeColor = System.Drawing.Color.White;
            this.lblNomeAluno.Location = new System.Drawing.Point(147, 89);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(0, 20);
            this.lblNomeAluno.TabIndex = 20;
            this.lblNomeAluno.Visible = false;
            // 
            // lblSaldoAluno
            // 
            this.lblSaldoAluno.AutoSize = true;
            this.lblSaldoAluno.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoAluno.ForeColor = System.Drawing.Color.White;
            this.lblSaldoAluno.Location = new System.Drawing.Point(76, 132);
            this.lblSaldoAluno.Name = "lblSaldoAluno";
            this.lblSaldoAluno.Size = new System.Drawing.Size(0, 20);
            this.lblSaldoAluno.TabIndex = 21;
            this.lblSaldoAluno.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Salmon;
            this.groupBox1.Controls.Add(this.lblAluno);
            this.groupBox1.Controls.Add(this.lblSaldoAluno);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblNomeAluno);
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Controls.Add(this.lblCodigoAluno);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(233, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(416, 176);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Aluno";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.Color.Green;
            this.btnConcluir.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(695, 570);
            this.btnConcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(380, 32);
            this.btnConcluir.TabIndex = 23;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.label4.Location = new System.Drawing.Point(935, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Total:";
            // 
            // FormularioBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 687);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstBar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.qntItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularioBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bar do Esas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qntItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pb_ledLogado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Funcionario;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Label lbl_Aluno;
        private System.Windows.Forms.Label lbl_Comida;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown qntItem;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListView lstBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Label lblCodigoAluno;
        public System.Windows.Forms.Label lblNomeAluno;
        public System.Windows.Forms.Label lblSaldoAluno;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnEntrarSair;
    }
}

