using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class EmpresaAfiliadaBdo : BdoObjectBase
	{

		#region InnerClass
		public enum EmpresaAfiliadaFields
		{
			EmpresaAfiliadaId,
			CodigoPersona
		}
		#endregion

		#region Data Members

			int _empresaAfiliadaId;
			string _codigoPersona;

		#endregion

		#region Properties

		public int  EmpresaAfiliadaId
		{
			 get { return _empresaAfiliadaId; }
			 set
			 {
				 if (_empresaAfiliadaId != value)
				 {
					_empresaAfiliadaId = value;
					 PropertyHasChanged("EmpresaAfiliadaId");
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("EmpresaAfiliadaId", "EmpresaAfiliadaId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodigoPersona", "CodigoPersona"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoPersona", "CodigoPersona",12));
		}

		#endregion

	}
}
