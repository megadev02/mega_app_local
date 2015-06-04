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
    public partial class cbEntidadFinanciera : DevExpress.XtraEditors.LookUpEdit
    {
        public cbEntidadFinanciera()
        {
            InitializeComponent();
        }

        public cbEntidadFinanciera(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
       
        void Init()
        {
            this.Properties.Columns.Clear();
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "EntidadId", Visible = false });
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "CodEntidad", Visible = true });
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Nombre", Visible = true });
          
            this.Properties.ShowHeader = true;
            this.Properties.ShowFooter = true;
            this.Properties.NullText = "Seleccionar";
        }

        public void Bind()
        {
            Init();
            this.Properties.DataSource = new EntidadFinancieraLogic().GetAll();
            this.Properties.ValueMember = "EntidadId";
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
