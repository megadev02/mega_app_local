namespace Mega.App.Views
{
    partial class ConceptoView
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
            this.tbNombre = new Bijcorp.Base.customTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbPlanContable = new Mega.App.Controls.cbCodigoCuenta(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).BeginInit();
            this.paOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paData)).BeginInit();
            this.paData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlanContable.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // paOperation
            // 
            this.paOperation.Location = new System.Drawing.Point(0, 144);
            // 
            // paData
            // 
            this.paData.Controls.Add(this.cbPlanContable);
            this.paData.Controls.Add(this.labelControl1);
            this.paData.Controls.Add(this.labelControl2);
            this.paData.Controls.Add(this.tbNombre);
            this.paData.Location = new System.Drawing.Point(0, 22);
            this.paData.Size = new System.Drawing.Size(409, 122);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(122, 46);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbNombre.Properties.Appearance.Options.UseBackColor = true;
            this.tbNombre.Size = new System.Drawing.Size(252, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(42, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Nombre:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Código Cuenta:";
            // 
            // cbPlanContable
            // 
            this.cbPlanContable.Location = new System.Drawing.Point(123, 16);
            this.cbPlanContable.Name = "cbPlanContable";
            this.cbPlanContable.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbPlanContable.Properties.Appearance.Options.UseBackColor = true;
            this.cbPlanContable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPlanContable.Size = new System.Drawing.Size(251, 20);
            this.cbPlanContable.TabIndex = 9;
            // 
            // ConceptoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 183);
            this.Name = "ConceptoView";
            this.Text = "Concepto";
            this.Load += new System.EventHandler(this.ConceptoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).EndInit();
            this.paOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paData)).EndInit();
            this.paData.ResumeLayout(false);
            this.paData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlanContable.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bijcorp.Base.customTextEdit tbNombre;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Controls.cbCodigoCuenta cbPlanContable;

    }
}