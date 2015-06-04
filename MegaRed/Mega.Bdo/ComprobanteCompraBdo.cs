using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class ComprobanteCompraBdo : BdoObjectBase
	{

		#region InnerClass
		public enum ComprobanteCompraFields
		{
			ComprobanteCompraId,
			RUC,
			RazonSocial,
			NumeroDocumento,
			NumeroSerie
		}
		#endregion

		#region Data Members

			int _comprobanteCompraId;
			string _rUC;
			string _razonSocial;
			int? _numeroDocumento;
			int? _numeroSerie;

		#endregion

		#region Properties

		public int  ComprobanteCompraId
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

		public string  RUC
		{
			 get { return _rUC; }
			 set
			 {
				 if (_rUC != value)
				 {
					_rUC = value;
					 PropertyHasChanged("RUC");
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

		public int?  NumeroDocumento
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

		public int?  NumeroSerie
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ComprobanteCompraId", "ComprobanteCompraId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("RUC", "RUC",12));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("RazonSocial", "RazonSocial",100));
		}

		#endregion

	}
}
