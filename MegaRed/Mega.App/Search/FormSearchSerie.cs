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
    public partial class FormSearchSerie : Bijcorp.Base.FormSearchTextBox
    {
        public FormSearchSerie()
        {
            InitializeComponent();
        }
         private ISerieView _serieView;

        public FormSearchSerie(ISerieView serieView)
        {
            InitializeComponent();
            _serieView = serieView;
            _KeyType = KeyType.Int;
        }

        protected override void InitializeAppeareance()
        {
            var gcol_SerieId = gvSearch.Columns.AddField(SerieBdo.SerieFields.SerieId.ToString());
            gcol_SerieId.Caption = "SerieId";
            gcol_SerieId.Visible = true;

            var gcol_CodComprobante = gvSearch.Columns.AddField(SerieBdo.SerieFields.CodComprobante.ToString());
            gcol_CodComprobante.Caption = "CodComprobante";
            gcol_CodComprobante.Visible = true;

            var gcol_NumeroSerie = gvSearch.Columns.AddField(SerieBdo.SerieFields.NumeroSerie.ToString());
            gcol_NumeroSerie.Caption = "NumeroSerie";
            gcol_NumeroSerie.Visible = true;

            var gcol_CodigoOficina = gvSearch.Columns.AddField(SerieBdo.SerieFields.CodigoOficina.ToString());
            gcol_CodigoOficina.Caption = "CodigoOficina";
            gcol_CodigoOficina.Visible = true;

          
            gvSearch.BestFitColumns();
        }

        protected override void InitializeSearchField()
        {
            cbSearchField.Properties.Items.Add(SerieBdo.SerieFields.SerieId.ToString());
            cbSearchField.Properties.Items.Add(SerieBdo.SerieFields.CodComprobante.ToString());
            cbSearchField.Properties.Items.Add(SerieBdo.SerieFields.NumeroSerie.ToString());
            cbSearchField.Properties.Items.Add(SerieBdo.SerieFields.CodigoOficina.ToString());
          
            

            cbSearchField.SelectedText = SerieBdo.SerieFields.CodComprobante.ToString();
        }

        protected override void InitializeData()
        {
            var dtSearch = from m in new SerieLogic().GetAll()
                where
                    (_serieView.CodComprobante.Trim().Length == 0 ||
                     _serieView.CodComprobante.Contains(_serieView.CodComprobante))
                select m;

            InitializeData(SerieBdo.SerieFields.SerieId.ToString(), SerieBdo.SerieFields.CodComprobante.ToString(), Utilities.ToDataTable(dtSearch.ToList()));
        }
    }
}
