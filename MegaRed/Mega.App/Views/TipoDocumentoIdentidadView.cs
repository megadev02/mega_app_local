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
    public partial class TipoDocumentoIdentidadView : FormBase,ITipoDocumentoIdentidadView
    {
        public TipoDocumentoIdentidadView()
        {
            InitializeComponent();
        }
        private TipoDocumentoIdentidadPresenter _tipoDocumentoIdentidadPresenter;
       
        public string Denominacion {
            get { return tbDenominacion.Text; }
            set { tbDenominacion.Text = value; }
        }
        public string Abreviatura
        {
            get { return tbAbreviatura.Text; }
            set { tbAbreviatura.Text = value; }
        }     

        private void TipoDocumentoIdentidadView_Load(object sender, EventArgs e)
        {
            _tipoDocumentoIdentidadPresenter = new TipoDocumentoIdentidadPresenter(this, NavigationMainMenu);
        }
    }
}
