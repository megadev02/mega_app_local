namespace Mega.App.Views
{
    partial class EntidadFinancieraView
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbCodEntidad = new Bijcorp.Base.customTextEdit();
            this.tbEntidadFinanciera = new Bijcorp.Base.customTextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).BeginInit();
            this.paOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paData)).BeginInit();
            this.paData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodEntidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEntidadFinanciera.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // paOperation
            // 
            this.paOperation.Location = new System.Drawing.Point(0, 164);
            this.paOperation.Size = new System.Drawing.Size(482, 39);
            // 
            // paData
            // 
            this.paData.Controls.Add(this.labelControl2);
            this.paData.Controls.Add(this.tbCodEntidad);
            this.paData.Controls.Add(this.tbEntidadFinanciera);
            this.paData.Controls.Add(this.labelControl12);
            this.paData.Location = new System.Drawing.Point(0, 22);
            this.paData.Size = new System.Drawing.Size(482, 142);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(126, 13);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Codigo entidad financiera:";
            // 
            // tbCodEntidad
            // 
            this.tbCodEntidad.Location = new System.Drawing.Point(164, 31);
            this.tbCodEntidad.Name = "tbCodEntidad";
            this.tbCodEntidad.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbCodEntidad.Properties.Appearance.Options.UseBackColor = true;
            this.tbCodEntidad.Size = new System.Drawing.Size(69, 20);
            this.tbCodEntidad.TabIndex = 26;
            // 
            // tbEntidadFinanciera
            // 
            this.tbEntidadFinanciera.Location = new System.Drawing.Point(164, 57);
            this.tbEntidadFinanciera.Name = "tbEntidadFinanciera";
            this.tbEntidadFinanciera.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbEntidadFinanciera.Properties.Appearance.Options.UseBackColor = true;
            this.tbEntidadFinanciera.Size = new System.Drawing.Size(306, 20);
            this.tbEntidadFinanciera.TabIndex = 27;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(28, 60);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(90, 13);
            this.labelControl12.TabIndex = 29;
            this.labelControl12.Text = "Entidad financiera:";
            // 
            // EntidadFinancieraView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(482, 203);
            this.Name = "EntidadFinancieraView";
            this.Text = "Entidad Financiera";
            this.Load += new System.EventHandler(this.EntidadFinancieraView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).EndInit();
            this.paOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paData)).EndInit();
            this.paData.ResumeLayout(false);
            this.paData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodEntidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEntidadFinanciera.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Bijcorp.Base.customTextEdit tbCodEntidad;
        private Bijcorp.Base.customTextEdit tbEntidadFinanciera;
        private DevExpress.XtraEditors.LabelControl labelControl12;
    }
}
