using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bijcorp.Base;
using Mega.App.Views.Interface;
using Mega.Bdo;
using Mega.Logic;

namespace Mega.App.Search
{
    public partial class FormSearchComprobante : Bijcorp.Base.FormSearchTextBox
    {
        public FormSearchComprobante()
        {
            InitializeComponent();
        }
         private IComprobanteView _comprobanteView;

       

        public FormSearchComprobante(IComprobanteView comprobanteView)
        {
            InitializeComponent();
            _comprobanteView = comprobanteView;
            _KeyType = KeyType.String;
        }

        protected override void InitializeAppeareance()
        {
            var gcol_Comprobante = gvSearch.Columns.AddField(ComprobanteBdo.ComprobanteFields.CodComprobante.ToString());
            gcol_Comprobante.Caption = "CodComprobante";
            gcol_Comprobante.Visible = true;

            var gcol_Nombre = gvSearch.Columns.AddField(ComprobanteBdo.ComprobanteFields.NombreComprobante.ToString());
            gcol_Nombre.Caption = "NombreComprobante";
            gcol_Nombre.Visible = true;

            var gcol_CreditoFiscal = gvSearch.Columns.AddField(ComprobanteBdo.ComprobanteFields.CreditoFiscal.ToString());
            gcol_CreditoFiscal.Caption = "CreditoFiscal";
            gcol_CreditoFiscal.Visible = true;
            
            gvSearch.BestFitColumns();
        }

        protected override void InitializeSearchField()
        {
            cbSearchField.Properties.Items.Add(ComprobanteBdo.ComprobanteFields.CodComprobante.ToString());
            cbSearchField.Properties.Items.Add(ComprobanteBdo.ComprobanteFields.NombreComprobante.ToString());
            cbSearchField.Properties.Items.Add(ComprobanteBdo.ComprobanteFields.CreditoFiscal.ToString());

            cbSearchField.SelectedText = ComprobanteBdo.ComprobanteFields.NombreComprobante.ToString();
        }

        protected override void InitializeData()
        {
            var dtSearch = from m in new ComprobanteLogic().GetAll()
                where
                    (_comprobanteView.CodComprobante.Trim().Length == 0 ||
                     _comprobanteView.CodComprobante.Contains(_comprobanteView.CodComprobante))
                    &&
                    (_comprobanteView.NombreComprobante.Trim().Length == 0 ||
                     _comprobanteView.NombreComprobante.Contains(_comprobanteView.NombreComprobante))
                select m;

            InitializeData(ComprobanteBdo.ComprobanteFields.CodComprobante.ToString(), ComprobanteBdo.ComprobanteFields.NombreComprobante.ToString(), Utilities.ToDataTable(dtSearch.ToList()));
        }
    }
}
