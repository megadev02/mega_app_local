using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;

using Mega.App.Views.Interface;
using Mega.Bdo;
using Mega.Logic;
using Bijcorp.Base;
namespace Mega.App.Search
{
    public partial class FormSearchMoneda : FormSearchTextBox
    {
        public FormSearchMoneda()
        {
            InitializeComponent();
        }

        private IMonedaView _monedaView;

        public FormSearchMoneda(IMonedaView monedaView)
        {
            InitializeComponent();
            _monedaView = monedaView;
            _KeyType = KeyType.String;
        }

        protected override void InitializeAppeareance()
        {
            var gcol_MonedaId = gvSearch.Columns.AddField(MonedaBdo.MonedaFields.MonedaId.ToString());
            gcol_MonedaId.Caption = "MonedaId";
            gcol_MonedaId.Visible = true;

            var gcol_Nombre = gvSearch.Columns.AddField(MonedaBdo.MonedaFields.Nombre.ToString());
            gcol_Nombre.Caption = "Nombre";
            gcol_Nombre.Visible = true;

            var gcol_Simbolo = gvSearch.Columns.AddField(MonedaBdo.MonedaFields.Simbolo.ToString());
            gcol_Simbolo.Caption = "Simbolo";
            gcol_Simbolo.Visible = true;

            var gcol_Abreviatura = gvSearch.Columns.AddField(MonedaBdo.MonedaFields.Abreviatura.ToString());
            gcol_Abreviatura.Caption = "Abreviatura";
            gcol_Abreviatura.Visible = true;

            var gcol_Referencia = gvSearch.Columns.AddField(MonedaBdo.MonedaFields.Referencia.ToString());
            gcol_Referencia.Caption = "Referencia";
            gcol_Referencia.Visible = true;

            var gcol_EsNacional = gvSearch.Columns.AddField(MonedaBdo.MonedaFields.EsNacional.ToString());
            gcol_EsNacional.Caption = "EsNacional";
            gcol_EsNacional.Visible = true;

            var gcol_Estado = gvSearch.Columns.AddField(MonedaBdo.MonedaFields.Estado.ToString());
            gcol_Estado.Caption = "Estado";
            gcol_Estado.Visible = true;
            gvSearch.BestFitColumns();
        }

        protected override void InitializeSearchField()
        {
            cbSearchField.Properties.Items.Add(MonedaBdo.MonedaFields.MonedaId.ToString());
            cbSearchField.Properties.Items.Add(MonedaBdo.MonedaFields.Nombre.ToString());
            cbSearchField.Properties.Items.Add(MonedaBdo.MonedaFields.Simbolo.ToString());
            cbSearchField.Properties.Items.Add(MonedaBdo.MonedaFields.Abreviatura.ToString());
            cbSearchField.Properties.Items.Add(MonedaBdo.MonedaFields.Referencia.ToString());
            cbSearchField.Properties.Items.Add(MonedaBdo.MonedaFields.EsNacional.ToString());
            cbSearchField.Properties.Items.Add(MonedaBdo.MonedaFields.Estado.ToString());

            cbSearchField.SelectedText = MonedaBdo.MonedaFields.Nombre.ToString();
        }

        protected override void InitializeData()
        {
            var dtSearch = from m in new MonedaLogic().GetAll()
                where
                    (_monedaView.Nombre.Trim().Length == 0 ||
                     _monedaView.Nombre.Contains(_monedaView.Nombre))
                select m;

            InitializeData(MonedaBdo.MonedaFields.MonedaId.ToString(), MonedaBdo.MonedaFields.Nombre.ToString(), Utilities.ToDataTable(dtSearch.ToList()));
        }
    }
}
