namespace Bar_do_Esas
{
    partial class LoginFuncionario
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGunaCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGunaSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkSenha = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnGuna = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(84, 86);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(180, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(84, 150);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(180, 22);
            this.txtSenha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(98, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código Funcionário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(147, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // btnLogar
            // 
            this.btnLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogar.Location = new System.Drawing.Point(133, 212);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(91, 37);
            this.btnLogar.TabIndex = 4;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(133, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtGunaCodigo
            // 
            this.txtGunaCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGunaCodigo.DefaultText = "";
            this.txtGunaCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGunaCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGunaCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGunaCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGunaCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGunaCodigo.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.txtGunaCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGunaCodigo.Location = new System.Drawing.Point(478, 86);
            this.txtGunaCodigo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtGunaCodigo.Name = "txtGunaCodigo";
            this.txtGunaCodigo.PasswordChar = '\0';
            this.txtGunaCodigo.PlaceholderText = "";
            this.txtGunaCodigo.SelectedText = "";
            this.txtGunaCodigo.Size = new System.Drawing.Size(249, 41);
            this.txtGunaCodigo.TabIndex = 6;
            // 
            // txtGunaSenha
            // 
            this.txtGunaSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGunaSenha.DefaultText = "";
            this.txtGunaSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGunaSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGunaSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGunaSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGunaSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGunaSenha.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGunaSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGunaSenha.Location = new System.Drawing.Point(478, 137);
            this.txtGunaSenha.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtGunaSenha.Name = "txtGunaSenha";
            this.txtGunaSenha.PasswordChar = '*';
            this.txtGunaSenha.PlaceholderText = "";
            this.txtGunaSenha.SelectedText = "";
            this.txtGunaSenha.Size = new System.Drawing.Size(249, 35);
            this.txtGunaSenha.TabIndex = 7;
            // 
            // checkSenha
            // 
            this.checkSenha.AutoSize = true;
            this.checkSenha.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkSenha.CheckedState.BorderRadius = 0;
            this.checkSenha.CheckedState.BorderThickness = 0;
            this.checkSenha.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.checkSenha.Location = new System.Drawing.Point(478, 200);
            this.checkSenha.Name = "checkSenha";
            this.checkSenha.Size = new System.Drawing.Size(92, 20);
            this.checkSenha.TabIndex = 8;
            this.checkSenha.Text = "Ver Senha";
            this.checkSenha.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkSenha.UncheckedState.BorderRadius = 0;
            this.checkSenha.UncheckedState.BorderThickness = 0;
            this.checkSenha.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkSenha.CheckedChanged += new System.EventHandler(this.checkSenha_CheckedChanged);
            // 
            // btnGuna
            // 
            this.btnGuna.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuna.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuna.ForeColor = System.Drawing.Color.White;
            this.btnGuna.Location = new System.Drawing.Point(478, 226);
            this.btnGuna.Name = "btnGuna";
            this.btnGuna.Size = new System.Drawing.Size(229, 45);
            this.btnGuna.TabIndex = 9;
            this.btnGuna.Text = "Logar";
            this.btnGuna.Click += new System.EventHandler(this.btnGuna_Click);
            // 
            // LoginFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 529);
            this.Controls.Add(this.btnGuna);
            this.Controls.Add(this.checkSenha);
            this.Controls.Add(this.txtGunaSenha);
            this.Controls.Add(this.txtGunaCodigo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtCodigo);
            this.Name = "LoginFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2TextBox txtGunaCodigo;
        private Guna.UI2.WinForms.Guna2TextBox txtGunaSenha;
        private Guna.UI2.WinForms.Guna2CheckBox checkSenha;
        private Guna.UI2.WinForms.Guna2Button btnGuna;
    }
}