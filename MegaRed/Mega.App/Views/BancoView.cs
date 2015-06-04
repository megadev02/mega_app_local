using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mega.App.Presenters;
using Mega.App.Views.Interface;

namespace Mega.App.Views
{
    public partial class BancoView : Bijcorp.Base.FormBase,IBancoView
    {
        public BancoView()
        {
            InitializeComponent();
        }
        private BancoPresenter _bancoPresenter;

        public int? EntidadId
        {
            get { return Convert.ToInt32(cbBanco.EditValue); }
            set { cbBanco.EditValue = Convert.ToInt32(value); }
        }

        public string Direccion
        {
            get { return tbDireccion.Text; }
            set { tbDireccion.Text = value; }
        }

        public string CodigoUbigeo { get; set; }
        public string Telefono1
        {
            get { return tbTelefono1.Text; }
            set { tbTelefono1.Text = value; }
        }       
        public string Telefono2
        {
            get { return tbTelefono2.Text; }
            set { tbTelefono2.Text = value; }
        }
        public string Telefono3
        {
            get { return tbTelefono3.Text; }
            set { tbTelefono3.Text = value; }
        }
        public bool? Estado
        {
            get { return Convert.ToBoolean(cbEstado.EditValue); }
            set { cbEstado.SelectedIndex = value == true ? 1 : 0; }
        }
        private void BancoView_Load(object sender, EventArgs e)
        {
             cbBanco.Bind();
            _bancoPresenter = new BancoPresenter(this, NavigationMainMenu);
     
        }
    }
}
