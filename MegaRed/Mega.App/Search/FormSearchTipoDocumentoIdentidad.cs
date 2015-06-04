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
    public partial class FormSearchTipoDocumentoIdentidad : FormSearchTextBox
    {
        public FormSearchTipoDocumentoIdentidad()
        {
            InitializeComponent();
        }
          private ITipoDocumentoIdentidadView _tipoDocumentoIdentidadViewnedaView;

        public FormSearchTipoDocumentoIdentidad(ITipoDocumentoIdentidadView tipoDocumentoIdentidadView)
        {
            InitializeComponent();
            _tipoDocumentoIdentidadViewnedaView = tipoDocumentoIdentidadView;
            _KeyType = KeyType.String;
        }

        protected override void InitializeAppeareance()
        {
            var gcol_TipoDocumentoId = gvSearch.Columns.AddField(TipoDocumentoIdentidadBdo.TipoDocumentoIdentidadFields.TipoDocumentoId.ToString());
            gcol_TipoDocumentoId.Caption = "TipoDocumentoId";
            gcol_TipoDocumentoId.Visible = true;

            var gcol_Abreviatura = gvSearch.Columns.AddField(TipoDocumentoIdentidadBdo.TipoDocumentoIdentidadFields.Abreviatura.ToString());
            gcol_Abreviatura.Caption = "Abreviatura";
            gcol_Abreviatura.Visible = true;

            var gcol_Denominacion = gvSearch.Columns.AddField(TipoDocumentoIdentidadBdo.TipoDocumentoIdentidadFields.Denominacion.ToString());
            gcol_Denominacion.Caption = "Denominación";
            gcol_Denominacion.Visible = true;
            gvSearch.BestFitColumns();
        }

        protected override void InitializeSearchField()
        {
            cbSearchField.Properties.Items.Add(TipoDocumentoIdentidadBdo.TipoDocumentoIdentidadFields.TipoDocumentoId.ToString());
            cbSearchField.Properties.Items.Add(TipoDocumentoIdentidadBdo.TipoDocumentoIdentidadFields.Abreviatura.ToString());
            cbSearchField.Properties.Items.Add(TipoDocumentoIdentidadBdo.TipoDocumentoIdentidadFields.Denominacion.ToString());
            cbSearchField.SelectedText = TipoDocumentoIdentidadBdo.TipoDocumentoIdentidadFields.Abreviatura.ToString();
        }

        protected override void InitializeData()
        {
            var dtSearch = from m in new TipoDocumentoIdentidadLogic().GetAll()
                where
                    (_tipoDocumentoIdentidadViewnedaView.Denominacion.Trim().Length == 0 ||
                     _tipoDocumentoIdentidadViewnedaView.Denominacion.Contains(_tipoDocumentoIdentidadViewnedaView.Denominacion))
                select m;

            InitializeData(TipoDocumentoIdentidadBdo.TipoDocumentoIdentidadFields.TipoDocumentoId.ToString(),
                           TipoDocumentoIdentidadBdo.TipoDocumentoIdentidadFields.Denominacion.ToString(),
                           Utilities.ToDataTable(dtSearch.ToList()));
        }
    }
}
