using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class ConceptoBdo : BdoObjectBase
	{

		#region InnerClass
		public enum ConceptoFields
		{
			ConceptoId,
			Nombre,
			CodigoCuenta
		}
		#endregion

		#region Data Members

			int _conceptoId;
			string _nombre;
			string _codigoCuenta;

		#endregion

		#region Properties

		public int  ConceptoId
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

		public string  Nombre
		{
			 get { return _nombre; }
			 set
			 {
				 if (_nombre != value)
				 {
					_nombre = value;
					 PropertyHasChanged("Nombre");
				 }
			 }
		}

		public string  CodigoCuenta
		{
			 get { return _codigoCuenta; }
			 set
			 {
				 if (_codigoCuenta != value)
				 {
					_codigoCuenta = value;
					 PropertyHasChanged("CodigoCuenta");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ConceptoId", "ConceptoId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Nombre", "Nombre"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Nombre", "Nombre",150));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoCuenta", "CodigoCuenta",20));
		}

		#endregion

	}
}
