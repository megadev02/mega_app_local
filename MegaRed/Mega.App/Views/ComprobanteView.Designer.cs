namespace Mega.App.Views
{
    partial class ComprobanteView
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
            this.cbEstado = new Bijcorp.Base.customImageComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tbCodComprobante = new Bijcorp.Base.customTextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbNombre = new Bijcorp.Base.customTextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).BeginInit();
            this.paOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paData)).BeginInit();
            this.paData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodComprobante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNombre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // paOperation
            // 
            this.paOperation.Location = new System.Drawing.Point(0, 120);
            this.paOperation.Size = new System.Drawing.Size(429, 39);
            // 
            // paData
            // 
            this.paData.Controls.Add(this.tbNombre);
            this.paData.Controls.Add(this.labelControl1);
            this.paData.Controls.Add(this.cbEstado);
            this.paData.Controls.Add(this.labelControl6);
            this.paData.Controls.Add(this.tbCodComprobante);
            this.paData.Controls.Add(this.labelControl3);
            this.paData.Location = new System.Drawing.Point(0, 22);
            this.paData.Size = new System.Drawing.Size(429, 98);
            // 
            // cbEstado
            // 
            this.cbEstado.EditValue = 1;
            this.cbEstado.Location = new System.Drawing.Point(136, 58);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbEstado.Properties.Appearance.Options.UseBackColor = true;
            this.cbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstado.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("No", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Si", 1, -1)});
            this.cbEstado.Size = new System.Drawing.Size(69, 20);
            this.cbEstado.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(82, 61);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 13);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "Estado:";
            // 
            // tbCodComprobante
            // 
            this.tbCodComprobante.Location = new System.Drawing.Point(136, 6);
            this.tbCodComprobante.Name = "tbCodComprobante";
            this.tbCodComprobante.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbCodComprobante.Properties.Appearance.Options.UseBackColor = true;
            this.tbCodComprobante.Size = new System.Drawing.Size(69, 20);
            this.tbCodComprobante.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(82, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Código:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(136, 32);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbNombre.Properties.Appearance.Options.UseBackColor = true;
            this.tbNombre.Size = new System.Drawing.Size(237, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(82, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Nombre:";
            // 
            // ComprobanteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(429, 159);
            this.Name = "ComprobanteView";
            this.Text = "Tipos de comprobante de pago - Sunat";
            this.Load += new System.EventHandler(this.ComprobanteView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).EndInit();
            this.paOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paData)).EndInit();
            this.paData.ResumeLayout(false);
            this.paData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodComprobante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNombre.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bijcorp.Base.customImageComboBoxEdit cbEstado;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Bijcorp.Base.customTextEdit tbCodComprobante;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Bijcorp.Base.customTextEdit tbNombre;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
