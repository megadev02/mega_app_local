using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mega.Bdo;
using Mega.Logic;

namespace Mega.App.Controls
{
    public partial class cbCuentaBancaria : DevExpress.XtraEditors.LookUpEdit
    {
         public cbCuentaBancaria()
        {
            InitializeComponent();
        }

         public cbCuentaBancaria(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        void Init()
        {
            this.Properties.Columns.Clear();
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "NumeroCuentaBanco", Visible = true });
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "NombreCuentaBancaria", Visible = true });
            
          
            this.       Properties.ShowHeader = true;
           
            this.Properties.ShowFooter = true;
            this.Properties.NullText = "Seleccionar";
        }

        public void Bind(int entidadId)
        {
            Init();
            this.Properties.DataSource =
                new CuentaBancariaLogic().GetAllBy(CuentaBancariaBdo.CuentaBancariaFields.EntidadId, entidadId);
            this.Properties.ValueMember = "NumeroCuentaBanco";
            this.Properties.DisplayMember = "NombreCuentaBancaria";
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
