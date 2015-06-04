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
    public partial class FormSearchTransferencias : FormSearchTextBox
    {
        private ITransferenciaView _transferenciaView = null;

        public FormSearchTransferencias()
        {
            InitializeComponent();
        }

        public FormSearchTransferencias(ITransferenciaView transferenciaView)
        {
            InitializeComponent();
            _transferenciaView = transferenciaView;
            _KeyType = KeyType.Int;
        }

        protected override void InitializeAppeareance()
        {
            var gcolCodDocumento = gvSearch.Columns.AddField(TransferenciaBdo.TransferenciaFields.CodDocumento.ToString());
            gcolCodDocumento.Caption = "Cód. Transferencia";
            gcolCodDocumento.Visible = true;

            var gcolNroDocumento = gvSearch.Columns.AddField(TransferenciaBdo.TransferenciaFields.NumeroDocumento.ToString());
            gcolNroDocumento.Caption = "numero documento";
            gcolNroDocumento.Visible = true;            

            var gcolOficinaOrigen = gvSearch.Columns.AddField(TransferenciaBdo.TransferenciaFields.OficinaIdProcedencia.ToString());
            gcolOficinaOrigen.Caption = "Of. Procedencia";
            gcolOficinaOrigen.Visible = true;

            var gcolOficinaDestino = gvSearch.Columns.AddField(TransferenciaBdo.TransferenciaFields.OficinaIdDestino.ToString());
            gcolOficinaDestino.Caption = "Of. Destino";
            gcolOficinaDestino.Visible = true;

            var gcolSolicitante = gvSearch.Columns.AddField(TransferenciaBdo.TransferenciaFields.PersonaIdSolicitante.ToString());
            gcolSolicitante.Caption = "Solicitante";
            gcolSolicitante.Visible = true;

            var gcolBeneficiario = gvSearch.Columns.AddField(TransferenciaBdo.TransferenciaFields.PersonaIdBeneficiario.ToString());
            gcolBeneficiario.Caption = "Beneficiario";
            gcolBeneficiario.Visible = true;

            var gcolFechaHoraTransf = gvSearch.Columns.AddField(TransferenciaBdo.TransferenciaFields.FechaHoraTransferencia.ToString());
            gcolFechaHoraTransf.Caption = "Fecha Transf";
            gcolFechaHoraTransf.Visible = true;

            var gcolImporte = gvSearch.Columns.AddField(TransferenciaBdo.TransferenciaFields.Importe.ToString());
            gcolImporte.Caption = "Importe";
            gcolImporte.Visible = true;
        }

        protected override void InitializeSearchField()
        {
            cbSearchField.Properties.Items.Add(TransferenciaBdo.TransferenciaFields.CodDocumento.ToString());
            cbSearchField.Properties.Items.Add(TransferenciaBdo.TransferenciaFields.OficinaIdProcedencia.ToString());
            cbSearchField.Properties.Items.Add(TransferenciaBdo.TransferenciaFields.OficinaIdDestino.ToString());
            cbSearchField.Properties.Items.Add(TransferenciaBdo.TransferenciaFields.PersonaIdSolicitante.ToString());
            cbSearchField.Properties.Items.Add(TransferenciaBdo.TransferenciaFields.PersonaIdBeneficiario.ToString());
            cbSearchField.Properties.Items.Add(TransferenciaBdo.TransferenciaFields.FechaHoraTransferencia.ToString());            

            cbSearchField.SelectedText = TransferenciaBdo.TransferenciaFields.CodDocumento.ToString();
        }

        protected override void InitializeData()
        {
            var dtSearch = from m in new TransferenciaLogic().GetAll()
                           where
                               (_transferenciaView.CodDocumento.Trim().Length == 0 ||
                                _transferenciaView.CodDocumento.Contains(_transferenciaView.CodDocumento))
                               &&
                               (_transferenciaView.OficinaIdProcedencia.Trim().Length == 0 ||
                                _transferenciaView.OficinaIdProcedencia.Contains(_transferenciaView.OficinaIdProcedencia))
                               &&
                               (_transferenciaView.OficinaIdDestino.Trim().Length == 0 ||
                               _transferenciaView.OficinaIdDestino.Contains(_transferenciaView.OficinaIdDestino))
                               &&
                               (_transferenciaView.PersonaIdSolicitante.Trim().Length == 0 ||
                               _transferenciaView.PersonaIdSolicitante.Contains(_transferenciaView.PersonaIdSolicitante))
                               &&
                               (_transferenciaView.PersonaIdBeneficiario.Trim().Length == 0) ||
                               _transferenciaView.PersonaIdBeneficiario.Contains(_transferenciaView.PersonaIdBeneficiario)
                           select m;

            InitializeData(TransferenciaBdo.TransferenciaFields.NumeroDocumento.ToString(), TransferenciaBdo.TransferenciaFields.CodDocumento.ToString(), Utilities.ToDataTable(dtSearch.ToList()));
        }
    }
}
