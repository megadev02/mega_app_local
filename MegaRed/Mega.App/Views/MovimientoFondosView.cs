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
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Mega.App.Presenters;
using Mega.App.Views.Interface;
using Mega.Bdo;
using Mega.Comun;
using Mega.Logic;

namespace Mega.App.Views
{
    public partial class MovimientoFondosView : FormBase, IMovimientoFondosView
    {
        private MovimientoFondosPresenter _movimientoFondosPresenter;
        
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
            get
            {
                if (_typeViewFondos == TypeViewFondos.Egreso)
                {
                    return CUtil.MiBase;
                }
                return cbOfProcedencia.EditValue.ToString();
            }
            set { cbOfProcedencia.EditValue = value; }
        }
        public string OficinaIdDestino {
            get
            {
                if (_typeViewFondos == TypeViewFondos.Ingreso)
                {
                    return CUtil.MiBase;
                }                
                return cbOfDestino.EditValue.ToString();
            }
            set { cbOfDestino.EditValue = value; }
        }
        public string CodigoPersona {
            get { return tbCodigoPersona.ItemId == null ? null : Convert.ToString(tbCodigoPersona.ItemId); } 
            set { tbCodigoPersona.ItemId = value; }
        }
        public int? BancoId {
            get { return cbBanco1.EditValue == null ? Utilities.NullInt32 : Convert.ToInt32(cbBanco1.EditValue); }
            set { cbBanco1.EditValue = value; }
        }
        public int? NumeroCuentaBanco {
            get { return cbCuentaBancaria1.EditValue == null ? Utilities.NullInt32 : Convert.ToInt32(cbCuentaBancaria1.EditValue); }
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
            tbCodigoPersona.Bind(new PersonaLogic().GetSearchPersona(), SearchButtonEdit.DisplayMember.FieldName);            

            if (_typeViewFondos == TypeViewFondos.Ingreso)
            {
                paProcedencia.Visible = true;
                paDestino.Visible = false;
                Text = @"Ingreso de fondos";
                cbDocumento1.Bind(Constantes.MODULE_INGRESO_FONDOS);                              
            }
            else
            {
                paProcedencia.Visible = false;
                paDestino.Visible = true;
                Text = @"Egreso de fondos";
                cbDocumento1.Bind(Constantes.MODULE_EGRESO_FONDOS);
            }
            
            cbMoneda1.ItemIndex = 0;
        }

        private void cbDocumento1_EditValueChanged(object sender, EventArgs e)
        {
            if (cbDocumento1.EditValue != null)
                _movimientoFondosPresenter.SetNumeroDocumento(cbDocumento1.EditValue.ToString());
        }

        private void cbCuentaBancaria1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                MessageBox.Show("cuenta bancaria");
            }
        }

        private void repMostrar_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var reciboCajaBdo = gvRecibos.GetRow(gvRecibos.FocusedRowHandle) as ReciboCajaBdo;

            if (reciboCajaBdo == null) return;

            _movimientoFondosPresenter.MostrarReciboCajaSeleccionado(reciboCajaBdo);
        }

        private void gcRecibos_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                _movimientoFondosPresenter.AddReciboCaja();

                e.Handled = true;
            }
        }
    }
}
