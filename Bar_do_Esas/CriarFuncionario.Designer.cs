namespace Bar_do_Esas
{
    partial class CriarFuncionario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuna = new Guna.UI2.WinForms.Guna2Button();
            this.checkSenha = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtGunaSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGunaCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGunaNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código Funcionário";
            // 
            // btnGuna
            // 
            this.btnGuna.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuna.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuna.ForeColor = System.Drawing.Color.White;
            this.btnGuna.Location = new System.Drawing.Point(50, 215);
            this.btnGuna.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuna.Name = "btnGuna";
            this.btnGuna.Size = new System.Drawing.Size(187, 37);
            this.btnGuna.TabIndex = 16;
            this.btnGuna.Text = "Criar";
            this.btnGuna.Click += new System.EventHandler(this.btnGuna_Click);
            // 
            // checkSenha
            // 
            this.checkSenha.AutoSize = true;
            this.checkSenha.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkSenha.CheckedState.BorderRadius = 0;
            this.checkSenha.CheckedState.BorderThickness = 0;
            this.checkSenha.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.checkSenha.Location = new System.Drawing.Point(50, 194);
            this.checkSenha.Margin = new System.Windows.Forms.Padding(2);
            this.checkSenha.Name = "checkSenha";
            this.checkSenha.Size = new System.Drawing.Size(76, 17);
            this.checkSenha.TabIndex = 15;
            this.checkSenha.Text = "Ver Senha";
            this.checkSenha.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkSenha.UncheckedState.BorderRadius = 0;
            this.checkSenha.UncheckedState.BorderThickness = 0;
            this.checkSenha.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkSenha.CheckedChanged += new System.EventHandler(this.checkSenha_CheckedChanged);
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
            this.txtGunaSenha.Location = new System.Drawing.Point(50, 156);
            this.txtGunaSenha.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtGunaSenha.Name = "txtGunaSenha";
            this.txtGunaSenha.PasswordChar = '*';
            this.txtGunaSenha.PlaceholderText = "";
            this.txtGunaSenha.SelectedText = "";
            this.txtGunaSenha.Size = new System.Drawing.Size(187, 28);
            this.txtGunaSenha.TabIndex = 14;
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
            this.txtGunaCodigo.Location = new System.Drawing.Point(50, 45);
            this.txtGunaCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtGunaCodigo.Name = "txtGunaCodigo";
            this.txtGunaCodigo.PasswordChar = '\0';
            this.txtGunaCodigo.PlaceholderText = "";
            this.txtGunaCodigo.SelectedText = "";
            this.txtGunaCodigo.Size = new System.Drawing.Size(187, 33);
            this.txtGunaCodigo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nome";
            // 
            // txtGunaNome
            // 
            this.txtGunaNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGunaNome.DefaultText = "";
            this.txtGunaNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGunaNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGunaNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGunaNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGunaNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGunaNome.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGunaNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGunaNome.Location = new System.Drawing.Point(50, 103);
            this.txtGunaNome.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtGunaNome.Name = "txtGunaNome";
            this.txtGunaNome.PasswordChar = '\0';
            this.txtGunaNome.PlaceholderText = "";
            this.txtGunaNome.SelectedText = "";
            this.txtGunaNome.Size = new System.Drawing.Size(187, 28);
            this.txtGunaNome.TabIndex = 13;
            // 
            // CriarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 287);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGunaNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuna);
            this.Controls.Add(this.checkSenha);
            this.Controls.Add(this.txtGunaSenha);
            this.Controls.Add(this.txtGunaCodigo);
            this.Name = "CriarFuncionario";
            this.Text = "CriarFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnGuna;
        private Guna.UI2.WinForms.Guna2CheckBox checkSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtGunaSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtGunaCodigo;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtGunaNome;
    }
}