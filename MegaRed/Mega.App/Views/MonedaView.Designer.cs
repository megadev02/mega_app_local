namespace Mega.App.Views
{
    partial class MonedaView
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
            this.cbEsNacional = new Bijcorp.Base.customImageComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tbNombre = new Bijcorp.Base.customTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbSimbolo = new Bijcorp.Base.customTextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbAbreviatura = new Bijcorp.Base.customTextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tbReferencia = new Bijcorp.Base.customTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).BeginInit();
            this.paOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paData)).BeginInit();
            this.paData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEsNacional.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSimbolo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAbreviatura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReferencia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // paOperation
            // 
            this.paOperation.Location = new System.Drawing.Point(0, 222);
            // 
            // paData
            // 
            this.paData.Controls.Add(this.tbReferencia);
            this.paData.Controls.Add(this.labelControl7);
            this.paData.Controls.Add(this.labelControl1);
            this.paData.Controls.Add(this.cbEstado);
            this.paData.Controls.Add(this.cbEsNacional);
            this.paData.Controls.Add(this.labelControl6);
            this.paData.Controls.Add(this.tbNombre);
            this.paData.Controls.Add(this.labelControl2);
            this.paData.Controls.Add(this.tbSimbolo);
            this.paData.Controls.Add(this.labelControl4);
            this.paData.Controls.Add(this.tbAbreviatura);
            this.paData.Controls.Add(this.labelControl3);
            this.paData.Location = new System.Drawing.Point(0, 22);
            this.paData.Size = new System.Drawing.Size(409, 200);
            // 
            // cbEstado
            // 
            this.cbEstado.EditValue = 1;
            this.cbEstado.Location = new System.Drawing.Point(120, 151);
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
            // cbEsNacional
            // 
            this.cbEsNacional.EditValue = 1;
            this.cbEsNacional.Location = new System.Drawing.Point(120, 125);
            this.cbEsNacional.Name = "cbEsNacional";
            this.cbEsNacional.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbEsNacional.Properties.Appearance.Options.UseBackColor = true;
            this.cbEsNacional.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEsNacional.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sï", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("No", 0, -1)});
            this.cbEsNacional.Size = new System.Drawing.Size(58, 20);
            this.cbEsNacional.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(39, 154);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Estado:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(120, 21);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbNombre.Properties.Appearance.Options.UseBackColor = true;
            this.tbNombre.Size = new System.Drawing.Size(265, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(39, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Nombre:";
            // 
            // tbSimbolo
            // 
            this.tbSimbolo.Location = new System.Drawing.Point(120, 47);
            this.tbSimbolo.Name = "tbSimbolo";
            this.tbSimbolo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbSimbolo.Properties.Appearance.Options.UseBackColor = true;
            this.tbSimbolo.Size = new System.Drawing.Size(100, 20);
            this.tbSimbolo.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(39, 76);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Abreviatura:";
            // 
            // tbAbreviatura
            // 
            this.tbAbreviatura.Location = new System.Drawing.Point(120, 73);
            this.tbAbreviatura.Name = "tbAbreviatura";
            this.tbAbreviatura.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbAbreviatura.Properties.Appearance.Options.UseBackColor = true;
            this.tbAbreviatura.Size = new System.Drawing.Size(100, 20);
            this.tbAbreviatura.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(39, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Simbolo:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 102);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Referencia:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(39, 128);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(58, 13);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "Es Nacional:";
            // 
            // tbReferencia
            // 
            this.tbReferencia.Location = new System.Drawing.Point(120, 99);
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbReferencia.Properties.Appearance.Options.UseBackColor = true;
            this.tbReferencia.Size = new System.Drawing.Size(234, 20);
            this.tbReferencia.TabIndex = 3;
            // 
            // MonedaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 261);
            this.Name = "MonedaView";
            this.Text = "Moneda";
            this.Load += new System.EventHandler(this.MonedaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).EndInit();
            this.paOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paData)).EndInit();
            this.paData.ResumeLayout(false);
            this.paData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEsNacional.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSimbolo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAbreviatura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReferencia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bijcorp.Base.customImageComboBoxEdit cbEstado;
        private Bijcorp.Base.customImageComboBoxEdit cbEsNacional;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Bijcorp.Base.customTextEdit tbNombre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Bijcorp.Base.customTextEdit tbSimbolo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Bijcorp.Base.customTextEdit tbAbreviatura;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Bijcorp.Base.customTextEdit tbReferencia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}