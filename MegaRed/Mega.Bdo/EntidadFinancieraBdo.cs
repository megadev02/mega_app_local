using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class EntidadFinancieraBdo : BdoObjectBase
	{

		#region InnerClass
		public enum EntidadFinancieraFields
		{
			EntidadId,
			CodEntidad,
			Nombre
		}
		#endregion

		#region Data Members

			int _entidadId;
			string _codEntidad;
			string _nombre;

		#endregion

		#region Properties

		public int  EntidadId
		{
			 get { return _entidadId; }
			 set
			 {
				 if (_entidadId != value)
				 {
					_entidadId = value;
					 PropertyHasChanged("EntidadId");
				 }
			 }
		}

		public string  CodEntidad
		{
			 get { return _codEntidad; }
			 set
			 {
				 if (_codEntidad != value)
				 {
					_codEntidad = value;
					 PropertyHasChanged("CodEntidad");
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("EntidadId", "EntidadId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodEntidad", "CodEntidad"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodEntidad", "CodEntidad",20));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Nombre", "Nombre"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Nombre", "Nombre",100));
		}

		#endregion

	}
}
