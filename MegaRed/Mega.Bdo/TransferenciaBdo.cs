using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class TransferenciaBdo : BdoObjectBase
	{

		#region InnerClass
		public enum TransferenciaFields
		{
			TransferenciaId,
			NumeroDocumento,
			CodDocumento,
			OficinaIdProcedencia,
			OficinaIdDestino,
			PersonaIdSolicitante,
			PersonaIdBeneficiario,
			FechaHoraTransferencia,
			MonedaId,
			Importe,
			DerechoTransferencia,
			DerechoTransferenciaArreglo,
			ObsTransferencia,
			FechaHoraAnulacion,
			UsuarioAnulacion,
			BancoId,
			NumeroCuentaBanco,
			ComisionBancaria,
			TipoOperacionBancaria,
			CodigoOperacion,
			EstadoOperacionBancaria,
			MotivoAnulacion,
			FechaHoraPago,
			CodDocumentoPago,
			NroDocumentoPago,
			ObsPagoTransferencia,
			Estado,
			FlagImpreso,
			CajaAperturaId,
			TipoTransaccion,
			ConceptoId,
			CodigoSeguridad,
			FlagArregloCuenta,
			FlagChequeo,
			FechaHoraChequeo,
			UsuarioChequeo,
			UsuarioArregloCuenta
		}
		#endregion

		#region Data Members

			int _transferenciaId;
			int _numeroDocumento;
			string _codDocumento;
			string _oficinaIdProcedencia;
			string _oficinaIdDestino;
			string _personaIdSolicitante;
			string _personaIdBeneficiario;
			DateTime? _fechaHoraTransferencia;
			int _monedaId;
			decimal _importe;
			decimal _derechoTransferencia;
			decimal _derechoTransferenciaArreglo;
			string _obsTransferencia;
			DateTime? _fechaHoraAnulacion;
			string _usuarioAnulacion;
			int? _bancoId;
			string _numeroCuentaBanco;
			decimal? _comisionBancaria;
			int? _tipoOperacionBancaria;
			string _codigoOperacion;
			int? _estadoOperacionBancaria;
			string _motivoAnulacion;
			DateTime? _fechaHoraPago;
			string _codDocumentoPago;
			int? _nroDocumentoPago;
			string _obsPagoTransferencia;
			int? _estado;
			bool? _flagImpreso;
			int? _cajaAperturaId;
			int? _tipoTransaccion;
			int? _conceptoId;
			string _codigoSeguridad;
			bool _flagArregloCuenta;
			bool _flagChequeo;
			DateTime? _fechaHoraChequeo;
			string _usuarioChequeo;
			string _usuarioArregloCuenta;

		#endregion

		#region Properties

		public int  TransferenciaId
		{
			 get { return _transferenciaId; }
			 set
			 {
				 if (_transferenciaId != value)
				 {
					_transferenciaId = value;
					 PropertyHasChanged("TransferenciaId");
				 }
			 }
		}

		public int  NumeroDocumento
		{
			 get { return _numeroDocumento; }
			 set
			 {
				 if (_numeroDocumento != value)
				 {
					_numeroDocumento = value;
					 PropertyHasChanged("NumeroDocumento");
				 }
			 }
		}

		public string  CodDocumento
		{
			 get { return _codDocumento; }
			 set
			 {
				 if (_codDocumento != value)
				 {
					_codDocumento = value;
					 PropertyHasChanged("CodDocumento");
				 }
			 }
		}

		public string  OficinaIdProcedencia
		{
			 get { return _oficinaIdProcedencia; }
			 set
			 {
				 if (_oficinaIdProcedencia != value)
				 {
					_oficinaIdProcedencia = value;
					 PropertyHasChanged("OficinaIdProcedencia");
				 }
			 }
		}

		public string  OficinaIdDestino
		{
			 get { return _oficinaIdDestino; }
			 set
			 {
				 if (_oficinaIdDestino != value)
				 {
					_oficinaIdDestino = value;
					 PropertyHasChanged("OficinaIdDestino");
				 }
			 }
		}

		public string  PersonaIdSolicitante
		{
			 get { return _personaIdSolicitante; }
			 set
			 {
				 if (_personaIdSolicitante != value)
				 {
					_personaIdSolicitante = value;
					 PropertyHasChanged("PersonaIdSolicitante");
				 }
			 }
		}

		public string  PersonaIdBeneficiario
		{
			 get { return _personaIdBeneficiario; }
			 set
			 {
				 if (_personaIdBeneficiario != value)
				 {
					_personaIdBeneficiario = value;
					 PropertyHasChanged("PersonaIdBeneficiario");
				 }
			 }
		}

		public DateTime?  FechaHoraTransferencia
		{
			 get { return _fechaHoraTransferencia; }
			 set
			 {
				 if (_fechaHoraTransferencia != value)
				 {
					_fechaHoraTransferencia = value;
					 PropertyHasChanged("FechaHoraTransferencia");
				 }
			 }
		}

		public int  MonedaId
		{
			 get { return _monedaId; }
			 set
			 {
				 if (_monedaId != value)
				 {
					_monedaId = value;
					 PropertyHasChanged("MonedaId");
				 }
			 }
		}

		public decimal  Importe
		{
			 get { return _importe; }
			 set
			 {
				 if (_importe != value)
				 {
					_importe = value;
					 PropertyHasChanged("Importe");
				 }
			 }
		}

		public decimal  DerechoTransferencia
		{
			 get { return _derechoTransferencia; }
			 set
			 {
				 if (_derechoTransferencia != value)
				 {
					_derechoTransferencia = value;
					 PropertyHasChanged("DerechoTransferencia");
				 }
			 }
		}

		public decimal  DerechoTransferenciaArreglo
		{
			 get { return _derechoTransferenciaArreglo; }
			 set
			 {
				 if (_derechoTransferenciaArreglo != value)
				 {
					_derechoTransferenciaArreglo = value;
					 PropertyHasChanged("DerechoTransferenciaArreglo");
				 }
			 }
		}

		public string  ObsTransferencia
		{
			 get { return _obsTransferencia; }
			 set
			 {
				 if (_obsTransferencia != value)
				 {
					_obsTransferencia = value;
					 PropertyHasChanged("ObsTransferencia");
				 }
			 }
		}

		public DateTime?  FechaHoraAnulacion
		{
			 get { return _fechaHoraAnulacion; }
			 set
			 {
				 if (_fechaHoraAnulacion != value)
				 {
					_fechaHoraAnulacion = value;
					 PropertyHasChanged("FechaHoraAnulacion");
				 }
			 }
		}

		public string  UsuarioAnulacion
		{
			 get { return _usuarioAnulacion; }
			 set
			 {
				 if (_usuarioAnulacion != value)
				 {
					_usuarioAnulacion = value;
					 PropertyHasChanged("UsuarioAnulacion");
				 }
			 }
		}

		public int?  BancoId
		{
			 get { return _bancoId; }
			 set
			 {
				 if (_bancoId != value)
				 {
					_bancoId = value;
					 PropertyHasChanged("BancoId");
				 }
			 }
		}

		public string  NumeroCuentaBanco
		{
			 get { return _numeroCuentaBanco; }
			 set
			 {
				 if (_numeroCuentaBanco != value)
				 {
					_numeroCuentaBanco = value;
					 PropertyHasChanged("NumeroCuentaBanco");
				 }
			 }
		}

		public decimal?  ComisionBancaria
		{
			 get { return _comisionBancaria; }
			 set
			 {
				 if (_comisionBancaria != value)
				 {
					_comisionBancaria = value;
					 PropertyHasChanged("ComisionBancaria");
				 }
			 }
		}

		public int?  TipoOperacionBancaria
		{
			 get { return _tipoOperacionBancaria; }
			 set
			 {
				 if (_tipoOperacionBancaria != value)
				 {
					_tipoOperacionBancaria = value;
					 PropertyHasChanged("TipoOperacionBancaria");
				 }
			 }
		}

		public string  CodigoOperacion
		{
			 get { return _codigoOperacion; }
			 set
			 {
				 if (_codigoOperacion != value)
				 {
					_codigoOperacion = value;
					 PropertyHasChanged("CodigoOperacion");
				 }
			 }
		}

		public int?  EstadoOperacionBancaria
		{
			 get { return _estadoOperacionBancaria; }
			 set
			 {
				 if (_estadoOperacionBancaria != value)
				 {
					_estadoOperacionBancaria = value;
					 PropertyHasChanged("EstadoOperacionBancaria");
				 }
			 }
		}

		public string  MotivoAnulacion
		{
			 get { return _motivoAnulacion; }
			 set
			 {
				 if (_motivoAnulacion != value)
				 {
					_motivoAnulacion = value;
					 PropertyHasChanged("MotivoAnulacion");
				 }
			 }
		}

		public DateTime?  FechaHoraPago
		{
			 get { return _fechaHoraPago; }
			 set
			 {
				 if (_fechaHoraPago != value)
				 {
					_fechaHoraPago = value;
					 PropertyHasChanged("FechaHoraPago");
				 }
			 }
		}

		public string  CodDocumentoPago
		{
			 get { return _codDocumentoPago; }
			 set
			 {
				 if (_codDocumentoPago != value)
				 {
					_codDocumentoPago = value;
					 PropertyHasChanged("CodDocumentoPago");
				 }
			 }
		}

		public int?  NroDocumentoPago
		{
			 get { return _nroDocumentoPago; }
			 set
			 {
				 if (_nroDocumentoPago != value)
				 {
					_nroDocumentoPago = value;
					 PropertyHasChanged("NroDocumentoPago");
				 }
			 }
		}

		public string  ObsPagoTransferencia
		{
			 get { return _obsPagoTransferencia; }
			 set
			 {
				 if (_obsPagoTransferencia != value)
				 {
					_obsPagoTransferencia = value;
					 PropertyHasChanged("ObsPagoTransferencia");
				 }
			 }
		}

		public int?  Estado
		{
			 get { return _estado; }
			 set
			 {
				 if (_estado != value)
				 {
					_estado = value;
					 PropertyHasChanged("Estado");
				 }
			 }
		}

		public bool?  FlagImpreso
		{
			 get { return _flagImpreso; }
			 set
			 {
				 if (_flagImpreso != value)
				 {
					_flagImpreso = value;
					 PropertyHasChanged("FlagImpreso");
				 }
			 }
		}

		public int?  CajaAperturaId
		{
			 get { return _cajaAperturaId; }
			 set
			 {
				 if (_cajaAperturaId != value)
				 {
					_cajaAperturaId = value;
					 PropertyHasChanged("CajaAperturaId");
				 }
			 }
		}

		public int?  TipoTransaccion
		{
			 get { return _tipoTransaccion; }
			 set
			 {
				 if (_tipoTransaccion != value)
				 {
					_tipoTransaccion = value;
					 PropertyHasChanged("TipoTransaccion");
				 }
			 }
		}

		public int?  ConceptoId
		{
			 get { return _conceptoId; }
			 set
			 {
				 if (_conceptoId != value)
				 {
					_conceptoId = value;
					 PropertyHasChanged("ConceptoId");
				 }
			 }
		}

		public string  CodigoSeguridad
		{
			 get { return _codigoSeguridad; }
			 set
			 {
				 if (_codigoSeguridad != value)
				 {
					_codigoSeguridad = value;
					 PropertyHasChanged("CodigoSeguridad");
				 }
			 }
		}

		public bool  FlagArregloCuenta
		{
			 get { return _flagArregloCuenta; }
			 set
			 {
				 if (_flagArregloCuenta != value)
				 {
					_flagArregloCuenta = value;
					 PropertyHasChanged("FlagArregloCuenta");
				 }
			 }
		}

		public bool  FlagChequeo
		{
			 get { return _flagChequeo; }
			 set
			 {
				 if (_flagChequeo != value)
				 {
					_flagChequeo = value;
					 PropertyHasChanged("FlagChequeo");
				 }
			 }
		}

		public DateTime?  FechaHoraChequeo
		{
			 get { return _fechaHoraChequeo; }
			 set
			 {
				 if (_fechaHoraChequeo != value)
				 {
					_fechaHoraChequeo = value;
					 PropertyHasChanged("FechaHoraChequeo");
				 }
			 }
		}

		public string  UsuarioChequeo
		{
			 get { return _usuarioChequeo; }
			 set
			 {
				 if (_usuarioChequeo != value)
				 {
					_usuarioChequeo = value;
					 PropertyHasChanged("UsuarioChequeo");
				 }
			 }
		}

		public string  UsuarioArregloCuenta
		{
			 get { return _usuarioArregloCuenta; }
			 set
			 {
				 if (_usuarioArregloCuenta != value)
				 {
					_usuarioArregloCuenta = value;
					 PropertyHasChanged("UsuarioArregloCuenta");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("TransferenciaId", "TransferenciaId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("NumeroDocumento", "NumeroDocumento"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodDocumento", "CodDocumento"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodDocumento", "CodDocumento",6));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("OficinaIdProcedencia", "OficinaIdProcedencia"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("OficinaIdProcedencia", "OficinaIdProcedencia",10));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("OficinaIdDestino", "OficinaIdDestino"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("OficinaIdDestino", "OficinaIdDestino",10));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PersonaIdSolicitante", "PersonaIdSolicitante"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("PersonaIdSolicitante", "PersonaIdSolicitante",12));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PersonaIdBeneficiario", "PersonaIdBeneficiario"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("PersonaIdBeneficiario", "PersonaIdBeneficiario",12));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("MonedaId", "MonedaId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Importe", "Importe"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("DerechoTransferencia", "DerechoTransferencia"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("DerechoTransferenciaArreglo", "DerechoTransferenciaArreglo"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("ObsTransferencia", "ObsTransferencia",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("UsuarioAnulacion", "UsuarioAnulacion",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("NumeroCuentaBanco", "NumeroCuentaBanco",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoOperacion", "CodigoOperacion",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("MotivoAnulacion", "MotivoAnulacion",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodDocumentoPago", "CodDocumentoPago",6));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("ObsPagoTransferencia", "ObsPagoTransferencia",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoSeguridad", "CodigoSeguridad",4));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("FlagArregloCuenta", "FlagArregloCuenta"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("FlagChequeo", "FlagChequeo"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("UsuarioChequeo", "UsuarioChequeo",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("UsuarioArregloCuenta", "UsuarioArregloCuenta",20));
		}

		#endregion

	}
}
