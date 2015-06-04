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
    public partial class DenominacionMonedaView : Bijcorp.Base.FormBase,IDenominacionMonedaView
    {
        public DenominacionMonedaView()
        {
            InitializeComponent();
        }
        private DenominacionMonedaPresenter _denominacionMonedaPresenter;
       
        public string Denominacion
        {
            get { return tbDenominacion.Text; }
            set { tbDenominacion.Text = value; }
        }
        public decimal Valor
        {
            get { return Convert.ToDecimal(tbValor.EditValue); }
            set { tbValor.EditValue= Convert.ToDecimal(value); }
        }
        public int? MonedaId
        {
            get { return Convert.ToInt32(cbMonedaDenominacion.EditValue); }
            set { cbMonedaDenominacion.EditValue = Convert.ToInt32(value); }

        }               

        private void DenominacionMonedaView_Load(object sender, EventArgs e)
        {
             cbMonedaDenominacion.Bind();
            _denominacionMonedaPresenter = new DenominacionMonedaPresenter(this, NavigationMainMenu);
        
        }
    }
}
