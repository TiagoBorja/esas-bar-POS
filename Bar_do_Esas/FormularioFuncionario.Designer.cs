namespace Bar_do_Esas
{
    partial class FormularioFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbl_Aluno = new System.Windows.Forms.Label();
            this.lstFuncionario = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(19, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Data de entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome Funcionário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Código Funcionário";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(19, 154);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(138, 20);
            this.txtNome.TabIndex = 19;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(22, 80);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(138, 20);
            this.txtCodigo.TabIndex = 18;
            // 
            // lbl_Aluno
            // 
            this.lbl_Aluno.AutoSize = true;
            this.lbl_Aluno.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aluno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Aluno.Location = new System.Drawing.Point(342, 15);
            this.lbl_Aluno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Aluno.Name = "lbl_Aluno";
            this.lbl_Aluno.Size = new System.Drawing.Size(218, 22);
            this.lbl_Aluno.TabIndex = 17;
            this.lbl_Aluno.Text = "Lista de Funcionários";
            // 
            // lstFuncionario
            // 
            this.lstFuncionario.HideSelection = false;
            this.lstFuncionario.Location = new System.Drawing.Point(218, 39);
            this.lstFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.lstFuncionario.MultiSelect = false;
            this.lstFuncionario.Name = "lstFuncionario";
            this.lstFuncionario.Size = new System.Drawing.Size(457, 285);
            this.lstFuncionario.TabIndex = 16;
            this.lstFuncionario.UseCompatibleStateImageBehavior = false;
            this.lstFuncionario.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstFuncionario_ItemSelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 32);
            this.panel1.TabIndex = 15;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(482, 4);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(184, 26);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Excluir Funcionário";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(260, 4);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 26);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Atualizar Funcionário";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(22, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 26);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Adicionar Funcionário";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(19, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Data de saída";
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(22, 304);
            this.txtSaida.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaida.Mask = "0000/00/00 90:00";
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ReadOnly = true;
            this.txtSaida.Size = new System.Drawing.Size(135, 20);
            this.txtSaida.TabIndex = 27;
            this.txtSaida.ValidatingType = typeof(System.DateTime);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(22, 225);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.txtEntrada.Mask = "0000/00/00 90:00";
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ReadOnly = true;
            this.txtEntrada.Size = new System.Drawing.Size(135, 20);
            this.txtEntrada.TabIndex = 28;
            this.txtEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // FormularioFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 440);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbl_Aluno);
            this.Controls.Add(this.lstFuncionario);
            this.Controls.Add(this.panel1);
            this.Name = "FormularioFuncionario";
            this.Text = "FormularioFuncionario";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbl_Aluno;
        private System.Windows.Forms.ListView lstFuncionario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtSaida;
        private System.Windows.Forms.MaskedTextBox txtEntrada;
    }
}