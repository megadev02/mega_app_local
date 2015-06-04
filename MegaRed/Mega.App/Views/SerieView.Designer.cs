namespace Mega.App.Views
{
    partial class SerieView
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
            this.cbOficinaSerie = new Mega.App.Controls.cbOficina();
            this.cbComprobanteSerie = new Mega.App.Controls.cbComprobante();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tbNumeroSerie = new Bijcorp.Base.customTextEdit();
            this.tbNumeroDigitos = new Bijcorp.Base.customTextEdit();
            this.cbEstado = new Bijcorp.Base.customImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).BeginInit();
            this.paOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paData)).BeginInit();
            this.paData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbOficinaSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbComprobanteSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumeroSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumeroDigitos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // paOperation
            // 
            this.paOperation.Location = new System.Drawing.Point(0, 179);
            this.paOperation.Size = new System.Drawing.Size(402, 39);
            // 
            // paData
            // 
            this.paData.Controls.Add(this.cbEstado);
            this.paData.Controls.Add(this.tbNumeroDigitos);
            this.paData.Controls.Add(this.tbNumeroSerie);
            this.paData.Controls.Add(this.labelControl5);
            this.paData.Controls.Add(this.labelControl4);
            this.paData.Controls.Add(this.labelControl3);
            this.paData.Controls.Add(this.labelControl1);
            this.paData.Controls.Add(this.labelControl2);
            this.paData.Controls.Add(this.cbOficinaSerie);
            this.paData.Controls.Add(this.cbComprobanteSerie);
            this.paData.Location = new System.Drawing.Point(0, 22);
            this.paData.Size = new System.Drawing.Size(402, 157);
            // 
            // cbOficinaSerie
            // 
            this.cbOficinaSerie.Location = new System.Drawing.Point(167, 44);
            this.cbOficinaSerie.Name = "cbOficinaSerie";
            this.cbOficinaSerie.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbOficinaSerie.Properties.Appearance.Options.UseBackColor = true;
            this.cbOficinaSerie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOficinaSerie.Size = new System.Drawing.Size(100, 20);
            this.cbOficinaSerie.TabIndex = 1;
            // 
            // cbComprobanteSerie
            // 
            this.cbComprobanteSerie.Location = new System.Drawing.Point(167, 17);
            this.cbComprobanteSerie.Name = "cbComprobanteSerie";
            this.cbComprobanteSerie.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbComprobanteSerie.Properties.Appearance.Options.UseBackColor = true;
            this.cbComprobanteSerie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbComprobanteSerie.Size = new System.Drawing.Size(100, 20);
            this.cbComprobanteSerie.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(73, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Numero Dígitos:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(73, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Serie:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(73, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Oficina:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(73, 20);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Comprobante:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(73, 125);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Estado:";
            // 
            // tbNumeroSerie
            // 
            this.tbNumeroSerie.Location = new System.Drawing.Point(167, 70);
            this.tbNumeroSerie.Name = "tbNumeroSerie";
            this.tbNumeroSerie.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbNumeroSerie.Properties.Appearance.Options.UseBackColor = true;
            this.tbNumeroSerie.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroSerie.TabIndex = 12;
            // 
            // tbNumeroDigitos
            // 
            this.tbNumeroDigitos.Location = new System.Drawing.Point(167, 96);
            this.tbNumeroDigitos.Name = "tbNumeroDigitos";
            this.tbNumeroDigitos.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbNumeroDigitos.Properties.Appearance.Options.UseBackColor = true;
            this.tbNumeroDigitos.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroDigitos.TabIndex = 13;
            // 
            // cbEstado
            // 
            this.cbEstado.EditValue = 1;
            this.cbEstado.Location = new System.Drawing.Point(167, 122);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbEstado.Properties.Appearance.Options.UseBackColor = true;
            this.cbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstado.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cerrado", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Habilitado", 1, -1)});
            this.cbEstado.Size = new System.Drawing.Size(100, 20);
            this.cbEstado.TabIndex = 14;
            // 
            // SerieView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(402, 218);
            this.Name = "SerieView";
            this.Text = "Serie Comprobante Sunat";
            this.Load += new System.EventHandler(this.SerieView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).EndInit();
            this.paOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paData)).EndInit();
            this.paData.ResumeLayout(false);
            this.paData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbOficinaSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbComprobanteSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumeroSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumeroDigitos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstado.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.cbComprobante cbComprobanteSerie;
        private Controls.cbOficina cbOficinaSerie;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Bijcorp.Base.customTextEdit tbNumeroDigitos;
        private Bijcorp.Base.customTextEdit tbNumeroSerie;
        private Bijcorp.Base.customImageComboBoxEdit cbEstado;
    }
}
