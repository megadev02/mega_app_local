namespace Mega.App.Views
{
    partial class DenominacionMonedaView
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
            this.components = new System.ComponentModel.Container();
            this.cbMonedaDenominacion = new Mega.App.Controls.cbMoneda(this.components);
            this.tbValor = new Bijcorp.Base.customTextEdit();
            this.tbDenominacion = new Bijcorp.Base.customTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).BeginInit();
            this.paOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paData)).BeginInit();
            this.paData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedaDenominacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDenominacion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // paData
            // 
            this.paData.Controls.Add(this.labelControl3);
            this.paData.Controls.Add(this.labelControl1);
            this.paData.Controls.Add(this.labelControl2);
            this.paData.Controls.Add(this.tbDenominacion);
            this.paData.Controls.Add(this.tbValor);
            this.paData.Controls.Add(this.cbMonedaDenominacion);
            this.paData.Location = new System.Drawing.Point(0, 22);
            this.paData.Size = new System.Drawing.Size(409, 261);
            // 
            // cbMonedaDenominacion
            // 
            this.cbMonedaDenominacion.Location = new System.Drawing.Point(138, 64);
            this.cbMonedaDenominacion.Name = "cbMonedaDenominacion";
            this.cbMonedaDenominacion.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbMonedaDenominacion.Properties.Appearance.Options.UseBackColor = true;
            this.cbMonedaDenominacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonedaDenominacion.Size = new System.Drawing.Size(210, 20);
            this.cbMonedaDenominacion.TabIndex = 0;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(138, 116);
            this.tbValor.Name = "tbValor";
            this.tbValor.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbValor.Properties.Appearance.Options.UseBackColor = true;
            this.tbValor.Properties.Mask.EditMask = "n";
            this.tbValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbValor.Size = new System.Drawing.Size(210, 20);
            this.tbValor.TabIndex = 2;
            // 
            // tbDenominacion
            // 
            this.tbDenominacion.Location = new System.Drawing.Point(138, 90);
            this.tbDenominacion.Name = "tbDenominacion";
            this.tbDenominacion.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbDenominacion.Properties.Appearance.Options.UseBackColor = true;
            this.tbDenominacion.Size = new System.Drawing.Size(210, 20);
            this.tbDenominacion.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(82, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Moneda:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(96, 119);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Valor:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(54, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Denominacion:";
            // 
            // DenominacionMonedaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(409, 322);
            this.Name = "DenominacionMonedaView";
            this.Text = "Denominación Moneda";
            this.Load += new System.EventHandler(this.DenominacionMonedaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).EndInit();
            this.paOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paData)).EndInit();
            this.paData.ResumeLayout(false);
            this.paData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedaDenominacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDenominacion.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.cbMoneda cbMonedaDenominacion;
        private Bijcorp.Base.customTextEdit tbDenominacion;
        private Bijcorp.Base.customTextEdit tbValor;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
