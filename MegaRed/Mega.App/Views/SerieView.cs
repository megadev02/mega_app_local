using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mega.App.Controls;
using Mega.App.Presenters;
using Mega.App.Views.Interface;

namespace Mega.App.Views
{
    public partial class SerieView : Bijcorp.Base.FormBase,ISerieView
    {
        public SerieView()
        {
            InitializeComponent();
        }
        private SeriePresenter _seriePresenter;
        

        public string CodComprobante {
            get { return cbComprobanteSerie.EditValue.ToString(); }
            set { cbComprobanteSerie.EditValue = Convert.ToString(value); }
        }
        public int NumeroSerie {
            get { return Convert.ToInt32(tbNumeroSerie.EditValue); }
            set { tbNumeroSerie.EditValue = Convert.ToInt32(value); }
        }
        public int NumeroDigitos
        {
            get { return Convert.ToInt32(tbNumeroDigitos.EditValue); }
            set { tbNumeroDigitos.EditValue = Convert.ToInt32(value); }
        }
        public string CodigoOficina
        {        
            get { return Convert.ToString(cbOficinaSerie.EditValue); }
            set { cbOficinaSerie.EditValue = Convert.ToString(value); }
        }
       
        public bool CierreSerie {
            get { return Convert.ToBoolean(cbEstado.EditValue); }
            set { cbEstado.SelectedIndex = value == true ? 1 : 0; }
        }

       
        private void SerieView_Load(object sender, EventArgs e)
        {
            cbComprobanteSerie.Bind();
            cbOficinaSerie.Bind();
            _seriePresenter = new SeriePresenter(this, NavigationMainMenu);
        }
    }
}
