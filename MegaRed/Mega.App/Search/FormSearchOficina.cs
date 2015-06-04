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
using DevExpress.XtraGrid.Columns;
using Mega.App.Views;
using Mega.App.Views.Interface;
using Mega.Bdo;
using Mega.Logic;

namespace Mega.App.Search
{
    public partial class FormSearchOficina : FormSearchTextBox
    {
        private IOficinaView _oficinaView;

        public FormSearchOficina()
        {
            InitializeComponent();
        }

        public FormSearchOficina(IOficinaView oficinaView)
        {
            InitializeComponent();
            _oficinaView = oficinaView;
            _KeyType = KeyType.String;
        }

        protected override void InitializeAppeareance()
        {
            var gcol_Oficina = gvSearch.Columns.AddField(OficinaBdo.OficinaFields.CodigoOficina.ToString());
            gcol_Oficina.Caption = "Código";
            gcol_Oficina.Visible = true;

            var gcol_Nombre = gvSearch.Columns.AddField(OficinaBdo.OficinaFields.NombreOficina.ToString());
            gcol_Nombre.Caption = "Nombre";
            gcol_Nombre.Visible = true;

            var gcol_Direccion = gvSearch.Columns.AddField(OficinaBdo.OficinaFields.Direccion.ToString());
            gcol_Direccion.Caption = "Dirección";
            gcol_Direccion.Visible = true;
            
            gvSearch.BestFitColumns();
        }

        protected override void InitializeSearchField()
        {
            cbSearchField.Properties.Items.Add(OficinaBdo.OficinaFields.CodigoOficina.ToString());
            cbSearchField.Properties.Items.Add(OficinaBdo.OficinaFields.NombreOficina.ToString());
            cbSearchField.Properties.Items.Add(OficinaBdo.OficinaFields.Direccion.ToString());

            cbSearchField.SelectedText = OficinaBdo.OficinaFields.NombreOficina.ToString();
        }

        protected override void InitializeData()
        {
            var dtSearch = from m in new OficinaLogic().GetAll()
                where
                    (_oficinaView.CodigoOficina.Trim().Length == 0 ||
                     _oficinaView.CodigoOficina.Contains(_oficinaView.CodigoOficina))
                    &&
                    (_oficinaView.NombreOficina.Trim().Length == 0 ||
                     _oficinaView.NombreOficina.Contains(_oficinaView.NombreOficina))
                select m;

            InitializeData(OficinaBdo.OficinaFields.CodigoOficina.ToString(), OficinaBdo.OficinaFields.NombreOficina.ToString(), Utilities.ToDataTable(dtSearch.ToList()));
        }
    }
}
