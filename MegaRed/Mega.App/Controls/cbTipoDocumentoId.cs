using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mega.Logic;

namespace Mega.App.Controls
{
    public partial class cbTipoDocumentoId : DevExpress.XtraEditors.LookUpEdit
    {
        public cbTipoDocumentoId()
        {
            InitializeComponent();
        }

        public cbTipoDocumentoId(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        void Init()
        {
            this.Properties.Columns.Clear();
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "TipoDocumentoId", Visible = false });
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Abreviatura", Visible = true });
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Denominacion", Visible = true });
            this.Properties.ShowHeader = true;
            this.Properties.ShowFooter = true;
            this.Properties.NullText = "Seleccionar";
        }

        public void Bind()
        {
            Init();
            this.Properties.DataSource = new TipoDocumentoIdentidadLogic().GetAll();
            this.Properties.ValueMember = "TipoDocumentoId";
            this.Properties.DisplayMember = "Abreviatura";
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (!this.Properties.ReadOnly)
                this.BackColor = Color.LightYellow;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (!this.Properties.ReadOnly)
                this.BackColor = Color.White;
        }

        protected override void OnLoaded()
        {
            base.OnLoaded();
            if (this.Properties.ReadOnly)
            {
                this.BackColor = Color.Gainsboro;

                for (int i = 0; i < this.Properties.Buttons.Count; i++)
                    this.Properties.Buttons[i].Visible = false;
            }
            else
                this.BackColor = Color.White;
        }
    }
}
