using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mega.Logic;

namespace Mega.App.Controls
{
    public partial class cbBanco : DevExpress.XtraEditors.LookUpEdit
    {
        public cbBanco()
        {
            InitializeComponent();
        }

        public cbBanco(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
       
        void Init()
        {
            this.Properties.Columns.Clear();
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "BancoId", Visible = false });            
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Nombre", Visible = true });
          
            this.Properties.ShowHeader = true;
            this.Properties.ShowFooter = true;
            this.Properties.NullText = "Seleccionar";
        }

        public void Bind()
        {
            Init();

            var query = (from m in new BancoLogic().GetAll()
                from n in new EntidadFinancieraLogic().GetAll().Where(x => x.EntidadId == m.EntidadId)
                select new {m.BancoId, Nombre = n.CodEntidad + " - " + m.Direccion,});

            this.Properties.DataSource = query;
            this.Properties.ValueMember = "BancoId";
            this.Properties.DisplayMember = "Nombre";
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
