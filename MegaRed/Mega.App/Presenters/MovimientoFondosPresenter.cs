using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bijcorp.Base;
using Mega.App.Search;
using Mega.App.Views.Interface;
using Mega.Bdo;
using Mega.Bdo.Modules;
using Mega.Logic;
using Mega.Logic.Modules;

namespace Mega.App.Presenters
{
    public class MovimientoFondosPresenter :GenericPresenter
    {
        private IMovimientoFondosView _movimientoFondosView = null;
        private ModMovimientoFondosBdo _modMovimientoFondosBdo = null;
        private readonly ModMovimientoFondosLogic _modMovimientoFondosLogic = null;
        private readonly FormSearchMovFondos _formSearchMovFondos = null;

        public MovimientoFondosPresenter(IGenericView genericView, INavigationMainMenu navigationMainMenu) : base(genericView, navigationMainMenu)
        {
            _movimientoFondosView = genericView as IMovimientoFondosView;
            _modMovimientoFondosLogic = new ModMovimientoFondosLogic();
            _modMovimientoFondosBdo = new ModMovimientoFondosBdo();
            _formSearchMovFondos = new FormSearchMovFondos();
        }

        protected override void Add()
        {
            var mf = _modMovimientoFondosBdo.MovimientoFondosBdo;

            mf = new MovimientoFondosBdo
            {
                NumeroDocumento = _movimientoFondosView.NumeroDocumento,
                CodDocumento = _movimientoFondosView.CodDocumento,
                Importe = _movimientoFondosView.Importe,
                OficinaIdProcedencia = _movimientoFondosView.OficinaIdProcedencia,
                OficinaIdDestino = _movimientoFondosView.OficinaIdDestino,
                CodigoPersona = _movimientoFondosView.CodigoPersona,
                BancoId = _movimientoFondosView.BancoId,
                NumeroCuentaBanco = _movimientoFondosView.NumeroCuentaBanco,
                CodigoVoucher = _movimientoFondosView.CodigoVoucher,
                NumeroOperacion = _movimientoFondosView.NumeroOperacion,
                CajaAperturaId = _movimientoFondosView.CajaAperturaId,
                ConceptoId = _movimientoFondosView.ConceptoId,
                MonedaId = _movimientoFondosView.MonedaId,
                TipoMovimiento = _movimientoFondosView.TipoMovimiento,
                FechaHoraTransaccion = _movimientoFondosView.FechaHoraTransaccion,
                Observacion = _movimientoFondosView.Observacion
            };
        }

        protected override bool AllRightAdd()
        {
            return base.AllRightAdd();
        }

        protected override bool AllRightUpdate()
        {
            return base.AllRightUpdate();
        }

        protected override void Clear()
        {
            _movimientoFondosView.MovimientoFondosId = 0;
            _movimientoFondosView.NumeroDocumento = null;
            _movimientoFondosView.CodDocumento = null;
            _movimientoFondosView.Importe = null;
            _movimientoFondosView.OficinaIdProcedencia = null;
            _movimientoFondosView.CajaAperturaId = null;
            _movimientoFondosView.FechaHoraAnulacion = null;
            _movimientoFondosView.Estado = null;
            _movimientoFondosView.UsuarioAnulacion = null;
            _movimientoFondosView.ConceptoId = null;
            _movimientoFondosView.MonedaId = null;
            _movimientoFondosView.TipoMovimiento = null;
            _movimientoFondosView.FechaHoraTransaccion = null;
            _movimientoFondosView.CodDocumentoDescargo = null;
            _movimientoFondosView.NroDocumentoDescargo = null;
            _movimientoFondosView.FechaHoraDescargo = null;
            _movimientoFondosView.FlagImpreso = false;
            _movimientoFondosView.Observacion = null;
        }

        protected override DialogResult Search()
        {
            if (_formSearchMovFondos.ShowDialog() == DialogResult.OK)
            {
                var numeroDocumento = _formSearchMovFondos.FieldIdValue ?? 0;

                _modMovimientoFondosBdo = _modMovimientoFondosLogic.GetById(Convert.ToInt32(numeroDocumento));
                var mf = _modMovimientoFondosBdo.MovimientoFondosBdo;

                _movimientoFondosView.MovimientoFondosId = mf.MovimientoFondosId;
                _movimientoFondosView.NumeroDocumento = mf.NumeroDocumento;
                _movimientoFondosView.CodDocumento = mf.CodDocumento;
                _movimientoFondosView.Importe = mf.Importe;
                _movimientoFondosView.OficinaIdProcedencia = mf.OficinaIdProcedencia;
                _movimientoFondosView.OficinaIdDestino = mf.OficinaIdDestino;
                _movimientoFondosView.CodigoPersona = mf.CodigoPersona;
                _movimientoFondosView.BancoId = mf.BancoId;
                _movimientoFondosView.NumeroCuentaBanco = mf.NumeroCuentaBanco;
                _movimientoFondosView.CodigoVoucher = mf.CodigoVoucher;
                _movimientoFondosView.NumeroOperacion = mf.NumeroOperacion;
                _movimientoFondosView.CajaAperturaId = mf.CajaAperturaId;
                _movimientoFondosView.FechaHoraAnulacion = mf.FechaHoraAnulacion;
                _movimientoFondosView.Estado = mf.Estado;
                _movimientoFondosView.UsuarioAnulacion = mf.UsuarioAnulacion;
                _movimientoFondosView.ConceptoId = mf.ConceptoId;
                _movimientoFondosView.MonedaId = mf.MonedaId;
                _movimientoFondosView.TipoMovimiento = mf.TipoMovimiento;
                _movimientoFondosView.FechaHoraTransaccion = mf.FechaHoraTransaccion;
                _movimientoFondosView.CodDocumentoDescargo = mf.CodDocumentoDescargo;
                _movimientoFondosView.NroDocumentoDescargo = mf.NroDocumentoDescargo;
                _movimientoFondosView.FechaHoraDescargo = mf.FechaHoraDescargo;
                _movimientoFondosView.FlagImpreso = mf.FlagImpreso;
                _movimientoFondosView.Observacion = mf.Observacion;

                _movimientoFondosView.ListRecibos = new BindingList<ReciboCajaBdo>(_modMovimientoFondosBdo.ListReciboCaja); ;

                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }

        protected override void Update()
        {
            base.Update();
        }

        public void SetNumeroDocumento(string codDocumento)
        {
            var documento = new DocumentoLogic().GetAllBy(DocumentoBdo.DocumentoFields.CodDocumento, "'" + codDocumento + "'").FirstOrDefault();

            if (documento != null)
                _movimientoFondosView.NumeroDocumento = documento.PrimerDocumento;
        }
    }
}
