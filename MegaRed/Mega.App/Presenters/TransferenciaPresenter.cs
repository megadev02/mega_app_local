using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bijcorp.Base;
using Mega.App.Search;
using Mega.App.Views;
using Mega.App.Views.Interface;
using Mega.Bdo;
using Mega.Logic;

namespace Mega.App.Presenters
{
    public class TransferenciaPresenter : GenericPresenter
    {
        private string _message;
        private TransferenciaLogic _transferenciaLogic;
        private TransferenciaBdo _transferenciaBdo;
        private ITransferenciaView _transferenciaView;
        private FormSearchTransferencias _formSearchTransferencias;
        private DocumentoLogic _documentoLogic;
        private PersonaLogic _personaLogic;

        public TransferenciaPresenter(IGenericView genericView, INavigationMainMenu navigationMainMenu) : base(genericView, navigationMainMenu)
        {
            _transferenciaView = genericView as ITransferenciaView;
            _transferenciaLogic = new TransferenciaLogic();
            _transferenciaBdo = new TransferenciaBdo();
            _formSearchTransferencias = new FormSearchTransferencias(_transferenciaView);
            _documentoLogic = new DocumentoLogic();
            _personaLogic = new PersonaLogic();
        }

        protected override void Add()
        {
            _transferenciaBdo = new TransferenciaBdo()
            {
                NumeroDocumento = _transferenciaView.NumeroDocumento,
                CodDocumento = _transferenciaView.CodDocumento,
                OficinaIdProcedencia = _transferenciaView.OficinaIdProcedencia,
                OficinaIdDestino = _transferenciaView.OficinaIdDestino,
                PersonaIdSolicitante = _transferenciaView.PersonaIdSolicitante,
                PersonaIdBeneficiario = _transferenciaView.PersonaIdBeneficiario,
                FechaHoraTransferencia = _transferenciaView.FechaHoraTransferencia,
                MonedaId = _transferenciaView.MonedaId,
                Importe = _transferenciaView.Importe,
                DerechoTransferencia = _transferenciaView.DerechoTransferencia,
                DerechoTransferenciaArreglo = _transferenciaView.DerechoTransferenciaArreglo,
                ObsTransferencia = _transferenciaView.ObsTransferencia,
                FechaHoraAnulacion = _transferenciaView.FechaHoraAnulacion,
                UsuarioAnulacion = _transferenciaView.UsuarioAnulacion,
                BancoId = _transferenciaView.BancoId,
                NumeroCuentaBanco = _transferenciaView.NumeroCuentaBanco,
                ComisionBancaria = _transferenciaView.ComisionBancaria,
                TipoOperacionBancaria = _transferenciaView.TipoOperacionBancaria,
                CodigoOperacion = _transferenciaView.CodigoOperacion,
                EstadoOperacionBancaria = _transferenciaView.EstadoOperacionBancaria,
                MotivoAnulacion = _transferenciaView.MotivoAnulacion,
                FechaHoraPago = _transferenciaView.FechaHoraPago,
                CodDocumentoPago = _transferenciaView.CodDocumentoPago,
                NroDocumentoPago = _transferenciaView.NroDocumentoPago,
                ObsPagoTransferencia = _transferenciaView.ObsPagoTransferencia,
                Estado = _transferenciaView.Estado,
                FlagImpreso = _transferenciaView.FlagImpreso,
                CajaAperturaId = _transferenciaView.CajaAperturaId,
                TipoTransaccion = _transferenciaView.TipoTransaccion,
                ConceptoId = _transferenciaView.ConceptoId,
                CodigoSeguridad = _transferenciaView.CodigoSeguridad,
                FlagArregloCuenta = _transferenciaView.FlagArregloCuenta,
                FlagChequeo = _transferenciaView.FlagChequeo,
                FechaHoraChequeo = _transferenciaView.FechaHoraChequeo,
                UsuarioChequeo = _transferenciaView.UsuarioChequeo,
                UsuarioArregloCuenta = _transferenciaView.UsuarioArregloCuenta
            };

            if (_transferenciaLogic.Insert(ref _transferenciaBdo, ref _message))
            {
                //actualizar siguiente correlativo
                var documento = _documentoLogic.GetAllBy(DocumentoBdo.DocumentoFields.CodDocumento, "'" + _transferenciaView.CodDocumento + "'").FirstOrDefault();
                if (documento != null)
                {
                    documento.PrimerDocumento++;
                    _documentoLogic.Update(ref documento, ref _message);

                    //solo por prueba se hace el envío directo
                    //el objeto de almacenar en una cola de envío de objetos
                    //donde salen de la cola solo cuando se verificó que llegó a la central                    
                    var transferencia = new CMsgTransferencia
                    {
                        CodOfDestino = _transferenciaBdo.OficinaIdDestino,
                        Solicitante = _personaLogic.GetById(_transferenciaBdo.PersonaIdSolicitante),
                        Beneficiario = _personaLogic.GetById(_transferenciaBdo.PersonaIdBeneficiario),
                        Transferencia = _transferenciaBdo
                    };

                    //hacer dos envios a la central y al destino

                    SocketConexion.Enviar(transferencia);
                }
            }

            MessageBox.Show(_message);
            
        }

        protected override void Update()
        {
            //_transferenciaBdo.NumeroDocumento = _transferenciaView.NumeroDocumento;
            //_transferenciaBdo.CodDocumento = _transferenciaView.CodDocumento;
            //_transferenciaBdo.OficinaIdProcedencia = _transferenciaView.OficinaIdProcedencia;
            //_transferenciaBdo.OficinaIdDestino = _transferenciaView.OficinaIdDestino;
            //_transferenciaBdo.PersonaIdSolicitante = _transferenciaView.PersonaIdSolicitante;
            //_transferenciaBdo.PersonaIdBeneficiario = _transferenciaView.PersonaIdBeneficiario;
            //_transferenciaBdo.FechaHoraTransferencia = _transferenciaView.FechaHoraTransferencia;
            //_transferenciaBdo.MonedaId = _transferenciaView.MonedaId;
            //_transferenciaBdo.Importe = _transferenciaView.Importe;
            //_transferenciaBdo.DerechoTransferencia = _transferenciaView.DerechoTransferencia;
            //_transferenciaBdo.DerechoTransferenciaArreglo = _transferenciaView.DerechoTransferenciaArreglo;
            //_transferenciaBdo.ObsTransferencia = _transferenciaView.ObsTransferencia;
            //_transferenciaBdo.FechaHoraAnulacion = _transferenciaView.FechaHoraAnulacion;
            //_transferenciaBdo.UsuarioAnulacion = _transferenciaView.UsuarioAnulacion;
            //_transferenciaBdo.BancoId = _transferenciaView.BancoId;
            //_transferenciaBdo.NumeroCuentaBanco = _transferenciaView.NumeroCuentaBanco;
            //_transferenciaBdo.ComisionBancaria = _transferenciaView.ComisionBancaria;
            //_transferenciaBdo.TipoOperacionBancaria = _transferenciaView.TipoOperacionBancaria;
            //_transferenciaBdo.CodigoOperacion = _transferenciaView.CodigoOperacion;
            //_transferenciaBdo.EstadoOperacionBancaria = _transferenciaView.EstadoOperacionBancaria;
            //_transferenciaBdo.MotivoAnulacion = _transferenciaView.MotivoAnulacion;
            //_transferenciaBdo.FechaHoraPago = _transferenciaView.FechaHoraPago;
            //_transferenciaBdo.CodDocumentoPago = _transferenciaView.CodDocumentoPago;
            //_transferenciaBdo.NroDocumentoPago = _transferenciaView.NroDocumentoPago;
            //_transferenciaBdo.ObsPagoTransferencia = _transferenciaView.ObsPagoTransferencia;
            //_transferenciaBdo.Estado = _transferenciaView.Estado;
            //_transferenciaBdo.FlagImpreso = _transferenciaView.FlagImpreso;
            //_transferenciaBdo.CajaAperturaId = _transferenciaView.CajaAperturaId;
            //_transferenciaBdo.TipoTransaccion = _transferenciaView.TipoTransaccion;
            //_transferenciaBdo.ConceptoId = _transferenciaView.ConceptoId;
            //_transferenciaBdo.CodigoSeguridad = _transferenciaView.CodigoSeguridad;
            //_transferenciaBdo.FlagArregloCuenta = _transferenciaView.FlagArregloCuenta;
            //_transferenciaBdo.FlagChequeo = _transferenciaView.FlagChequeo;
            //_transferenciaBdo.FechaHoraChequeo = _transferenciaView.FechaHoraChequeo;
            //_transferenciaBdo.UsuarioChequeo = _transferenciaView.UsuarioChequeo;            		
            //_transferenciaBdo.UsuarioArregloCuenta = _transferenciaView.UsuarioArregloCuenta;

            //_transferenciaLogic.Update(ref _transferenciaBdo, ref _message);

            //MessageBox.Show(_message);
        }

        protected override bool AllRightAdd()
        {
            if (_transferenciaView.CodDocumento.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'cod documento' no puede ser vacio.");
                return false;
            }
            if (_transferenciaView.OficinaIdProcedencia.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Oficina procedencia' no puede ser vacio.");
                return false;
            }
            if (_transferenciaView.OficinaIdDestino.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Oficina destino' no puede ser vacio.");
                return false;
            }
            if (_transferenciaView.PersonaIdSolicitante.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Persona solicitante' no puede ser vacio.");
                return false;
            }
            if (_transferenciaView.PersonaIdBeneficiario.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Persona beneficiario' no puede ser vacio.");
                return false;
            }
            if (_transferenciaView.Importe <= 0)
            {
                MessageBox.Show("El campo 'Importe' no es válido.");
                return false;
            }
            return true;
        }

        protected override bool AllRightUpdate()
        {
            return base.AllRightAdd();
        }

        protected override void Clear()
        {
            _transferenciaView.NumeroDocumento = 0;
            _transferenciaView.CodDocumento = null;
            _transferenciaView.OficinaIdProcedencia = null;
            _transferenciaView.OficinaIdDestino = null;
            _transferenciaView.PersonaIdSolicitante = null;
            _transferenciaView.PersonaIdBeneficiario = null;
            _transferenciaView.FechaHoraTransferencia = DateTime.Now;
            _transferenciaView.MonedaId = 0;            
            _transferenciaView.Importe = 0;
            _transferenciaView.DerechoTransferencia = 0;
            _transferenciaView.DerechoTransferenciaArreglo = 0;
            _transferenciaView.ObsTransferencia = null;
            _transferenciaView.FechaHoraAnulacion = null;
            _transferenciaView.UsuarioAnulacion = null;
            _transferenciaView.BancoId = null;
            _transferenciaView.NumeroCuentaBanco = null;
            _transferenciaView.ComisionBancaria = null;
            _transferenciaView.TipoOperacionBancaria = 0;
            _transferenciaView.CodigoOperacion = null;
            _transferenciaView.EstadoOperacionBancaria = 0;
            _transferenciaView.MotivoAnulacion = null;
            _transferenciaView.FechaHoraPago = null;
            _transferenciaView.CodDocumentoPago = null;
            _transferenciaView.NroDocumentoPago = 0;
            _transferenciaView.ObsPagoTransferencia = null;
            _transferenciaView.Estado = null;
            _transferenciaView.FlagImpreso = null;
            _transferenciaView.CajaAperturaId = null;
            _transferenciaView.TipoTransaccion = null;
            _transferenciaView.ConceptoId = null;
            _transferenciaView.CodigoSeguridad = "";
            _transferenciaView.FlagArregloCuenta = false;
            _transferenciaView.FlagChequeo = false;
            _transferenciaView.FechaHoraChequeo = null;
            _transferenciaView.UsuarioChequeo = null;
            _transferenciaView.UsuarioArregloCuenta = null;
        }

        protected override DialogResult Search()
        {
            if (_formSearchTransferencias.ShowDialog() == DialogResult.OK)
            {
                var numeroDocumento = _formSearchTransferencias.FieldIdValue ?? 0;

                _transferenciaBdo = _transferenciaLogic.GetById(Convert.ToInt32(numeroDocumento));
                _transferenciaView.NumeroDocumento = _transferenciaBdo.NumeroDocumento;
                _transferenciaView.CodDocumento = _transferenciaBdo.CodDocumento;
                _transferenciaView.OficinaIdProcedencia = _transferenciaBdo.OficinaIdProcedencia;
                _transferenciaView.OficinaIdDestino = _transferenciaBdo.OficinaIdDestino;
                _transferenciaView.PersonaIdSolicitante = _transferenciaBdo.PersonaIdSolicitante;
                _transferenciaView.PersonaIdBeneficiario = _transferenciaBdo.PersonaIdBeneficiario;
                _transferenciaView.Importe = _transferenciaBdo.Importe;
                _transferenciaView.FechaHoraTransferencia = _transferenciaBdo.FechaHoraTransferencia;

                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }

        public void SetNumeroDocumento(string codDocumento)
        {
            var documento = new DocumentoLogic().GetAllBy(DocumentoBdo.DocumentoFields.CodDocumento, "'"+codDocumento+"'").FirstOrDefault();
            
            if (documento != null)
                _transferenciaView.NumeroDocumento = documento.PrimerDocumento;
        }
    }
}
