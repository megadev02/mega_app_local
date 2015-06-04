using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class DepositoPrestamoBdo : BdoObjectBase
	{

		#region InnerClass
		public enum DepositoPrestamoFields
		{
			NumeroDocumento,
			FechaHoraTransaccion,
			TipoOperacion,
			MonedaId,
			Importe,
			FechaHoraAnulacion,
			UsuarioAnulacion,
			CodigoPersona,
			CajaAperturaId,
			ConceptoId,
			Fecha,
			FlagImpreso,
			Interes
		}
		#endregion

		#region Data Members

			int _numeroDocumento;
			DateTime _fechaHoraTransaccion;
			int? _tipoOperacion;
			int? _monedaId;
			decimal? _importe;
			DateTime? _fechaHoraAnulacion;
			string _usuarioAnulacion;
			string _codigoPersona;
			int? _cajaAperturaId;
			int? _conceptoId;
			DateTime? _fecha;
			int? _flagImpreso;
			decimal? _interes;

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

		public DateTime  FechaHoraTransaccion
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

		public int?  TipoOperacion
		{
			 get { return _tipoOperacion; }
			 set
			 {
				 if (_tipoOperacion != value)
				 {
					_tipoOperacion = value;
					 PropertyHasChanged("TipoOperacion");
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

		public DateTime?  Fecha
		{
			 get { return _fecha; }
			 set
			 {
				 if (_fecha != value)
				 {
					_fecha = value;
					 PropertyHasChanged("Fecha");
				 }
			 }
		}

		public int?  FlagImpreso
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

		public decimal?  Interes
		{
			 get { return _interes; }
			 set
			 {
				 if (_interes != value)
				 {
					_interes = value;
					 PropertyHasChanged("Interes");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("NumeroDocumento", "NumeroDocumento"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("FechaHoraTransaccion", "FechaHoraTransaccion"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("UsuarioAnulacion", "UsuarioAnulacion",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoPersona", "CodigoPersona",12));
		}

		#endregion

	}
}
