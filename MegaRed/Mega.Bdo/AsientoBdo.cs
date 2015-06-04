using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class AsientoBdo : BdoObjectBase
	{

		#region InnerClass
		public enum AsientoFields
		{
			AsientoId,
			Modulo,
			FechaAsiento,
			NumeroAsiento,
			Glosa,
			ValorCambio,
			CodDocumento,
			ContratoId
		}
		#endregion

		#region Data Members

			int _asientoId;
			string _modulo;
			DateTime _fechaAsiento;
			string _numeroAsiento;
			string _glosa;
			decimal _valorCambio;
			string _codDocumento;
			int _contratoId;

		#endregion

		#region Properties

		public int  AsientoId
		{
			 get { return _asientoId; }
			 set
			 {
				 if (_asientoId != value)
				 {
					_asientoId = value;
					 PropertyHasChanged("AsientoId");
				 }
			 }
		}

		public string  Modulo
		{
			 get { return _modulo; }
			 set
			 {
				 if (_modulo != value)
				 {
					_modulo = value;
					 PropertyHasChanged("Modulo");
				 }
			 }
		}

		public DateTime  FechaAsiento
		{
			 get { return _fechaAsiento; }
			 set
			 {
				 if (_fechaAsiento != value)
				 {
					_fechaAsiento = value;
					 PropertyHasChanged("FechaAsiento");
				 }
			 }
		}

		public string  NumeroAsiento
		{
			 get { return _numeroAsiento; }
			 set
			 {
				 if (_numeroAsiento != value)
				 {
					_numeroAsiento = value;
					 PropertyHasChanged("NumeroAsiento");
				 }
			 }
		}

		public string  Glosa
		{
			 get { return _glosa; }
			 set
			 {
				 if (_glosa != value)
				 {
					_glosa = value;
					 PropertyHasChanged("Glosa");
				 }
			 }
		}

		public decimal  ValorCambio
		{
			 get { return _valorCambio; }
			 set
			 {
				 if (_valorCambio != value)
				 {
					_valorCambio = value;
					 PropertyHasChanged("ValorCambio");
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

		public int  ContratoId
		{
			 get { return _contratoId; }
			 set
			 {
				 if (_contratoId != value)
				 {
					_contratoId = value;
					 PropertyHasChanged("ContratoId");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("AsientoId", "AsientoId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Modulo", "Modulo"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Modulo", "Modulo",20));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("FechaAsiento", "FechaAsiento"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("NumeroAsiento", "NumeroAsiento"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("NumeroAsiento", "NumeroAsiento",10));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Glosa", "Glosa"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Glosa", "Glosa",180));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ValorCambio", "ValorCambio"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodDocumento", "CodDocumento"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodDocumento", "CodDocumento",6));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ContratoId", "ContratoId"));
		}

		#endregion

	}
}
