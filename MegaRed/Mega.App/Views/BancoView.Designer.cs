namespace Mega.App.Views
{
    partial class BancoView
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
            this.tbDireccion = new Bijcorp.Base.customTextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbTelefono1 = new Bijcorp.Base.customTextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbTelefono2 = new Bijcorp.Base.customTextEdit();
            this.tbTelefono3 = new Bijcorp.Base.customTextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbEstado = new Bijcorp.Base.customImageComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbBanco = new Mega.App.Controls.cbEntidadFinanciera();
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).BeginInit();
            this.paOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paData)).BeginInit();
            this.paData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTelefono1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTelefono2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTelefono3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBanco.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // paOperation
            // 
            this.paOperation.Location = new System.Drawing.Point(0, 206);
            this.paOperation.Size = new System.Drawing.Size(478, 39);
            // 
            // paData
            // 
            this.paData.Controls.Add(this.cbBanco);
            this.paData.Controls.Add(this.labelControl5);
            this.paData.Controls.Add(this.cbEstado);
            this.paData.Controls.Add(this.labelControl6);
            this.paData.Controls.Add(this.labelControl2);
            this.paData.Controls.Add(this.labelControl1);
            this.paData.Controls.Add(this.tbTelefono3);
            this.paData.Controls.Add(this.tbTelefono2);
            this.paData.Controls.Add(this.tbDireccion);
            this.paData.Controls.Add(this.labelControl4);
            this.paData.Controls.Add(this.tbTelefono1);
            this.paData.Controls.Add(this.labelControl3);
            this.paData.Location = new System.Drawing.Point(0, 22);
            this.paData.Size = new System.Drawing.Size(478, 184);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(171, 38);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbDireccion.Properties.Appearance.Options.UseBackColor = true;
            this.tbDireccion.Size = new System.Drawing.Size(237, 20);
            this.tbDireccion.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(68, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Telefono1:";
            // 
            // tbTelefono1
            // 
            this.tbTelefono1.Location = new System.Drawing.Point(171, 64);
            this.tbTelefono1.Name = "tbTelefono1";
            this.tbTelefono1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbTelefono1.Properties.Appearance.Options.UseBackColor = true;
            this.tbTelefono1.Properties.Mask.EditMask = "\\d\\d\\d-\\d\\d\\d\\d\\d\\d";
            this.tbTelefono1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.tbTelefono1.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono1.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(68, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Direccion:";
            // 
            // tbTelefono2
            // 
            this.tbTelefono2.Location = new System.Drawing.Point(171, 90);
            this.tbTelefono2.Name = "tbTelefono2";
            this.tbTelefono2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbTelefono2.Properties.Appearance.Options.UseBackColor = true;
            this.tbTelefono2.Properties.Mask.EditMask = "\\d\\d\\d-\\d\\d\\d\\d\\d\\d";
            this.tbTelefono2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.tbTelefono2.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono2.TabIndex = 3;
            // 
            // tbTelefono3
            // 
            this.tbTelefono3.Location = new System.Drawing.Point(171, 116);
            this.tbTelefono3.Name = "tbTelefono3";
            this.tbTelefono3.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbTelefono3.Properties.Appearance.Options.UseBackColor = true;
            this.tbTelefono3.Properties.Mask.EditMask = "\\d\\d\\d-\\d\\d\\d\\d\\d\\d";
            this.tbTelefono3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.tbTelefono3.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono3.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(68, 93);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Telefono2:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(68, 119);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Telefono3:";
            // 
            // cbEstado
            // 
            this.cbEstado.EditValue = 1;
            this.cbEstado.Location = new System.Drawing.Point(171, 142);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbEstado.Properties.Appearance.Options.UseBackColor = true;
            this.cbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstado.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Deshabilitado", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Habilitado", 1, -1)});
            this.cbEstado.Size = new System.Drawing.Size(100, 20);
            this.cbEstado.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(68, 145);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 13);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "Estado:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(68, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(90, 13);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Entidad financiera:";
            // 
            // cbBanco
            // 
            this.cbBanco.Location = new System.Drawing.Point(171, 9);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbBanco.Properties.Appearance.Options.UseBackColor = true;
            this.cbBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBanco.Size = new System.Drawing.Size(237, 20);
            this.cbBanco.TabIndex = 0;
            // 
            // BancoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(478, 245);
            this.Name = "BancoView";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.BancoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).EndInit();
            this.paOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paData)).EndInit();
            this.paData.ResumeLayout(false);
            this.paData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTelefono1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTelefono2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTelefono3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBanco.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bijcorp.Base.customTextEdit tbDireccion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Bijcorp.Base.customTextEdit tbTelefono1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Bijcorp.Base.customTextEdit tbTelefono3;
        private Bijcorp.Base.customTextEdit tbTelefono2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Bijcorp.Base.customImageComboBoxEdit cbEstado;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Controls.cbEntidadFinanciera cbBanco;
    }
}
