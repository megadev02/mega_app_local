namespace Mega.App.Views
{
    partial class TipoDocumentoIdentidadView
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
            this.tbDenominacion = new Bijcorp.Base.customTextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbAbreviatura = new Bijcorp.Base.customTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).BeginInit();
            this.paOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paData)).BeginInit();
            this.paData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDenominacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAbreviatura.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // paOperation
            // 
            this.paOperation.Location = new System.Drawing.Point(0, 96);
            this.paOperation.Size = new System.Drawing.Size(354, 39);
            // 
            // paData
            // 
            this.paData.Controls.Add(this.tbAbreviatura);
            this.paData.Controls.Add(this.labelControl2);
            this.paData.Controls.Add(this.tbDenominacion);
            this.paData.Controls.Add(this.labelControl1);
            this.paData.Location = new System.Drawing.Point(0, 22);
            this.paData.Size = new System.Drawing.Size(354, 74);
            // 
            // tbDenominacion
            // 
            this.tbDenominacion.Location = new System.Drawing.Point(102, 35);
            this.tbDenominacion.Name = "tbDenominacion";
            this.tbDenominacion.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbDenominacion.Properties.Appearance.Options.UseBackColor = true;
            this.tbDenominacion.Size = new System.Drawing.Size(240, 20);
            this.tbDenominacion.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Denominacion:";
            // 
            // tbAbreviatura
            // 
            this.tbAbreviatura.Location = new System.Drawing.Point(102, 9);
            this.tbAbreviatura.Name = "tbAbreviatura";
            this.tbAbreviatura.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbAbreviatura.Properties.Appearance.Options.UseBackColor = true;
            this.tbAbreviatura.Size = new System.Drawing.Size(98, 20);
            this.tbAbreviatura.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Abreviatura:";
            // 
            // TipoDocumentoIdentidadView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 135);
            this.Name = "TipoDocumentoIdentidadView";
            this.Text = "Tipo Documento Identiciación";
            this.Load += new System.EventHandler(this.TipoDocumentoIdentidadView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).EndInit();
            this.paOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paData)).EndInit();
            this.paData.ResumeLayout(false);
            this.paData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDenominacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAbreviatura.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bijcorp.Base.customTextEdit tbDenominacion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Bijcorp.Base.customTextEdit tbAbreviatura;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}