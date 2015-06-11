namespace Mega.App.Views
{
    partial class TransferenciaView
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
            this.tbNumeroDocumento = new Bijcorp.Base.customTextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deFechaTransf = new Bijcorp.Base.customDateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbImporte = new Bijcorp.Base.customSpinEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSolicitante = new Bijcorp.Base.SearchButtonEdit();
            this.tbBeneficiario = new Bijcorp.Base.SearchButtonEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDocumento1 = new Mega.App.Controls.cbCodDocumento(this.components);
            this.cbMoneda1 = new Mega.App.Controls.cbMoneda(this.components);
            this.cbOficinaDestino = new Mega.App.Controls.cbOficina();
            this.cbOficinaOrigen = new Mega.App.Controls.cbOficina();
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).BeginInit();
            this.paOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paData)).BeginInit();
            this.paData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumeroDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaTransf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbImporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSolicitante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBeneficiario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocumento1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMoneda1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOficinaDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOficinaOrigen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // paOperation
            // 
            this.paOperation.Size = new System.Drawing.Size(694, 39);
            // 
            // paData
            // 
            this.paData.Controls.Add(this.cbDocumento1);
            this.paData.Controls.Add(this.tbBeneficiario);
            this.paData.Controls.Add(this.tbSolicitante);
            this.paData.Controls.Add(this.tbImporte);
            this.paData.Controls.Add(this.cbMoneda1);
            this.paData.Controls.Add(this.deFechaTransf);
            this.paData.Controls.Add(this.cbOficinaDestino);
            this.paData.Controls.Add(this.cbOficinaOrigen);
            this.paData.Controls.Add(this.label7);
            this.paData.Controls.Add(this.label6);
            this.paData.Controls.Add(this.label5);
            this.paData.Controls.Add(this.label4);
            this.paData.Controls.Add(this.label8);
            this.paData.Controls.Add(this.label3);
            this.paData.Controls.Add(this.label2);
            this.paData.Controls.Add(this.label1);
            this.paData.Controls.Add(this.tbNumeroDocumento);
            this.paData.Location = new System.Drawing.Point(0, 22);
            this.paData.Size = new System.Drawing.Size(694, 261);
            // 
            // tbNumeroDocumento
            // 
            this.tbNumeroDocumento.Location = new System.Drawing.Point(223, 26);
            this.tbNumeroDocumento.Name = "tbNumeroDocumento";
            this.tbNumeroDocumento.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbNumeroDocumento.Properties.Appearance.Options.UseBackColor = true;
            this.tbNumeroDocumento.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroDocumento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Of.Procedencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Solicitante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Beneficiario:";
            // 
            // deFechaTransf
            // 
            this.deFechaTransf.EditValue = null;
            this.deFechaTransf.Location = new System.Drawing.Point(136, 131);
            this.deFechaTransf.Name = "deFechaTransf";
            this.deFechaTransf.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.deFechaTransf.Properties.Appearance.Options.UseBackColor = true;
            this.deFechaTransf.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaTransf.Size = new System.Drawing.Size(100, 20);
            this.deFechaTransf.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha Transf:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Moneda:";
            // 
            // tbImporte
            // 
            this.tbImporte.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbImporte.Location = new System.Drawing.Point(136, 173);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbImporte.Properties.Appearance.Options.UseBackColor = true;
            this.tbImporte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.tbImporte.Size = new System.Drawing.Size(100, 20);
            this.tbImporte.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Importe:";
            // 
            // tbSolicitante
            // 
            this.tbSolicitante.EditValue = "";
            this.tbSolicitante.ItemId = 0;
            this.tbSolicitante.ItemSelected = null;
            this.tbSolicitante.Location = new System.Drawing.Point(136, 89);
            this.tbSolicitante.Name = "tbSolicitante";
            this.tbSolicitante.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, true, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.tbSolicitante.Size = new System.Drawing.Size(340, 20);
            this.tbSolicitante.TabIndex = 4;
            // 
            // tbBeneficiario
            // 
            this.tbBeneficiario.EditValue = "";
            this.tbBeneficiario.ItemId = 0;
            this.tbBeneficiario.ItemSelected = null;
            this.tbBeneficiario.Location = new System.Drawing.Point(136, 110);
            this.tbBeneficiario.Name = "tbBeneficiario";
            this.tbBeneficiario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, true, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.tbBeneficiario.Size = new System.Drawing.Size(340, 20);
            this.tbBeneficiario.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Of.Destino:";
            // 
            // cbDocumento1
            // 
            this.cbDocumento1.Location = new System.Drawing.Point(136, 26);
            this.cbDocumento1.Name = "cbDocumento1";
            this.cbDocumento1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbDocumento1.Properties.Appearance.Options.UseBackColor = true;
            this.cbDocumento1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDocumento1.Size = new System.Drawing.Size(85, 20);
            this.cbDocumento1.TabIndex = 0;
            this.cbDocumento1.EditValueChanged += new System.EventHandler(this.cbDocumento1_EditValueChanged);
            // 
            // cbMoneda1
            // 
            this.cbMoneda1.Location = new System.Drawing.Point(136, 152);
            this.cbMoneda1.Name = "cbMoneda1";
            this.cbMoneda1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbMoneda1.Properties.Appearance.Options.UseBackColor = true;
            this.cbMoneda1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMoneda1.Size = new System.Drawing.Size(100, 20);
            this.cbMoneda1.TabIndex = 7;
            // 
            // cbOficinaDestino
            // 
            this.cbOficinaDestino.Location = new System.Drawing.Point(136, 68);
            this.cbOficinaDestino.Name = "cbOficinaDestino";
            this.cbOficinaDestino.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbOficinaDestino.Properties.Appearance.Options.UseBackColor = true;
            this.cbOficinaDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOficinaDestino.Size = new System.Drawing.Size(210, 20);
            this.cbOficinaDestino.TabIndex = 3;
            // 
            // cbOficinaOrigen
            // 
            this.cbOficinaOrigen.Location = new System.Drawing.Point(136, 47);
            this.cbOficinaOrigen.Name = "cbOficinaOrigen";
            this.cbOficinaOrigen.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbOficinaOrigen.Properties.Appearance.Options.UseBackColor = true;
            this.cbOficinaOrigen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOficinaOrigen.Size = new System.Drawing.Size(210, 20);
            this.cbOficinaOrigen.TabIndex = 2;
            // 
            // TransferenciaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 322);
            this.Name = "TransferenciaView";
            this.Text = "Transferencia";
            this.Load += new System.EventHandler(this.TransferenciaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).EndInit();
            this.paOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paData)).EndInit();
            this.paData.ResumeLayout(false);
            this.paData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumeroDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaTransf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbImporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSolicitante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBeneficiario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocumento1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMoneda1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOficinaDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOficinaOrigen.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bijcorp.Base.customTextEdit tbNumeroDocumento;
        private System.Windows.Forms.Label label1;
        private Controls.cbOficina cbOficinaOrigen;
        private System.Windows.Forms.Label label2;
        private Bijcorp.Base.customSpinEdit tbImporte;
        private Controls.cbMoneda cbMoneda1;
        private Bijcorp.Base.customDateEdit deFechaTransf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bijcorp.Base.SearchButtonEdit tbSolicitante;
        private Bijcorp.Base.SearchButtonEdit tbBeneficiario;
        private Controls.cbOficina cbOficinaDestino;
        private System.Windows.Forms.Label label8;
        private Controls.cbCodDocumento cbDocumento1;
    }
}