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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.TXT_Senha = new System.Windows.Forms.TextBox();
            this.BTN_Entrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Usuario.Location = new System.Drawing.Point(77, 260);
            this.TXT_Usuario.Multiline = true;
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(245, 27);
            this.TXT_Usuario.TabIndex = 1;
            this.TXT_Usuario.Text = "Usúario";
            // 
            // TXT_Senha
            // 
            this.TXT_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Senha.Location = new System.Drawing.Point(77, 293);
            this.TXT_Senha.Multiline = true;
            this.TXT_Senha.Name = "TXT_Senha";
            this.TXT_Senha.PasswordChar = '*';
            this.TXT_Senha.Size = new System.Drawing.Size(245, 27);
            this.TXT_Senha.TabIndex = 2;
            this.TXT_Senha.Text = "Senha";
            // 
            // BTN_Entrar
            // 
            this.BTN_Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Entrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.BTN_Entrar.Location = new System.Drawing.Point(171, 346);
            this.BTN_Entrar.Name = "BTN_Entrar";
            this.BTN_Entrar.Size = new System.Drawing.Size(106, 31);
            this.BTN_Entrar.TabIndex = 3;
            this.BTN_Entrar.Text = "Entrar";
            this.BTN_Entrar.UseVisualStyleBackColor = true;
            this.BTN_Entrar.Click += new System.EventHandler(this.BTN_Entrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(101, 335);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 428);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BTN_Entrar);
            this.Controls.Add(this.TXT_Senha);
            this.Controls.Add(this.TXT_Usuario);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.TextBox TXT_Senha;
        private System.Windows.Forms.Button BTN_Entrar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

