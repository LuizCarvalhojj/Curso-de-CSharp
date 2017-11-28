namespace ProtótipoPortaria
{
    partial class frmCadastroVisitantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroVisitantes));
            this.GB_CasdastroVisitantes = new System.Windows.Forms.GroupBox();
            this.CMB_UnidadeVisitantes = new System.Windows.Forms.ComboBox();
            this.LBL_UnidadeVisitantes = new System.Windows.Forms.Label();
            this.DTP_DataNascVisit = new System.Windows.Forms.DateTimePicker();
            this.LBL_DataNascVisit = new System.Windows.Forms.Label();
            this.TXT_CPFVisitantes = new System.Windows.Forms.TextBox();
            this.LBL_CPFVisitantes = new System.Windows.Forms.Label();
            this.LBL_NomeVisitantes = new System.Windows.Forms.Label();
            this.TXT_NomeVisitantes = new System.Windows.Forms.TextBox();
            this.GB_BotoesVisit = new System.Windows.Forms.GroupBox();
            this.BTN_CancelVisitantes = new System.Windows.Forms.Button();
            this.BTN_SalvarVisitantes = new System.Windows.Forms.Button();
            this.LBL_CodVisitantes = new System.Windows.Forms.Label();
            this.TXT_CodVisitantes = new System.Windows.Forms.TextBox();
            this.GB_CasdastroVisitantes.SuspendLayout();
            this.GB_BotoesVisit.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_CasdastroVisitantes
            // 
            this.GB_CasdastroVisitantes.Controls.Add(this.LBL_CodVisitantes);
            this.GB_CasdastroVisitantes.Controls.Add(this.TXT_CodVisitantes);
            this.GB_CasdastroVisitantes.Controls.Add(this.CMB_UnidadeVisitantes);
            this.GB_CasdastroVisitantes.Controls.Add(this.LBL_UnidadeVisitantes);
            this.GB_CasdastroVisitantes.Controls.Add(this.DTP_DataNascVisit);
            this.GB_CasdastroVisitantes.Controls.Add(this.LBL_DataNascVisit);
            this.GB_CasdastroVisitantes.Controls.Add(this.TXT_CPFVisitantes);
            this.GB_CasdastroVisitantes.Controls.Add(this.LBL_CPFVisitantes);
            this.GB_CasdastroVisitantes.Controls.Add(this.LBL_NomeVisitantes);
            this.GB_CasdastroVisitantes.Controls.Add(this.TXT_NomeVisitantes);
            this.GB_CasdastroVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_CasdastroVisitantes.Location = new System.Drawing.Point(12, 12);
            this.GB_CasdastroVisitantes.Name = "GB_CasdastroVisitantes";
            this.GB_CasdastroVisitantes.Size = new System.Drawing.Size(437, 291);
            this.GB_CasdastroVisitantes.TabIndex = 1;
            this.GB_CasdastroVisitantes.TabStop = false;
            this.GB_CasdastroVisitantes.Text = "Dados do visitante";
            // 
            // CMB_UnidadeVisitantes
            // 
            this.CMB_UnidadeVisitantes.FormattingEnabled = true;
            this.CMB_UnidadeVisitantes.Location = new System.Drawing.Point(9, 229);
            this.CMB_UnidadeVisitantes.Name = "CMB_UnidadeVisitantes";
            this.CMB_UnidadeVisitantes.Size = new System.Drawing.Size(140, 28);
            this.CMB_UnidadeVisitantes.TabIndex = 16;
            // 
            // LBL_UnidadeVisitantes
            // 
            this.LBL_UnidadeVisitantes.AutoSize = true;
            this.LBL_UnidadeVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UnidadeVisitantes.Location = new System.Drawing.Point(6, 208);
            this.LBL_UnidadeVisitantes.Name = "LBL_UnidadeVisitantes";
            this.LBL_UnidadeVisitantes.Size = new System.Drawing.Size(62, 18);
            this.LBL_UnidadeVisitantes.TabIndex = 8;
            this.LBL_UnidadeVisitantes.Text = "Unidade";
            // 
            // DTP_DataNascVisit
            // 
            this.DTP_DataNascVisit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_DataNascVisit.Location = new System.Drawing.Point(9, 108);
            this.DTP_DataNascVisit.Name = "DTP_DataNascVisit";
            this.DTP_DataNascVisit.Size = new System.Drawing.Size(334, 27);
            this.DTP_DataNascVisit.TabIndex = 7;
            // 
            // LBL_DataNascVisit
            // 
            this.LBL_DataNascVisit.AutoSize = true;
            this.LBL_DataNascVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DataNascVisit.Location = new System.Drawing.Point(6, 87);
            this.LBL_DataNascVisit.Name = "LBL_DataNascVisit";
            this.LBL_DataNascVisit.Size = new System.Drawing.Size(140, 18);
            this.LBL_DataNascVisit.TabIndex = 6;
            this.LBL_DataNascVisit.Text = "Data de nascimento";
            // 
            // TXT_CPFVisitantes
            // 
            this.TXT_CPFVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CPFVisitantes.Location = new System.Drawing.Point(9, 169);
            this.TXT_CPFVisitantes.Multiline = true;
            this.TXT_CPFVisitantes.Name = "TXT_CPFVisitantes";
            this.TXT_CPFVisitantes.Size = new System.Drawing.Size(174, 27);
            this.TXT_CPFVisitantes.TabIndex = 5;
            // 
            // LBL_CPFVisitantes
            // 
            this.LBL_CPFVisitantes.AutoSize = true;
            this.LBL_CPFVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CPFVisitantes.Location = new System.Drawing.Point(6, 148);
            this.LBL_CPFVisitantes.Name = "LBL_CPFVisitantes";
            this.LBL_CPFVisitantes.Size = new System.Drawing.Size(38, 18);
            this.LBL_CPFVisitantes.TabIndex = 4;
            this.LBL_CPFVisitantes.Text = "CPF";
            // 
            // LBL_NomeVisitantes
            // 
            this.LBL_NomeVisitantes.AutoSize = true;
            this.LBL_NomeVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NomeVisitantes.Location = new System.Drawing.Point(6, 30);
            this.LBL_NomeVisitantes.Name = "LBL_NomeVisitantes";
            this.LBL_NomeVisitantes.Size = new System.Drawing.Size(115, 18);
            this.LBL_NomeVisitantes.TabIndex = 1;
            this.LBL_NomeVisitantes.Text = "Nome completo";
            // 
            // TXT_NomeVisitantes
            // 
            this.TXT_NomeVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NomeVisitantes.Location = new System.Drawing.Point(9, 51);
            this.TXT_NomeVisitantes.Name = "TXT_NomeVisitantes";
            this.TXT_NomeVisitantes.Size = new System.Drawing.Size(337, 24);
            this.TXT_NomeVisitantes.TabIndex = 0;
            // 
            // GB_BotoesVisit
            // 
            this.GB_BotoesVisit.Controls.Add(this.BTN_CancelVisitantes);
            this.GB_BotoesVisit.Controls.Add(this.BTN_SalvarVisitantes);
            this.GB_BotoesVisit.Location = new System.Drawing.Point(226, 309);
            this.GB_BotoesVisit.Name = "GB_BotoesVisit";
            this.GB_BotoesVisit.Size = new System.Drawing.Size(223, 74);
            this.GB_BotoesVisit.TabIndex = 3;
            this.GB_BotoesVisit.TabStop = false;
            // 
            // BTN_CancelVisitantes
            // 
            this.BTN_CancelVisitantes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_CancelVisitantes.Location = new System.Drawing.Point(122, 21);
            this.BTN_CancelVisitantes.Name = "BTN_CancelVisitantes";
            this.BTN_CancelVisitantes.Size = new System.Drawing.Size(82, 36);
            this.BTN_CancelVisitantes.TabIndex = 2;
            this.BTN_CancelVisitantes.Text = "Cancelar";
            this.BTN_CancelVisitantes.UseVisualStyleBackColor = true;
            // 
            // BTN_SalvarVisitantes
            // 
            this.BTN_SalvarVisitantes.Location = new System.Drawing.Point(18, 21);
            this.BTN_SalvarVisitantes.Name = "BTN_SalvarVisitantes";
            this.BTN_SalvarVisitantes.Size = new System.Drawing.Size(98, 36);
            this.BTN_SalvarVisitantes.TabIndex = 1;
            this.BTN_SalvarVisitantes.Text = "Salvar";
            this.BTN_SalvarVisitantes.UseVisualStyleBackColor = true;
            // 
            // LBL_CodVisitantes
            // 
            this.LBL_CodVisitantes.AutoSize = true;
            this.LBL_CodVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CodVisitantes.Location = new System.Drawing.Point(365, 30);
            this.LBL_CodVisitantes.Name = "LBL_CodVisitantes";
            this.LBL_CodVisitantes.Size = new System.Drawing.Size(56, 18);
            this.LBL_CodVisitantes.TabIndex = 25;
            this.LBL_CodVisitantes.Text = "Código";
            // 
            // TXT_CodVisitantes
            // 
            this.TXT_CodVisitantes.Enabled = false;
            this.TXT_CodVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CodVisitantes.Location = new System.Drawing.Point(368, 51);
            this.TXT_CodVisitantes.Name = "TXT_CodVisitantes";
            this.TXT_CodVisitantes.Size = new System.Drawing.Size(53, 24);
            this.TXT_CodVisitantes.TabIndex = 24;
            // 
            // frmCadastroVisitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_CancelVisitantes;
            this.ClientSize = new System.Drawing.Size(465, 393);
            this.Controls.Add(this.GB_BotoesVisit);
            this.Controls.Add(this.GB_CasdastroVisitantes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroVisitantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condomínio Transparente :: Portaria - Cadastro de visitantes";
            this.GB_CasdastroVisitantes.ResumeLayout(false);
            this.GB_CasdastroVisitantes.PerformLayout();
            this.GB_BotoesVisit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_CasdastroVisitantes;
        private System.Windows.Forms.ComboBox CMB_UnidadeVisitantes;
        private System.Windows.Forms.Label LBL_UnidadeVisitantes;
        private System.Windows.Forms.DateTimePicker DTP_DataNascVisit;
        private System.Windows.Forms.Label LBL_DataNascVisit;
        private System.Windows.Forms.TextBox TXT_CPFVisitantes;
        private System.Windows.Forms.Label LBL_CPFVisitantes;
        private System.Windows.Forms.Label LBL_NomeVisitantes;
        private System.Windows.Forms.TextBox TXT_NomeVisitantes;
        private System.Windows.Forms.GroupBox GB_BotoesVisit;
        private System.Windows.Forms.Button BTN_CancelVisitantes;
        private System.Windows.Forms.Button BTN_SalvarVisitantes;
        private System.Windows.Forms.Label LBL_CodVisitantes;
        private System.Windows.Forms.TextBox TXT_CodVisitantes;
    }
}