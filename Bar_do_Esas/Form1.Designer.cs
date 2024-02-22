namespace Bar_do_Esas
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_ledLogado = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lstComida = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_ledLogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 647);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 40);
            this.panel1.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(46, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Funcionário:";
            // 
            // pb_ledLogado
            // 
            this.pb_ledLogado.Image = global::Bar_do_Esas.Properties.Resources.led_vermelho;
            this.pb_ledLogado.Location = new System.Drawing.Point(0, 0);
            this.pb_ledLogado.Name = "pb_ledLogado";
            this.pb_ledLogado.Size = new System.Drawing.Size(40, 40);
            this.pb_ledLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ledLogado.TabIndex = 1;
            this.pb_ledLogado.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnFuncionario);
            this.panel2.Controls.Add(this.btnComida);
            this.panel2.Controls.Add(this.btnAluno);
            this.panel2.Controls.Add(this.lbl_Aluno);
            this.panel2.Controls.Add(this.lbl_Comida);
            this.panel2.Controls.Add(this.lbl_Funcionario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 647);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Inserir Código";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Location = new System.Drawing.Point(12, 520);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(188, 32);
            this.btnFuncionario.TabIndex = 8;
            this.btnFuncionario.Text = "Checar Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnComida
            // 
            this.btnComida.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComida.Location = new System.Drawing.Point(22, 299);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(165, 32);
            this.btnComida.TabIndex = 7;
            this.btnComida.Text = "Checar Comida";
            this.btnComida.UseVisualStyleBackColor = true;
            // 
            // btnAluno
            // 
            this.btnAluno.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.Location = new System.Drawing.Point(22, 142);
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
            this.lbl_Comida.Location = new System.Drawing.Point(50, 259);
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
            this.lbl_Funcionario.Location = new System.Drawing.Point(31, 491);
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
            this.lblAluno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAluno.Location = new System.Drawing.Point(229, 62);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(138, 23);
            this.lblAluno.TabIndex = 6;
            this.lblAluno.Text = "Nome Aluno:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodigo.Location = new System.Drawing.Point(229, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(147, 23);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código Aluno:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSaldo.Location = new System.Drawing.Point(229, 104);
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(910, 300);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(147, 22);
            this.numericUpDown1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(722, 298);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(958, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 23);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.lblItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItem.Location = new System.Drawing.Point(774, 273);
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
            this.label3.Location = new System.Drawing.Point(932, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantidade";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(722, 590);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 32);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemover.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(910, 590);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(165, 32);
            this.btnRemover.TabIndex = 17;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // lstComida
            // 
            this.lstComida.HideSelection = false;
            this.lstComida.Location = new System.Drawing.Point(233, 300);
            this.lstComida.Name = "lstComida";
            this.lstComida.Size = new System.Drawing.Size(415, 323);
            this.lstComida.TabIndex = 18;
            this.lstComida.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 687);
            this.Controls.Add(this.lstComida);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bar do Esas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListView lstComida;
        private System.Windows.Forms.Button button1;
    }
}

