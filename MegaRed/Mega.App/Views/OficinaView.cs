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
    public partial class OficinaView : FormBase, IOficinaView
    {
        private OficinaPresenter _oficinaPresenter;
        public OficinaView()
        {
            InitializeComponent();
        }

        public string CodigoOficina {
            get { return tbCodigo.Text; }
            set { tbCodigo.Text = value; }
        }
        public string NombreOficina {
            get { return tbNombre.Text; }
            set { tbNombre.Text = value; }
        }
        public string CodigoUbigeo { get; set; }
        public int TipoOficina {
            get { return Convert.ToInt32(cbTipoOficina.EditValue); }
            set { cbTipoOficina.EditValue = Convert.ToInt32(value); }
        }
        public string Direccion {
            get { return tbDireccion.Text; }
            set { tbDireccion.Text = value; }
        }
        public string Telefono {
            get { return tbTelefono.Text; }
            set { tbTelefono.Text = value; }
        }
        public bool Estado {
            get { return Convert.ToBoolean(cbEstado.EditValue); }
            set { cbEstado.SelectedIndex = value == true ? 1 : 0; }
        }

        private void OficinaView_Load(object sender, EventArgs e)
        {
            //enlazando presenter con view
            _oficinaPresenter = new OficinaPresenter(this, NavigationMainMenu);
        }
    }
}
