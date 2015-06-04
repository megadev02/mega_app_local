using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Bijcorp.Base;
using Mega.App.Presenters;
using Mega.App.Views.Interface;
using Mega.Logic;

namespace Mega.App.Views
{
    public partial class TransferenciaView : FormBase, ITransferenciaView
    {        
        private TransferenciaPresenter _transferenciaPresenter;
        public TransferenciaView()
        {
            InitializeComponent();
        }

        public TipoShowView TipoView { get; set; }
        
        public int NumeroDocumento {
            get { return Convert.ToInt32(tbNumeroDocumento.Text); }
            set { tbNumeroDocumento.EditValue = value; }
        }

        public string CodDocumento
        {
            get { return cbDocumento1.Text; }
            set { cbDocumento1.EditValue = value; }
        }
        
        public string OficinaIdProcedencia {
            get { return Convert.ToString(cbOficinaOrigen.EditValue); }
            set { cbOficinaOrigen.EditValue = value; }
        }
        public string OficinaIdDestino {
            get { return Convert.ToString(cbOficinaDestino.EditValue); }
            set { cbOficinaDestino.EditValue = value; }
        }

        public string PersonaIdSolicitante {
            get { return tbSolicitante.ItemId.ToString(); }
            set { tbSolicitante.ItemId = value; }
        }
        
        public string PersonaIdBeneficiario {
            get { return tbBeneficiario.ItemId.ToString(); }
            set { tbBeneficiario.ItemId = value; }
        }
        
        public DateTime? FechaHoraTransferencia {
            get { return deFechaTransf.DateTime; }
            set { deFechaTransf.EditValue = value; }
        }
        
        public int MonedaId {
            get { return Convert.ToInt32(cbMoneda1.EditValue); }
            set { cbMoneda1.EditValue = value; }
        }
        public decimal Importe {
            get { return Convert.ToDecimal(tbImporte.EditValue); }
            set { tbImporte.EditValue = value; }
        }

        public decimal DerechoTransferencia { get; set; }
        public decimal DerechoTransferenciaArreglo { get; set; }
        public string ObsTransferencia { get; set; }
        public DateTime? FechaHoraAnulacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public int? BancoId { get; set; }
        public string NumeroCuentaBanco { get; set; }
        public decimal? ComisionBancaria { get; set; }
        public int? TipoOperacionBancaria { get; set; }
        public string CodigoOperacion { get; set; }
        public int? EstadoOperacionBancaria { get; set; }
        public string MotivoAnulacion { get; set; }
        public DateTime? FechaHoraPago { get; set; }
        public string CodDocumentoPago { get; set; }
        public int? NroDocumentoPago { get; set; }
        public string ObsPagoTransferencia { get; set; }
        public int? Estado { get; set; }
        public bool? FlagImpreso { get; set; }
        public int? CajaAperturaId { get; set; }
        public int? TipoTransaccion { get; set; }
        public int? ConceptoId { get; set; }
        public string CodigoSeguridad { get; set; }
        public bool FlagArregloCuenta { get; set; }
        public bool FlagChequeo { get; set; }
        public DateTime? FechaHoraChequeo { get; set; }
        public string UsuarioChequeo { get; set; }
        public string UsuarioArregloCuenta { get; set; }

        private void TransferenciaView_Load(object sender, EventArgs e)
        {
            cbMoneda1.Bind();
            cbOficinaOrigen.Bind();
            cbOficinaDestino.Bind();
            cbDocumento1.Bind();
            
            tbSolicitante.Bind(new PersonaLogic().GetAll().Select(x => new ItemTextList()
            {         
                Id = x.CodigoPersona,
                Code = x.CodigoPersona,
                Name = x.ApellidoPaterno + " " + x.ApellidoMaterno+ " "+ x.PrimerNombre+" "+x.SegundoNombre
            }).ToList(), SearchButtonEdit.DisplayMember.FieldName);

            tbBeneficiario.Bind(new PersonaLogic().GetAll().Select(x => new ItemTextList()
            {
                Id = x.CodigoPersona,
                Code = x.CodigoPersona,
                Name = x.ApellidoPaterno + " " + x.ApellidoMaterno + " " + x.PrimerNombre + " " + x.SegundoNombre
            }).ToList(), SearchButtonEdit.DisplayMember.FieldName);

            _transferenciaPresenter = new TransferenciaPresenter(this, NavigationMainMenu);

            //focus
            cbMoneda1.ItemIndex = 0;
            cbDocumento1.ItemIndex = 0;
            deFechaTransf.DateTime = DateTime.Now;
        }

        private void cbDocumento1_EditValueChanged(object sender, EventArgs e)
        {
            _transferenciaPresenter.SetNumeroDocumento(CodDocumento);
        }        
    }
}
