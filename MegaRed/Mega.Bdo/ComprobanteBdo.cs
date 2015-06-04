using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class ComprobanteBdo : BdoObjectBase
	{

		#region InnerClass
		public enum ComprobanteFields
		{
			CodComprobante,
			NombreComprobante,
			CreditoFiscal
		}
		#endregion

		#region Data Members

			string _codComprobante;
			string _nombreComprobante;
			bool _creditoFiscal;

		#endregion

		#region Properties

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

		public string  NombreComprobante
		{
			 get { return _nombreComprobante; }
			 set
			 {
				 if (_nombreComprobante != value)
				 {
					_nombreComprobante = value;
					 PropertyHasChanged("NombreComprobante");
				 }
			 }
		}

		public bool  CreditoFiscal
		{
			 get { return _creditoFiscal; }
			 set
			 {
				 if (_creditoFiscal != value)
				 {
					_creditoFiscal = value;
					 PropertyHasChanged("CreditoFiscal");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodComprobante", "CodComprobante"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodComprobante", "CodComprobante",2));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("NombreComprobante", "NombreComprobante"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("NombreComprobante", "NombreComprobante",120));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CreditoFiscal", "CreditoFiscal"));
		}

		#endregion

	}
}
