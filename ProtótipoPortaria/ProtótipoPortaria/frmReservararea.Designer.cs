namespace ProtótipoPortaria
{
    partial class frmReservararea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservararea));
            this.GB_ReservaArea = new System.Windows.Forms.GroupBox();
            this.DTP_HoraReserva = new System.Windows.Forms.DateTimePicker();
            this.DTP_DataReserva = new System.Windows.Forms.DateTimePicker();
            this.LBL_DataReserva = new System.Windows.Forms.Label();
            this.TXT_CodCondôminoReserva = new System.Windows.Forms.TextBox();
            this.TXT_CodArea = new System.Windows.Forms.TextBox();
            this.LBL_HoraReserva = new System.Windows.Forms.Label();
            this.LBL_CodArea = new System.Windows.Forms.Label();
            this.LBL_CodCondôminoReserva = new System.Windows.Forms.Label();
            this.GB_BotoesReservar = new System.Windows.Forms.GroupBox();
            this.BTN_CancelReservaArea = new System.Windows.Forms.Button();
            this.BTN_SalvarReservaArea = new System.Windows.Forms.Button();
            this.GB_ReservaArea.SuspendLayout();
            this.GB_BotoesReservar.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_ReservaArea
            // 
            this.GB_ReservaArea.Controls.Add(this.DTP_HoraReserva);
            this.GB_ReservaArea.Controls.Add(this.DTP_DataReserva);
            this.GB_ReservaArea.Controls.Add(this.LBL_DataReserva);
            this.GB_ReservaArea.Controls.Add(this.TXT_CodCondôminoReserva);
            this.GB_ReservaArea.Controls.Add(this.TXT_CodArea);
            this.GB_ReservaArea.Controls.Add(this.LBL_HoraReserva);
            this.GB_ReservaArea.Controls.Add(this.LBL_CodArea);
            this.GB_ReservaArea.Controls.Add(this.LBL_CodCondôminoReserva);
            this.GB_ReservaArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_ReservaArea.Location = new System.Drawing.Point(12, 12);
            this.GB_ReservaArea.Name = "GB_ReservaArea";
            this.GB_ReservaArea.Size = new System.Drawing.Size(437, 291);
            this.GB_ReservaArea.TabIndex = 3;
            this.GB_ReservaArea.TabStop = false;
            this.GB_ReservaArea.Text = "Dados para realizar a reserva";
            // 
            // DTP_HoraReserva
            // 
            this.DTP_HoraReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_HoraReserva.Location = new System.Drawing.Point(9, 229);
            this.DTP_HoraReserva.Name = "DTP_HoraReserva";
            this.DTP_HoraReserva.Size = new System.Drawing.Size(161, 27);
            this.DTP_HoraReserva.TabIndex = 32;
            // 
            // DTP_DataReserva
            // 
            this.DTP_DataReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_DataReserva.Location = new System.Drawing.Point(9, 168);
            this.DTP_DataReserva.Name = "DTP_DataReserva";
            this.DTP_DataReserva.Size = new System.Drawing.Size(161, 27);
            this.DTP_DataReserva.TabIndex = 31;
            // 
            // LBL_DataReserva
            // 
            this.LBL_DataReserva.AutoSize = true;
            this.LBL_DataReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DataReserva.Location = new System.Drawing.Point(6, 147);
            this.LBL_DataReserva.Name = "LBL_DataReserva";
            this.LBL_DataReserva.Size = new System.Drawing.Size(112, 18);
            this.LBL_DataReserva.TabIndex = 30;
            this.LBL_DataReserva.Text = "Data da reserva";
            // 
            // TXT_CodCondôminoReserva
            // 
            this.TXT_CodCondôminoReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CodCondôminoReserva.Location = new System.Drawing.Point(9, 48);
            this.TXT_CodCondôminoReserva.Multiline = true;
            this.TXT_CodCondôminoReserva.Name = "TXT_CodCondôminoReserva";
            this.TXT_CodCondôminoReserva.Size = new System.Drawing.Size(70, 27);
            this.TXT_CodCondôminoReserva.TabIndex = 29;
            // 
            // TXT_CodArea
            // 
            this.TXT_CodArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CodArea.Location = new System.Drawing.Point(9, 108);
            this.TXT_CodArea.Multiline = true;
            this.TXT_CodArea.Name = "TXT_CodArea";
            this.TXT_CodArea.Size = new System.Drawing.Size(70, 27);
            this.TXT_CodArea.TabIndex = 28;
            // 
            // LBL_HoraReserva
            // 
            this.LBL_HoraReserva.AutoSize = true;
            this.LBL_HoraReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HoraReserva.Location = new System.Drawing.Point(6, 208);
            this.LBL_HoraReserva.Name = "LBL_HoraReserva";
            this.LBL_HoraReserva.Size = new System.Drawing.Size(131, 18);
            this.LBL_HoraReserva.TabIndex = 8;
            this.LBL_HoraReserva.Text = "Horário da reserva";
            // 
            // LBL_CodArea
            // 
            this.LBL_CodArea.AutoSize = true;
            this.LBL_CodArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CodArea.Location = new System.Drawing.Point(6, 87);
            this.LBL_CodArea.Name = "LBL_CodArea";
            this.LBL_CodArea.Size = new System.Drawing.Size(164, 18);
            this.LBL_CodArea.TabIndex = 6;
            this.LBL_CodArea.Text = "Código da área comum";
            // 
            // LBL_CodCondôminoReserva
            // 
            this.LBL_CodCondôminoReserva.AutoSize = true;
            this.LBL_CodCondôminoReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CodCondôminoReserva.Location = new System.Drawing.Point(6, 30);
            this.LBL_CodCondôminoReserva.Name = "LBL_CodCondôminoReserva";
            this.LBL_CodCondôminoReserva.Size = new System.Drawing.Size(156, 18);
            this.LBL_CodCondôminoReserva.TabIndex = 1;
            this.LBL_CodCondôminoReserva.Text = "Código do condômino";
            // 
            // GB_BotoesReservar
            // 
            this.GB_BotoesReservar.Controls.Add(this.BTN_CancelReservaArea);
            this.GB_BotoesReservar.Controls.Add(this.BTN_SalvarReservaArea);
            this.GB_BotoesReservar.Location = new System.Drawing.Point(226, 309);
            this.GB_BotoesReservar.Name = "GB_BotoesReservar";
            this.GB_BotoesReservar.Size = new System.Drawing.Size(223, 74);
            this.GB_BotoesReservar.TabIndex = 5;
            this.GB_BotoesReservar.TabStop = false;
            // 
            // BTN_CancelReservaArea
            // 
            this.BTN_CancelReservaArea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_CancelReservaArea.Location = new System.Drawing.Point(122, 21);
            this.BTN_CancelReservaArea.Name = "BTN_CancelReservaArea";
            this.BTN_CancelReservaArea.Size = new System.Drawing.Size(82, 36);
            this.BTN_CancelReservaArea.TabIndex = 2;
            this.BTN_CancelReservaArea.Text = "Cancelar";
            this.BTN_CancelReservaArea.UseVisualStyleBackColor = true;
            // 
            // BTN_SalvarReservaArea
            // 
            this.BTN_SalvarReservaArea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_SalvarReservaArea.Location = new System.Drawing.Point(18, 21);
            this.BTN_SalvarReservaArea.Name = "BTN_SalvarReservaArea";
            this.BTN_SalvarReservaArea.Size = new System.Drawing.Size(98, 36);
            this.BTN_SalvarReservaArea.TabIndex = 1;
            this.BTN_SalvarReservaArea.Text = "Salvar";
            this.BTN_SalvarReservaArea.UseVisualStyleBackColor = true;
            // 
            // frmReservararea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_CancelReservaArea;
            this.ClientSize = new System.Drawing.Size(456, 391);
            this.Controls.Add(this.GB_BotoesReservar);
            this.Controls.Add(this.GB_ReservaArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReservararea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condomínio Transparente :: Portaria - Reserva de áreas comuns";
            this.TopMost = true;
            this.GB_ReservaArea.ResumeLayout(false);
            this.GB_ReservaArea.PerformLayout();
            this.GB_BotoesReservar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_ReservaArea;
        private System.Windows.Forms.TextBox TXT_CodCondôminoReserva;
        private System.Windows.Forms.TextBox TXT_CodArea;
        private System.Windows.Forms.Label LBL_HoraReserva;
        private System.Windows.Forms.Label LBL_CodArea;
        private System.Windows.Forms.Label LBL_CodCondôminoReserva;
        private System.Windows.Forms.DateTimePicker DTP_HoraReserva;
        private System.Windows.Forms.DateTimePicker DTP_DataReserva;
        private System.Windows.Forms.Label LBL_DataReserva;
        private System.Windows.Forms.GroupBox GB_BotoesReservar;
        private System.Windows.Forms.Button BTN_CancelReservaArea;
        private System.Windows.Forms.Button BTN_SalvarReservaArea;
    }
}