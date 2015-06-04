using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mega.Logic;

namespace Mega.App.Controls
{
    public partial class cbOficina : DevExpress.XtraEditors.LookUpEdit
    {        

        public cbOficina()
        {
            InitializeComponent();            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }        

        void Init()
        {
            this.Properties.Columns.Clear();
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "CodigoOficina", Visible = false });
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "NombreOficina", Visible = true });            
            this.Properties.ShowHeader = false;
            this.Properties.ShowFooter = false;
            this.Properties.NullText = "Seleccionar";            
        }

        public void Bind()
        {
            Init();
            this.Properties.DataSource = new OficinaLogic().GetAll();
            this.Properties.ValueMember = "CodigoOficina";
            this.Properties.DisplayMember = "NombreOficina";
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
