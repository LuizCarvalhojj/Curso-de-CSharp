namespace ProtótipoPortaria
{
    partial class frmConsultarArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarArea));
            this.GB_ConsultaArea = new System.Windows.Forms.GroupBox();
            this.DTP_HoraConsulta = new System.Windows.Forms.DateTimePicker();
            this.DTP_DataConsulta = new System.Windows.Forms.DateTimePicker();
            this.LBL_DataConsulta = new System.Windows.Forms.Label();
            this.TXT_CodAreaConsulta = new System.Windows.Forms.TextBox();
            this.LBL_HoraConsulta = new System.Windows.Forms.Label();
            this.LBL_CodAreaConsulta = new System.Windows.Forms.Label();
            this.GB_BotoesConsultar = new System.Windows.Forms.GroupBox();
            this.BTN_CancelConsultarArea = new System.Windows.Forms.Button();
            this.BTN_ConsultarArea = new System.Windows.Forms.Button();
            this.GB_ConsultaArea.SuspendLayout();
            this.GB_BotoesConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_ConsultaArea
            // 
            this.GB_ConsultaArea.Controls.Add(this.DTP_HoraConsulta);
            this.GB_ConsultaArea.Controls.Add(this.DTP_DataConsulta);
            this.GB_ConsultaArea.Controls.Add(this.LBL_DataConsulta);
            this.GB_ConsultaArea.Controls.Add(this.TXT_CodAreaConsulta);
            this.GB_ConsultaArea.Controls.Add(this.LBL_HoraConsulta);
            this.GB_ConsultaArea.Controls.Add(this.LBL_CodAreaConsulta);
            this.GB_ConsultaArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_ConsultaArea.Location = new System.Drawing.Point(12, 12);
            this.GB_ConsultaArea.Name = "GB_ConsultaArea";
            this.GB_ConsultaArea.Size = new System.Drawing.Size(447, 224);
            this.GB_ConsultaArea.TabIndex = 4;
            this.GB_ConsultaArea.TabStop = false;
            this.GB_ConsultaArea.Text = "Dados para consultar disponibilidade da área comum";
            // 
            // DTP_HoraConsulta
            // 
            this.DTP_HoraConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_HoraConsulta.Location = new System.Drawing.Point(9, 165);
            this.DTP_HoraConsulta.Name = "DTP_HoraConsulta";
            this.DTP_HoraConsulta.Size = new System.Drawing.Size(161, 27);
            this.DTP_HoraConsulta.TabIndex = 32;
            // 
            // DTP_DataConsulta
            // 
            this.DTP_DataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_DataConsulta.Location = new System.Drawing.Point(9, 104);
            this.DTP_DataConsulta.Name = "DTP_DataConsulta";
            this.DTP_DataConsulta.Size = new System.Drawing.Size(161, 27);
            this.DTP_DataConsulta.TabIndex = 31;
            // 
            // LBL_DataConsulta
            // 
            this.LBL_DataConsulta.AutoSize = true;
            this.LBL_DataConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DataConsulta.Location = new System.Drawing.Point(6, 83);
            this.LBL_DataConsulta.Name = "LBL_DataConsulta";
            this.LBL_DataConsulta.Size = new System.Drawing.Size(112, 18);
            this.LBL_DataConsulta.TabIndex = 30;
            this.LBL_DataConsulta.Text = "Data da reserva";
            // 
            // TXT_CodAreaConsulta
            // 
            this.TXT_CodAreaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CodAreaConsulta.Location = new System.Drawing.Point(9, 44);
            this.TXT_CodAreaConsulta.Multiline = true;
            this.TXT_CodAreaConsulta.Name = "TXT_CodAreaConsulta";
            this.TXT_CodAreaConsulta.Size = new System.Drawing.Size(70, 27);
            this.TXT_CodAreaConsulta.TabIndex = 28;
            // 
            // LBL_HoraConsulta
            // 
            this.LBL_HoraConsulta.AutoSize = true;
            this.LBL_HoraConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HoraConsulta.Location = new System.Drawing.Point(6, 144);
            this.LBL_HoraConsulta.Name = "LBL_HoraConsulta";
            this.LBL_HoraConsulta.Size = new System.Drawing.Size(131, 18);
            this.LBL_HoraConsulta.TabIndex = 8;
            this.LBL_HoraConsulta.Text = "Horário da reserva";
            // 
            // LBL_CodAreaConsulta
            // 
            this.LBL_CodAreaConsulta.AutoSize = true;
            this.LBL_CodAreaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CodAreaConsulta.Location = new System.Drawing.Point(6, 23);
            this.LBL_CodAreaConsulta.Name = "LBL_CodAreaConsulta";
            this.LBL_CodAreaConsulta.Size = new System.Drawing.Size(164, 18);
            this.LBL_CodAreaConsulta.TabIndex = 6;
            this.LBL_CodAreaConsulta.Text = "Código da área comum";
            // 
            // GB_BotoesConsultar
            // 
            this.GB_BotoesConsultar.Controls.Add(this.BTN_CancelConsultarArea);
            this.GB_BotoesConsultar.Controls.Add(this.BTN_ConsultarArea);
            this.GB_BotoesConsultar.Location = new System.Drawing.Point(236, 242);
            this.GB_BotoesConsultar.Name = "GB_BotoesConsultar";
            this.GB_BotoesConsultar.Size = new System.Drawing.Size(223, 74);
            this.GB_BotoesConsultar.TabIndex = 6;
            this.GB_BotoesConsultar.TabStop = false;
            // 
            // BTN_CancelConsultarArea
            // 
            this.BTN_CancelConsultarArea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_CancelConsultarArea.Location = new System.Drawing.Point(122, 21);
            this.BTN_CancelConsultarArea.Name = "BTN_CancelConsultarArea";
            this.BTN_CancelConsultarArea.Size = new System.Drawing.Size(82, 36);
            this.BTN_CancelConsultarArea.TabIndex = 2;
            this.BTN_CancelConsultarArea.Text = "Cancelar";
            this.BTN_CancelConsultarArea.UseVisualStyleBackColor = true;
            // 
            // BTN_ConsultarArea
            // 
            this.BTN_ConsultarArea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_ConsultarArea.Location = new System.Drawing.Point(18, 21);
            this.BTN_ConsultarArea.Name = "BTN_ConsultarArea";
            this.BTN_ConsultarArea.Size = new System.Drawing.Size(98, 36);
            this.BTN_ConsultarArea.TabIndex = 1;
            this.BTN_ConsultarArea.Text = "Consultar";
            this.BTN_ConsultarArea.UseVisualStyleBackColor = true;
            // 
            // frmConsultarArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 334);
            this.Controls.Add(this.GB_BotoesConsultar);
            this.Controls.Add(this.GB_ConsultaArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condomínio Transparente :: Portaria - Consultar dísponibilidade da área comum";
            this.GB_ConsultaArea.ResumeLayout(false);
            this.GB_ConsultaArea.PerformLayout();
            this.GB_BotoesConsultar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_ConsultaArea;
        private System.Windows.Forms.DateTimePicker DTP_HoraConsulta;
        private System.Windows.Forms.DateTimePicker DTP_DataConsulta;
        private System.Windows.Forms.Label LBL_DataConsulta;
        private System.Windows.Forms.TextBox TXT_CodAreaConsulta;
        private System.Windows.Forms.Label LBL_HoraConsulta;
        private System.Windows.Forms.Label LBL_CodAreaConsulta;
        private System.Windows.Forms.GroupBox GB_BotoesConsultar;
        private System.Windows.Forms.Button BTN_CancelConsultarArea;
        private System.Windows.Forms.Button BTN_ConsultarArea;
    }
}