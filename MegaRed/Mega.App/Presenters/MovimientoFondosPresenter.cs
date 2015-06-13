using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bijcorp.Base;
using Mega.App.Search;
using Mega.App.Views;
using Mega.App.Views.Interface;
using Mega.Bdo;
using Mega.Bdo.Modules;
using Mega.Logic;
using Mega.Logic.Modules;

namespace Mega.App.Presenters
{
    public class MovimientoFondosPresenter :GenericPresenter
    {
        private string _message;
        private IMovimientoFondosView _movimientoFondosView = null;
        private ModMovimientoFondosBdo _modMovimientoFondosBdo = null;
        private readonly ModMovimientoFondosLogic _modMovimientoFondosLogic = null;
        private readonly DocumentoLogic _documentoLogic = null;
        private readonly FormSearchMovFondos _formSearchMovFondos = null;

        public MovimientoFondosPresenter(IGenericView genericView, INavigationMainMenu navigationMainMenu) : base(genericView, navigationMainMenu)
        {
            _movimientoFondosView = genericView as IMovimientoFondosView;
            _modMovimientoFondosLogic = new ModMovimientoFondosLogic();
            _modMovimientoFondosBdo = new ModMovimientoFondosBdo();
            _formSearchMovFondos = new FormSearchMovFondos();
            _modMovimientoFondosBdo.ListReciboCaja = new List<ReciboCajaBdo>();
            _movimientoFondosView.ListRecibos = new BindingList<ReciboCajaBdo>(_modMovimientoFondosBdo.ListReciboCaja);
        }

        protected override void Add()
        {                        
            _modMovimientoFondosBdo.MovimientoFondosBdo = new MovimientoFondosBdo
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

            _modMovimientoFondosBdo.ListReciboCaja = _movimientoFondosView.ListRecibos.ToList();

            if (_modMovimientoFondosLogic.Insert(ref _modMovimientoFondosBdo, ref _message))
            {
                //actualizar siguiente correlativo
                var documento = _documentoLogic.GetAllBy(DocumentoBdo.DocumentoFields.CodDocumento, "'" + _modMovimientoFondosBdo.MovimientoFondosBdo.CodDocumento + "'").FirstOrDefault();
                if (documento != null)
                {
                    documento.PrimerDocumento++;
                    _documentoLogic.Update(ref documento, ref _message);

                    //solo por prueba se hace el envío directo
                    //el objeto de almacenar en una cola de envío de objetos
                    //donde salen de la cola solo cuando se verificó que llegó a la central                    
                    //var transferencia = new CMsgTransferencia
                    //{
                    //    CodOfDestino = _transferenciaBdo.OficinaIdDestino,
                    //    Solicitante = _personaLogic.GetById(_transferenciaBdo.PersonaIdSolicitante),
                    //    Beneficiario = _personaLogic.GetById(_transferenciaBdo.PersonaIdBeneficiario),
                    //    Transferencia = _transferenciaBdo
                    //};

                    //hacer dos envios a la central y al destino

                    //SocketConexion.Enviar(transferencia);
                }
            }

            MessageBox.Show(_message);
        }

        protected override bool AllRightAdd()
        {
            if (_movimientoFondosView.NumeroDocumento == 0)
            {
                MessageBox.Show(@"El campo número de documento no puede ser vacio.");
                return false;
            }
            if (_movimientoFondosView.CodDocumento == null)
            {
                MessageBox.Show(@"El campo cod documento no pueder ser vacio.");
                return false;
            }
            if (_movimientoFondosView.Importe <= 0)
            {
                MessageBox.Show(@"El campo importe no puede ser menor que cero.");
                return false;
            }
            if (_movimientoFondosView.OficinaIdProcedencia == null)
            {
                MessageBox.Show(@"El campo oficina procedencia no puede ser vacio.");
                return false;
            }
            if (_movimientoFondosView.OficinaIdDestino == null)
            {
                MessageBox.Show(@"El campo oficina destino no puede ser vacio.");
                return false;
            }
            if (_movimientoFondosView.CodigoPersona == null && _movimientoFondosView.BancoId == null)
            {
                MessageBox.Show(@"No se especificó la forma de envio de fondos(Personal|Banco).");
                return false;
            }
            if (_movimientoFondosView.BancoId != null && _movimientoFondosView.NumeroCuentaBanco == null)
            {
                MessageBox.Show(@"No se especificó el número de cuenta del banco.");
                return false;
            }
            //if (_movimientoFondosView.CajaAperturaId == null)
            //{
            //    MessageBox.Show(@"El campo Caja apertura id no puede ser vacio.");
            //    return false;
            //}
            return true;
        }

        protected override bool AllRightUpdate()
        {
            return AllRightAdd();
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
                _movimientoFondosView.MovimientoFondosId = Convert.ToInt32(_formSearchMovFondos.FieldIdValue ?? 0);
                
                Retrieve();

                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }

        protected override void Update()
        {
            base.Update();
        }

        protected override void Retrieve()
        {
            _modMovimientoFondosBdo = _modMovimientoFondosLogic.GetById(Convert.ToInt32(_movimientoFondosView.MovimientoFondosId));
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
        }

        public void SetNumeroDocumento(string codDocumento)
        {
            var documento = new DocumentoLogic().GetAllBy(DocumentoBdo.DocumentoFields.CodDocumento, "'" + codDocumento + "'").FirstOrDefault();

            if (documento != null)
                _movimientoFondosView.NumeroDocumento = documento.PrimerDocumento;
        }

        public void AddReciboCaja()
        {
            var reciboIngEgr = new ReciboIngresoEgresoView();
            if (reciboIngEgr.ShowDialog() == DialogResult.OK)
            {
                //refrescar tabla de recibos de ingresos y egresos
                var reciboCajaView = reciboIngEgr as IReciboCajaView;                

                _modMovimientoFondosBdo.ListReciboCaja.Add(new ReciboCajaBdo
                {
                    ReciboCajaId = reciboCajaView.ReciboCajaId,
                    CodDocumento = reciboCajaView.CodDocumento,
                    NumeroDocumento = reciboCajaView.NumeroDocumento,
                    Concepto = reciboCajaView.Concepto,
                    Importe = reciboCajaView.Importe,
                    MovimientoFondosId = _modMovimientoFondosBdo.MovimientoFondosBdo.MovimientoFondosId
                });

                _movimientoFondosView.ListRecibos = new BindingList<ReciboCajaBdo>(_modMovimientoFondosBdo.ListReciboCaja);
            }
        }

        public void MostrarReciboCajaSeleccionado(ReciboCajaBdo reciboCajaBdo)
        {
            //pasar como parametro el campo ReciboCajaId
            var reciboIngEgr = new ReciboIngresoEgresoView();
            var reciboCajaView = reciboIngEgr as IReciboCajaView;
            reciboIngEgr.ReciboCajaId = reciboCajaBdo.ReciboCajaId;

            if (reciboIngEgr.ShowDialog() == DialogResult.OK)
            {
                //refrescar tabla de recibos de ingresos y egresos
                
            }
        }
    }
}
