using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bijcorp.Base;
using Mega.App.Presenters;
using Mega.App.Views.Interface;
using Mega.Bdo;
using Mega.Logic;

namespace Mega.App.Views
{
    public partial class MovimientoFondosView : FormBase, IMovimientoFondosView
    {
        private MovimientoFondosPresenter _movimientoFondosPresenter;
        private const string STR_RECIBO_INGRESO = "RI";
        private const string STR_RECIBO_EGRESO = "RE";

        public enum TypeViewFondos
        {
            Ingreso,
            Egreso,
            Central
        }

        readonly TypeViewFondos _typeViewFondos = TypeViewFondos.Central;

        public MovimientoFondosView()
        {
            InitializeComponent();
        }

        public MovimientoFondosView(TypeViewFondos typeViewFondos)
        {
            _typeViewFondos = typeViewFondos;
            InitializeComponent();
        }

        public int MovimientoFondosId { get; set; }
        public int? NumeroDocumento {
            get { return Convert.ToInt32(tbNumeroDocumento.Text); }
            set { tbNumeroDocumento.EditValue = value; }
        }
        public string CodDocumento {
            get { return cbDocumento1.EditValue.ToString(); }
            set { cbDocumento1.EditValue = value; }
        }
        public decimal? Importe {
            get { return Convert.ToDecimal(tbImporte.EditValue); }
            set { tbImporte.EditValue = value; }
        }
        public string OficinaIdProcedencia {
            get { return cbOfProcedencia.EditValue.ToString(); }
            set { cbOfProcedencia.EditValue = value; }
        }
        public string OficinaIdDestino {
            get { return cbOfDestino.EditValue.ToString(); }
            set { cbOfDestino.EditValue = value; }
        }
        public string CodigoPersona {
            get { return tbCodigoPersona.ItemId.ToString(); }
            set { tbCodigoPersona.ItemId = value; }
        }
        public int? BancoId {
            get { return Convert.ToInt32(cbBanco1.EditValue); }
            set { cbBanco1.EditValue = value; }
        }
        public int? NumeroCuentaBanco {
            get { return Convert.ToInt32(cbCuentaBancaria1.EditValue); }
            set { cbCuentaBancaria1.EditValue = value; }
        }
        public string CodigoVoucher {
            get { return tbCodVoucher.Text; }
            set { tbCodVoucher.Text = value; }
        }
        public string NumeroOperacion {
            get { return tbNumOperacion.Text; }
            set { tbNumOperacion.Text = value; }
        }
        public int? CajaAperturaId { get; set; }
        public DateTime? FechaHoraAnulacion { get; set; }
        public int? Estado { get; set; }
        public string UsuarioAnulacion { get; set; }
        public int? ConceptoId { get; set; }
        public int? MonedaId {
            get { return Convert.ToInt32(cbMoneda1.EditValue); }
            set { cbMoneda1.EditValue = value; }
        }
        public int? TipoMovimiento { get; set; }
        public DateTime? FechaHoraTransaccion { get; set; }
        public string CodDocumentoDescargo { get; set; }
        public int? NroDocumentoDescargo { get; set; }
        public DateTime? FechaHoraDescargo { get; set; }
        public bool FlagImpreso { get; set; }
        public string Observacion {
            get { return tbObservacion.Text; }
            set { tbObservacion.Text = value; }
        }

        public BindingList<ReciboCajaBdo> ListRecibos {
            get { return gcRecibos.DataSource as BindingList<ReciboCajaBdo>; }
            set { gcRecibos.DataSource = value; }
        }

        private void MovimientoFondosView_Load(object sender, EventArgs e)
        {
            _movimientoFondosPresenter = new MovimientoFondosPresenter(this, NavigationMainMenu);

            cbOfProcedencia.Bind();
            cbOfDestino.Bind();
            cbBanco1.Bind();
            cbMoneda1.Bind();
            cbDocumento1.Bind();
            tbCodigoPersona.Bind(new PersonaLogic().GetSearchPersona(), SearchButtonEdit.DisplayMember.FieldName);

            if (_typeViewFondos == TypeViewFondos.Ingreso)
            {
                paProcedencia.Visible = true;
                paDestino.Visible = false;
                Text = @"Ingreso de fondos";
                cbDocumento1.EditValue = STR_RECIBO_INGRESO;
            }
            else
            {
                paProcedencia.Visible = false;
                paDestino.Visible = true;
                Text = @"Egreso de fondos";
                cbDocumento1.EditValue = STR_RECIBO_EGRESO;
            }

            cbDocumento1.Enabled = false;
        }

        private void cbDocumento1_EditValueChanged(object sender, EventArgs e)
        {
            _movimientoFondosPresenter.SetNumeroDocumento(_typeViewFondos == TypeViewFondos.Ingreso
                ? STR_RECIBO_INGRESO
                : STR_RECIBO_EGRESO);
        }
    }
}
