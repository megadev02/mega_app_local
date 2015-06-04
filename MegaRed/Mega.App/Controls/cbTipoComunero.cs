using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mega.Logic;
using System.Drawing;
namespace Mega.App.Controls
{
    public partial class cbTipoComunero : DevExpress.XtraEditors.LookUpEdit
    {
        public cbTipoComunero()
        {
            InitializeComponent();
        }

        public cbTipoComunero(IContainer container)
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
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "TipoComuneroId", Visible = false });
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Denominacion", Visible = true });
            this.Properties.ShowHeader = true;
            this.Properties.ShowFooter = true;
            this.Properties.NullText = "Seleccionar";
        }

        public void Bind()
        {
            Init();
            this.Properties.DataSource = new ComprobanteLogic().GetAll();
            this.Properties.ValueMember = "TipoComuneroId";
            this.Properties.DisplayMember = "Denominacion";
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
