using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class ReciboCajaBdo : BdoObjectBase
	{

		#region InnerClass
		public enum ReciboCajaFields
		{
			NumeroDocumento,
			CajaAperturaId,
			CodDocumento,
			TipoRecibo,
			MonedaId,
			Importe,
			FechaHoraTransaccion,
			CodigoPersona,
			Concepto,
			FlagImpreso,
			ObsRecibo,
			FechaHoraAnulacion,
			UsuarioAnulacion,
			ComprobanteCompraId,
			Estado,
			ConceptoId
		}
		#endregion

		#region Data Members

			int _numeroDocumento;
			int? _cajaAperturaId;
			string _codDocumento;
			int? _tipoRecibo;
			int? _monedaId;
			decimal? _importe;
			DateTime? _fechaHoraTransaccion;
			string _codigoPersona;
			string _concepto;
			bool? _flagImpreso;
			string _obsRecibo;
			DateTime? _fechaHoraAnulacion;
			string _usuarioAnulacion;
			int? _comprobanteCompraId;
			int? _estado;
			int? _conceptoId;

		#endregion

		#region Properties

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

		public int?  TipoRecibo
		{
			 get { return _tipoRecibo; }
			 set
			 {
				 if (_tipoRecibo != value)
				 {
					_tipoRecibo = value;
					 PropertyHasChanged("TipoRecibo");
				 }
			 }
		}

		public int?  MonedaId
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

		public decimal?  Importe
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

		public DateTime?  FechaHoraTransaccion
		{
			 get { return _fechaHoraTransaccion; }
			 set
			 {
				 if (_fechaHoraTransaccion != value)
				 {
					_fechaHoraTransaccion = value;
					 PropertyHasChanged("FechaHoraTransaccion");
				 }
			 }
		}

		public string  CodigoPersona
		{
			 get { return _codigoPersona; }
			 set
			 {
				 if (_codigoPersona != value)
				 {
					_codigoPersona = value;
					 PropertyHasChanged("CodigoPersona");
				 }
			 }
		}

		public string  Concepto
		{
			 get { return _concepto; }
			 set
			 {
				 if (_concepto != value)
				 {
					_concepto = value;
					 PropertyHasChanged("Concepto");
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

		public string  ObsRecibo
		{
			 get { return _obsRecibo; }
			 set
			 {
				 if (_obsRecibo != value)
				 {
					_obsRecibo = value;
					 PropertyHasChanged("ObsRecibo");
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

		public int?  ComprobanteCompraId
		{
			 get { return _comprobanteCompraId; }
			 set
			 {
				 if (_comprobanteCompraId != value)
				 {
					_comprobanteCompraId = value;
					 PropertyHasChanged("ComprobanteCompraId");
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("NumeroDocumento", "NumeroDocumento"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodDocumento", "CodDocumento",6));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoPersona", "CodigoPersona",12));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Concepto", "Concepto",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("ObsRecibo", "ObsRecibo",60));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("UsuarioAnulacion", "UsuarioAnulacion",20));
		}

		#endregion

	}
}
