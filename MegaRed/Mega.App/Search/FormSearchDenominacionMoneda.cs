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
using Mega.App.Views.Interface;
using Mega.Bdo;
using Mega.Logic;

namespace Mega.App.Search
{
    public partial class FormSearchDenominacionMoneda : FormSearchTextBox
    {
        public FormSearchDenominacionMoneda()
        {
            InitializeComponent();
        }
         private IDenominacionMonedaView _denominacionMonedaView;

         public FormSearchDenominacionMoneda(IDenominacionMonedaView denominacionMonedaView)
        {
            InitializeComponent();
            _denominacionMonedaView = denominacionMonedaView;
            _KeyType = KeyType.Int;
        }

        protected override void InitializeAppeareance()
        {
            var gcol_DenominacionMonedaId = gvSearch.Columns.AddField(DenominacionMonedaBdo.DenominacionMonedaFields.DenominacionMonedaId.ToString());
            gcol_DenominacionMonedaId.Caption = "DenominacionMonedaId";
            gcol_DenominacionMonedaId.Visible = true;

            var gcol_Denominacion = gvSearch.Columns.AddField(DenominacionMonedaBdo.DenominacionMonedaFields.Denominacion.ToString());
            gcol_Denominacion.Caption = "Denominacion";
            gcol_Denominacion.Visible = true;

            var gcol_Valor = gvSearch.Columns.AddField(DenominacionMonedaBdo.DenominacionMonedaFields.Valor.ToString());
            gcol_Valor.Caption = "Valor";
            gcol_Valor.Visible = true;

            var gcol_MonedaId = gvSearch.Columns.AddField(DenominacionMonedaBdo.DenominacionMonedaFields.MonedaId.ToString());
            gcol_MonedaId.Caption = "MonedaId";
            gcol_MonedaId.Visible = true;

            
            gvSearch.BestFitColumns();
        }

        protected override void InitializeSearchField()
        {
            cbSearchField.Properties.Items.Add(DenominacionMonedaBdo.DenominacionMonedaFields.DenominacionMonedaId.ToString());
            cbSearchField.Properties.Items.Add(DenominacionMonedaBdo.DenominacionMonedaFields.Denominacion.ToString());
            cbSearchField.Properties.Items.Add(DenominacionMonedaBdo.DenominacionMonedaFields.Valor.ToString());
            cbSearchField.Properties.Items.Add(DenominacionMonedaBdo.DenominacionMonedaFields.MonedaId.ToString());
        
            cbSearchField.SelectedText = DenominacionMonedaBdo.DenominacionMonedaFields.Denominacion.ToString();
        }

        protected override void InitializeData()
        {
            var dtSearch = from m in new DenominacionMonedaLogic().GetAll()
                where
                    (_denominacionMonedaView.Denominacion.Trim().Length == 0 ||
                     _denominacionMonedaView.Denominacion.Contains(_denominacionMonedaView.Denominacion))
                select m;

            InitializeData(DenominacionMonedaBdo.DenominacionMonedaFields.DenominacionMonedaId.ToString(), DenominacionMonedaBdo.DenominacionMonedaFields.Denominacion.ToString(), Utilities.ToDataTable(dtSearch.ToList()));
        }
    }
}
