using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mega.App.Views.Interface;
using Mega.Bdo;
using Mega.Logic.Modules;

namespace Mega.App.Search
{
    public partial class FormSearchMovFondos : Bijcorp.Base.FormSearchTextBox
    {
        private ModMovimientoFondosLogic _modMovimientoFondosLogic = new ModMovimientoFondosLogic();
        private IMovimientoFondosView _movimientoFondosView = null;
        public FormSearchMovFondos()
        {
            InitializeComponent();
        }

        public FormSearchMovFondos(IMovimientoFondosView movimientoFondosView)
        {
            InitializeComponent();
            _movimientoFondosView = movimientoFondosView;
            _KeyType = KeyType.Int;
        }

        protected override void InitializeAppeareance()
        {
            var gcolMovFondosId = gvSearch.Columns.AddField(MovimientoFondosBdo.MovimientoFondosFields.MovimientoFondosId.ToString());
            gcolMovFondosId.Caption = "movFondosId";
            gcolMovFondosId.Visible = false;

            var gcolCodDocumento = gvSearch.Columns.AddField(MovimientoFondosBdo.MovimientoFondosFields.CodDocumento.ToString());
            gcolCodDocumento.Caption = "Cod. Documento";
            gcolCodDocumento.Visible = true;

            var gcolNumeroDocumento = gvSearch.Columns.AddField(MovimientoFondosBdo.MovimientoFondosFields.NumeroDocumento.ToString());
            gcolNumeroDocumento.Caption = "N° Documento";
            gcolNumeroDocumento.Visible = true;

            var gcolOficinaIdProcedencia = gvSearch.Columns.AddField(MovimientoFondosBdo.MovimientoFondosFields.OficinaIdProcedencia.ToString());
            gcolOficinaIdProcedencia.Caption = "Of.Procedencia";
            gcolOficinaIdProcedencia.Visible = true;

            var gcolOficinaIdDestino = gvSearch.Columns.AddField(MovimientoFondosBdo.MovimientoFondosFields.OficinaIdDestino.ToString());
            gcolOficinaIdDestino.Caption = "Of.Destino";
            gcolOficinaIdDestino.Visible = true;            

            var gcolCodigoPersona = gvSearch.Columns.AddField("NombrePersona");
            gcolCodigoPersona.Caption = "NombrePersona";
            gcolCodigoPersona.Visible = true;

            var gcolNombreEntidad = gvSearch.Columns.AddField("NombreEntidad");
            gcolNombreEntidad.Caption = "NombreEntidad";
            gcolNombreEntidad.Visible = true;

            var gcolDirEntidad = gvSearch.Columns.AddField("DirEntidad");
            gcolDirEntidad.Caption = "DirEntidad";
            gcolDirEntidad.Visible = true;
        }

        protected override void InitializeData()
        {

            InitializeData("MovimientoFondosId", "MovimientoFondosId", _modMovimientoFondosLogic.GetSearchMovFondos());
        }

        protected override void InitializeSearchField()
        {
            cbSearchField.Properties.Items.Add(MovimientoFondosBdo.MovimientoFondosFields.CodDocumento.ToString());
            cbSearchField.Properties.Items.Add(MovimientoFondosBdo.MovimientoFondosFields.NumeroDocumento.ToString());
            cbSearchField.Properties.Items.Add(MovimientoFondosBdo.MovimientoFondosFields.OficinaIdProcedencia.ToString());
            cbSearchField.Properties.Items.Add(MovimientoFondosBdo.MovimientoFondosFields.OficinaIdDestino.ToString());
            cbSearchField.Properties.Items.Add("NombrePersona");
            cbSearchField.Properties.Items.Add("NombreEntidad");
            cbSearchField.Properties.Items.Add("DirEntidad");

            cbSearchField.SelectedText = MovimientoFondosBdo.MovimientoFondosFields.NumeroDocumento.ToString();
        }
    }
}
