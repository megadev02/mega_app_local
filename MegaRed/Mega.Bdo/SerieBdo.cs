using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class SerieBdo : BdoObjectBase
	{

		#region InnerClass
		public enum SerieFields
		{
			SerieId,
			CodComprobante,
			NumeroSerie,
			NumeroDigitos,
			CierreSerie,
			CodigoOficina
		}
		#endregion

		#region Data Members

			int _serieId;
			string _codComprobante;
			int _numeroSerie;
			int _numeroDigitos;
			bool _cierreSerie;
			string _codigoOficina;

		#endregion

		#region Properties

		public int  SerieId
		{
			 get { return _serieId; }
			 set
			 {
				 if (_serieId != value)
				 {
					_serieId = value;
					 PropertyHasChanged("SerieId");
				 }
			 }
		}

		public string  CodComprobante
		{
			 get { return _codComprobante; }
			 set
			 {
				 if (_codComprobante != value)
				 {
					_codComprobante = value;
					 PropertyHasChanged("CodComprobante");
				 }
			 }
		}

		public int  NumeroSerie
		{
			 get { return _numeroSerie; }
			 set
			 {
				 if (_numeroSerie != value)
				 {
					_numeroSerie = value;
					 PropertyHasChanged("NumeroSerie");
				 }
			 }
		}

		public int  NumeroDigitos
		{
			 get { return _numeroDigitos; }
			 set
			 {
				 if (_numeroDigitos != value)
				 {
					_numeroDigitos = value;
					 PropertyHasChanged("NumeroDigitos");
				 }
			 }
		}

		public bool  CierreSerie
		{
			 get { return _cierreSerie; }
			 set
			 {
				 if (_cierreSerie != value)
				 {
					_cierreSerie = value;
					 PropertyHasChanged("CierreSerie");
				 }
			 }
		}

		public string  CodigoOficina
		{
			 get { return _codigoOficina; }
			 set
			 {
				 if (_codigoOficina != value)
				 {
					_codigoOficina = value;
					 PropertyHasChanged("CodigoOficina");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("SerieId", "SerieId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodComprobante", "CodComprobante"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodComprobante", "CodComprobante",2));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("NumeroSerie", "NumeroSerie"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("NumeroDigitos", "NumeroDigitos"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CierreSerie", "CierreSerie"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoOficina", "CodigoOficina",10));
		}

		#endregion

	}
}
