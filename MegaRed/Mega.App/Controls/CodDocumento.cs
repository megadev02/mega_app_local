﻿using System;
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
    public partial class cbDocumento : DevExpress.XtraEditors.LookUpEdit
    {
        public cbDocumento()
        {
            InitializeComponent();
        }

        public cbDocumento(IContainer container)
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
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "CodDocumento", Visible = true });
            this.Properties.ShowHeader = false;
            this.Properties.ShowFooter = false;
            this.Properties.NullText = "Seleccionar";            
        }

        public void Bind()
        {
            Init();
            this.Properties.DataSource = new DocumentoLogic().GetAll();
            this.Properties.ValueMember = "CodDocumento";
            this.Properties.DisplayMember = "CodDocumento";
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
