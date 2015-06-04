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
    public partial class ComprobanteView : Bijcorp.Base.FormBase,IComprobanteView
    {
        public ComprobanteView()
        {
            InitializeComponent();
        }
        private ComprobantePresenter _comprobantePresenter;
        
        public string CodComprobante
        {
            get { return tbCodComprobante.Text; }
            set { tbCodComprobante.Text = value; }
        }        
        public string NombreComprobante
        {
            get { return tbNombre.Text; }
            set { tbNombre.Text = value; }
        }
       
        public bool CreditoFiscal
        {
            get { return Convert.ToBoolean(cbEstado.EditValue); }
            set { cbEstado.SelectedIndex = value == true ? 1 : 0; }
        }       
        private void ComprobanteView_Load(object sender, EventArgs e)
        {
            _comprobantePresenter = new ComprobantePresenter(this, NavigationMainMenu);
        }

        
    }
}
