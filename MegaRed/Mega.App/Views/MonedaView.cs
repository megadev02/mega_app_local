using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bijcorp.Base;
using Mega.App.Presenters;
using Mega.App.Views.Interface;

namespace Mega.App.Views
{
    public partial class MonedaView : FormBase, IMonedaView
    {
        private MonedaPresenter _monedaPresenter;
        public MonedaView()
        {
            InitializeComponent();
        }
       
        public string Nombre
        {
            get { return tbNombre.Text; }
            set { tbNombre.Text = value; }
        }
        public string Abreviatura
        {
            get { return tbAbreviatura.Text; }
            set { tbAbreviatura.Text = value; }
        }
        public string Simbolo
        {
            get { return tbSimbolo.Text; }
            set { tbSimbolo.Text = value; }
        }
        public string Referencia
        {
            get { return tbReferencia.Text; }
            set { tbReferencia.Text = value; }
        }
        public bool EsNacional
        {
            get { return Convert.ToBoolean(cbEsNacional.EditValue); }
            set { cbEsNacional.SelectedIndex = value == true ? 1 : 0; }
        }
       
        public bool Estado
        {
            get { return Convert.ToBoolean(cbEstado.EditValue); }
            set { cbEstado.SelectedIndex = value == true ? 1 : 0; }
        }

        private void MonedaView_Load(object sender, EventArgs e)
        {

        
            //enlazando presenter con view
            _monedaPresenter = new MonedaPresenter(this, NavigationMainMenu);
        }

        
    }
}
