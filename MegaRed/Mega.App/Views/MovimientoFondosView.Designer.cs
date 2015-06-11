namespace Mega.App.Views
{
    partial class MovimientoFondosView
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.tbCodigoPersona = new Bijcorp.Base.SearchButtonEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.cbBanco1 = new Mega.App.Controls.cbBanco(this.components);
            this.cbCuentaBancaria1 = new Mega.App.Controls.cbCuentaBancaria(this.components);
            this.tbNumOperacion = new Bijcorp.Base.customTextEdit();
            this.tbCodVoucher = new Bijcorp.Base.customTextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbImporte = new Bijcorp.Base.customSpinEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumeroDocumento = new Bijcorp.Base.customTextEdit();
            this.cbOfProcedencia = new Mega.App.Controls.cbOficina();
            this.cbOfDestino = new Mega.App.Controls.cbOficina();
            this.cbMoneda1 = new Mega.App.Controls.cbMoneda(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.paDestino = new DevExpress.XtraEditors.PanelControl();
            this.paProcedencia = new DevExpress.XtraEditors.PanelControl();
            this.gcRecibos = new DevExpress.XtraGrid.GridControl();
            this.gvRecibos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDocumento1 = new Mega.App.Controls.cbCodDocumento(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).BeginInit();
            this.paOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paData)).BeginInit();
            this.paData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodigoPersona.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbBanco1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCuentaBancaria1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumOperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodVoucher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbImporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumeroDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOfProcedencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOfDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMoneda1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paDestino)).BeginInit();
            this.paDestino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paProcedencia)).BeginInit();
            this.paProcedencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRecibos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecibos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbObservacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocumento1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // paOperation
            // 
            this.paOperation.Location = new System.Drawing.Point(0, 448);
            this.paOperation.Size = new System.Drawing.Size(642, 39);
            // 
            // paData
            // 
            this.paData.Controls.Add(this.cbDocumento1);
            this.paData.Controls.Add(this.tbObservacion);
            this.paData.Controls.Add(this.gcRecibos);
            this.paData.Controls.Add(this.panelControl1);
            this.paData.Controls.Add(this.cbMoneda1);
            this.paData.Controls.Add(this.xtraTabControl1);
            this.paData.Controls.Add(this.tbImporte);
            this.paData.Controls.Add(this.label7);
            this.paData.Controls.Add(this.label5);
            this.paData.Controls.Add(this.label6);
            this.paData.Controls.Add(this.label1);
            this.paData.Controls.Add(this.tbNumeroDocumento);
            this.paData.Location = new System.Drawing.Point(0, 22);
            this.paData.Size = new System.Drawing.Size(642, 426);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(13, 125);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(617, 102);
            this.xtraTabControl1.TabIndex = 63;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.Text = "Personal";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.tbCodigoPersona);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(608, 72);
            this.xtraTabPage1.Text = "Efectivo/Intercambio";
            // 
            // tbCodigoPersona
            // 
            this.tbCodigoPersona.EditValue = "";
            this.tbCodigoPersona.ItemId = 0;
            this.tbCodigoPersona.ItemSelected = null;
            this.tbCodigoPersona.Location = new System.Drawing.Point(110, 15);
            this.tbCodigoPersona.Name = "tbCodigoPersona";
            this.tbCodigoPersona.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, true, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.tbCodigoPersona.Size = new System.Drawing.Size(467, 20);
            this.tbCodigoPersona.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Persona:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.cbBanco1);
            this.xtraTabPage2.Controls.Add(this.cbCuentaBancaria1);
            this.xtraTabPage2.Controls.Add(this.tbNumOperacion);
            this.xtraTabPage2.Controls.Add(this.tbCodVoucher);
            this.xtraTabPage2.Controls.Add(this.label9);
            this.xtraTabPage2.Controls.Add(this.label13);
            this.xtraTabPage2.Controls.Add(this.label4);
            this.xtraTabPage2.Controls.Add(this.label14);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(608, 72);
            this.xtraTabPage2.Text = "Bancos";
            // 
            // cbBanco1
            // 
            this.cbBanco1.Location = new System.Drawing.Point(111, 11);
            this.cbBanco1.Name = "cbBanco1";
            this.cbBanco1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbBanco1.Properties.Appearance.Options.UseBackColor = true;
            this.cbBanco1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBanco1.Size = new System.Drawing.Size(186, 20);
            this.cbBanco1.TabIndex = 30;
            // 
            // cbCuentaBancaria1
            // 
            this.cbCuentaBancaria1.Location = new System.Drawing.Point(111, 32);
            this.cbCuentaBancaria1.Name = "cbCuentaBancaria1";
            this.cbCuentaBancaria1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbCuentaBancaria1.Properties.Appearance.Options.UseBackColor = true;
            this.cbCuentaBancaria1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCuentaBancaria1.Size = new System.Drawing.Size(186, 20);
            this.cbCuentaBancaria1.TabIndex = 29;
            // 
            // tbNumOperacion
            // 
            this.tbNumOperacion.Location = new System.Drawing.Point(409, 32);
            this.tbNumOperacion.Name = "tbNumOperacion";
            this.tbNumOperacion.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbNumOperacion.Properties.Appearance.Options.UseBackColor = true;
            this.tbNumOperacion.Size = new System.Drawing.Size(186, 20);
            this.tbNumOperacion.TabIndex = 28;
            // 
            // tbCodVoucher
            // 
            this.tbCodVoucher.Location = new System.Drawing.Point(409, 11);
            this.tbCodVoucher.Name = "tbCodVoucher";
            this.tbCodVoucher.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbCodVoucher.Properties.Appearance.Options.UseBackColor = true;
            this.tbCodVoucher.Size = new System.Drawing.Size(186, 20);
            this.tbCodVoucher.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cód.Cta bancaria:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(315, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Código voucher:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Banco:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(315, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Nro operación:";
            // 
            // tbImporte
            // 
            this.tbImporte.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbImporte.Location = new System.Drawing.Point(126, 78);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbImporte.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.tbImporte.Properties.Appearance.Options.UseBackColor = true;
            this.tbImporte.Properties.Appearance.Options.UseFont = true;
            this.tbImporte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.tbImporte.Size = new System.Drawing.Size(200, 39);
            this.tbImporte.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Importe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Moneda:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Of.Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Of.Procedencia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Documento:";
            // 
            // tbNumeroDocumento
            // 
            this.tbNumeroDocumento.Location = new System.Drawing.Point(222, 13);
            this.tbNumeroDocumento.Name = "tbNumeroDocumento";
            this.tbNumeroDocumento.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbNumeroDocumento.Properties.Appearance.Options.UseBackColor = true;
            this.tbNumeroDocumento.Size = new System.Drawing.Size(104, 20);
            this.tbNumeroDocumento.TabIndex = 58;
            // 
            // cbOfProcedencia
            // 
            this.cbOfProcedencia.Location = new System.Drawing.Point(95, 1);
            this.cbOfProcedencia.Name = "cbOfProcedencia";
            this.cbOfProcedencia.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbOfProcedencia.Properties.Appearance.Options.UseBackColor = true;
            this.cbOfProcedencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOfProcedencia.Size = new System.Drawing.Size(200, 20);
            this.cbOfProcedencia.TabIndex = 64;
            // 
            // cbOfDestino
            // 
            this.cbOfDestino.Location = new System.Drawing.Point(95, 1);
            this.cbOfDestino.Name = "cbOfDestino";
            this.cbOfDestino.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbOfDestino.Properties.Appearance.Options.UseBackColor = true;
            this.cbOfDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOfDestino.Size = new System.Drawing.Size(200, 20);
            this.cbOfDestino.TabIndex = 65;
            // 
            // cbMoneda1
            // 
            this.cbMoneda1.Location = new System.Drawing.Point(126, 57);
            this.cbMoneda1.Name = "cbMoneda1";
            this.cbMoneda1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbMoneda1.Properties.Appearance.Options.UseBackColor = true;
            this.cbMoneda1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMoneda1.Size = new System.Drawing.Size(100, 20);
            this.cbMoneda1.TabIndex = 68;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.paDestino);
            this.panelControl1.Controls.Add(this.paProcedencia);
            this.panelControl1.Location = new System.Drawing.Point(31, 34);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(607, 22);
            this.panelControl1.TabIndex = 69;
            this.panelControl1.Text = "panelControl1";
            // 
            // paDestino
            // 
            this.paDestino.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paDestino.Controls.Add(this.cbOfDestino);
            this.paDestino.Controls.Add(this.label8);
            this.paDestino.Dock = System.Windows.Forms.DockStyle.Left;
            this.paDestino.Location = new System.Drawing.Point(303, 0);
            this.paDestino.Name = "paDestino";
            this.paDestino.Size = new System.Drawing.Size(301, 22);
            this.paDestino.TabIndex = 67;
            this.paDestino.Text = "panelControl3";
            // 
            // paProcedencia
            // 
            this.paProcedencia.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paProcedencia.Controls.Add(this.cbOfProcedencia);
            this.paProcedencia.Controls.Add(this.label2);
            this.paProcedencia.Dock = System.Windows.Forms.DockStyle.Left;
            this.paProcedencia.Location = new System.Drawing.Point(0, 0);
            this.paProcedencia.Name = "paProcedencia";
            this.paProcedencia.Size = new System.Drawing.Size(303, 22);
            this.paProcedencia.TabIndex = 66;
            this.paProcedencia.Text = "panelControl2";
            // 
            // gcRecibos
            // 
            // 
            // 
            // 
            this.gcRecibos.EmbeddedNavigator.Name = "";
            this.gcRecibos.Location = new System.Drawing.Point(13, 233);
            this.gcRecibos.MainView = this.gvRecibos;
            this.gcRecibos.Name = "gcRecibos";
            this.gcRecibos.Size = new System.Drawing.Size(611, 172);
            this.gcRecibos.TabIndex = 70;
            this.gcRecibos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRecibos});
            // 
            // gvRecibos
            // 
            this.gvRecibos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvRecibos.GridControl = this.gcRecibos;
            this.gvRecibos.Name = "gvRecibos";
            this.gvRecibos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Documento";
            this.gridColumn1.FieldName = "Documento";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Concepto";
            this.gridColumn2.FieldName = "Concepto";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cuenta";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Importe";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // tbObservacion
            // 
            this.tbObservacion.Location = new System.Drawing.Point(346, 78);
            this.tbObservacion.Name = "tbObservacion";
            this.tbObservacion.Size = new System.Drawing.Size(278, 39);
            this.tbObservacion.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Observación:";
            // 
            // cbDocumento1
            // 
            this.cbDocumento1.Location = new System.Drawing.Point(126, 13);
            this.cbDocumento1.Name = "cbDocumento1";
            this.cbDocumento1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbDocumento1.Properties.Appearance.Options.UseBackColor = true;
            this.cbDocumento1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDocumento1.Size = new System.Drawing.Size(95, 20);
            this.cbDocumento1.TabIndex = 72;
            this.cbDocumento1.EditValueChanged += new System.EventHandler(this.cbDocumento1_EditValueChanged);
            // 
            // MovimientoFondosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 487);
            this.Name = "MovimientoFondosView";
            this.Text = "Movimiento de fondos";
            this.Load += new System.EventHandler(this.MovimientoFondosView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).EndInit();
            this.paOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paData)).EndInit();
            this.paData.ResumeLayout(false);
            this.paData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodigoPersona.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbBanco1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCuentaBancaria1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumOperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodVoucher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbImporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumeroDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOfProcedencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOfDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMoneda1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paDestino)).EndInit();
            this.paDestino.ResumeLayout(false);
            this.paDestino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paProcedencia)).EndInit();
            this.paProcedencia.ResumeLayout(false);
            this.paProcedencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRecibos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecibos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbObservacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocumento1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Bijcorp.Base.SearchButtonEdit tbCodigoPersona;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Bijcorp.Base.customTextEdit tbNumOperacion;
        private Bijcorp.Base.customTextEdit tbCodVoucher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private Bijcorp.Base.customSpinEdit tbImporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bijcorp.Base.customTextEdit tbNumeroDocumento;
        private Controls.cbMoneda cbMoneda1;
        private Controls.cbOficina cbOfDestino;
        private Controls.cbOficina cbOfProcedencia;
        private Controls.cbBanco cbBanco1;
        private Controls.cbCuentaBancaria cbCuentaBancaria1;
        private DevExpress.XtraGrid.GridControl gcRecibos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRecibos;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl paDestino;
        private DevExpress.XtraEditors.PanelControl paProcedencia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.MemoEdit tbObservacion;
        private System.Windows.Forms.Label label5;
        private Controls.cbCodDocumento cbDocumento1;



    }
}