using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class CambioMonedaBdo : BdoObjectBase
	{

		#region InnerClass
		public enum CambioMonedaFields
		{
			NumeroDocumento,
			MonedaOrigenId,
			MonedaDestinoId,
			RazonSocial,
			Importe,
			Fecha,
			FlagImpreso,
			CajaAperturaId,
			UsuarioAnulado,
			FechaHoraAnulacion,
			ConceptoId
		}
		#endregion

		#region Data Members

			int _numeroDocumento;
			int _monedaOrigenId;
			int _monedaDestinoId;
			string _razonSocial;
			decimal _importe;
			DateTime? _fecha;
			bool? _flagImpreso;
			int? _cajaAperturaId;
			string _usuarioAnulado;
			DateTime? _fechaHoraAnulacion;
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

		public int  MonedaOrigenId
		{
			 get { return _monedaOrigenId; }
			 set
			 {
				 if (_monedaOrigenId != value)
				 {
					_monedaOrigenId = value;
					 PropertyHasChanged("MonedaOrigenId");
				 }
			 }
		}

		public int  MonedaDestinoId
		{
			 get { return _monedaDestinoId; }
			 set
			 {
				 if (_monedaDestinoId != value)
				 {
					_monedaDestinoId = value;
					 PropertyHasChanged("MonedaDestinoId");
				 }
			 }
		}

		public string  RazonSocial
		{
			 get { return _razonSocial; }
			 set
			 {
				 if (_razonSocial != value)
				 {
					_razonSocial = value;
					 PropertyHasChanged("RazonSocial");
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

		public string  UsuarioAnulado
		{
			 get { return _usuarioAnulado; }
			 set
			 {
				 if (_usuarioAnulado != value)
				 {
					_usuarioAnulado = value;
					 PropertyHasChanged("UsuarioAnulado");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("MonedaOrigenId", "MonedaOrigenId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("MonedaDestinoId", "MonedaDestinoId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("RazonSocial", "RazonSocial",50));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Importe", "Importe"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("UsuarioAnulado", "UsuarioAnulado",20));
		}

		#endregion

	}
}
