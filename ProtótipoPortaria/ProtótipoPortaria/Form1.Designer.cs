namespace ProtótipoPortaria
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.TXT_Senha = new System.Windows.Forms.TextBox();
            this.BTN_Entrar = new System.Windows.Forms.Button();
            this.BTN_Sairlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Usuario.ForeColor = System.Drawing.Color.Silver;
            this.TXT_Usuario.Location = new System.Drawing.Point(37, 258);
            this.TXT_Usuario.Multiline = true;
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(179, 27);
            this.TXT_Usuario.TabIndex = 1;
            this.TXT_Usuario.Text = "Usuário";
            this.TXT_Usuario.Enter += new System.EventHandler(this.TXT_Usuario_Enter);
            this.TXT_Usuario.Leave += new System.EventHandler(this.TXT_Usuario_Leave);
            // 
            // TXT_Senha
            // 
            this.TXT_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Senha.ForeColor = System.Drawing.Color.Silver;
            this.TXT_Senha.Location = new System.Drawing.Point(37, 291);
            this.TXT_Senha.Multiline = true;
            this.TXT_Senha.Name = "TXT_Senha";
            this.TXT_Senha.Size = new System.Drawing.Size(179, 27);
            this.TXT_Senha.TabIndex = 2;
            this.TXT_Senha.Text = "Senha";
            this.TXT_Senha.TextChanged += new System.EventHandler(this.TXT_Senha_TextChanged);
            this.TXT_Senha.Enter += new System.EventHandler(this.TXT_Senha_Enter);
            this.TXT_Senha.Leave += new System.EventHandler(this.TXT_Senha_Leave);
            // 
            // BTN_Entrar
            // 
            this.BTN_Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Entrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Entrar.Location = new System.Drawing.Point(37, 322);
            this.BTN_Entrar.Name = "BTN_Entrar";
            this.BTN_Entrar.Size = new System.Drawing.Size(75, 27);
            this.BTN_Entrar.TabIndex = 3;
            this.BTN_Entrar.Text = "Entrar";
            this.BTN_Entrar.UseVisualStyleBackColor = true;
            this.BTN_Entrar.Click += new System.EventHandler(this.BTN_Entrar_Click);
            // 
            // BTN_Sairlogin
            // 
            this.BTN_Sairlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Sairlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Sairlogin.Location = new System.Drawing.Point(139, 322);
            this.BTN_Sairlogin.Name = "BTN_Sairlogin";
            this.BTN_Sairlogin.Size = new System.Drawing.Size(75, 27);
            this.BTN_Sairlogin.TabIndex = 4;
            this.BTN_Sairlogin.Text = "Sair";
            this.BTN_Sairlogin.UseVisualStyleBackColor = true;
            this.BTN_Sairlogin.Click += new System.EventHandler(this.BTN_Sairlogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(250, 395);
            this.Controls.Add(this.BTN_Sairlogin);
            this.Controls.Add(this.BTN_Entrar);
            this.Controls.Add(this.TXT_Senha);
            this.Controls.Add(this.TXT_Usuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condomínio Transparente :: Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.Button BTN_Entrar;
        private System.Windows.Forms.TextBox TXT_Senha;
        private System.Windows.Forms.Button BTN_Sairlogin;
    }
}

