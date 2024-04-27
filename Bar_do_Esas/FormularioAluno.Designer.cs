namespace Bar_do_Esas
{
    partial class FormularioAluno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbl_Aluno = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstAluno = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 502);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 39);
            this.panel1.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(575, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(188, 32);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Excluir Aluno";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(336, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 32);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Atualizar Aluno";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(108, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Adicionar Aluno";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // lbl_Aluno
            // 
            this.lbl_Aluno.AutoSize = true;
            this.lbl_Aluno.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aluno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Aluno.Location = new System.Drawing.Point(512, 38);
            this.lbl_Aluno.Name = "lbl_Aluno";
            this.lbl_Aluno.Size = new System.Drawing.Size(191, 26);
            this.lbl_Aluno.TabIndex = 6;
            this.lbl_Aluno.Text = "Lista de Alunos";
            this.lbl_Aluno.Click += new System.EventHandler(this.lbl_Aluno_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 110);
            this.txtCodigo.MaxLength = 11;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(183, 22);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 187);
            this.txtNome.MaxLength = 140;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(183, 22);
            this.txtNome.TabIndex = 8;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(16, 343);
            this.txtSaldo.MaxLength = 4;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(135, 22);
            this.txtSaldo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome Aluno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Saldo";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 265);
            this.txtData.Mask = "0000-00-00";
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(179, 22);
            this.txtData.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(8, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data de Nascimento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lstAluno
            // 
            this.lstAluno.HideSelection = false;
            this.lstAluno.Location = new System.Drawing.Point(291, 67);
            this.lstAluno.MultiSelect = false;
            this.lstAluno.Name = "lstAluno";
            this.lstAluno.Size = new System.Drawing.Size(608, 350);
            this.lstAluno.TabIndex = 1;
            this.lstAluno.UseCompatibleStateImageBehavior = false;
            this.lstAluno.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstAluno_ItemSelectionChanged);
            this.lstAluno.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // FormularioAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbl_Aluno);
            this.Controls.Add(this.lstAluno);
            this.Controls.Add(this.panel1);
            this.Name = "FormularioAluno";
            this.Text = "FormularioAluno";
            this.Load += new System.EventHandler(this.FormularioAluno_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbl_Aluno;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstAluno;
    }
}