namespace Mega.App.Views
{
    partial class ReciboIngresoEgresoView
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbCodReIE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodReIE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cod ReIE:";
            // 
            // tbCodReIE
            // 
            this.tbCodReIE.Location = new System.Drawing.Point(84, 39);
            this.tbCodReIE.Name = "tbCodReIE";
            this.tbCodReIE.Size = new System.Drawing.Size(100, 20);
            this.tbCodReIE.TabIndex = 1;
            // 
            // ReciboIngresoEgresoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 319);
            this.Controls.Add(this.tbCodReIE);
            this.Controls.Add(this.labelControl1);
            this.Name = "ReciboIngresoEgresoView";
            this.Text = "ReciboIngresoEgresoView";
            ((System.ComponentModel.ISupportInitialize)(this.tbCodReIE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbCodReIE;
    }
}