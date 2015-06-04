using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class PerfilBdo : BdoObjectBase
	{

		#region InnerClass
		public enum PerfilFields
		{
			PerfilId,
			NombrePerfil,
			Estado
		}
		#endregion

		#region Data Members

			int _perfilId;
			string _nombrePerfil;
			bool? _estado;

		#endregion

		#region Properties

		public int  PerfilId
		{
			 get { return _perfilId; }
			 set
			 {
				 if (_perfilId != value)
				 {
					_perfilId = value;
					 PropertyHasChanged("PerfilId");
				 }
			 }
		}

		public string  NombrePerfil
		{
			 get { return _nombrePerfil; }
			 set
			 {
				 if (_nombrePerfil != value)
				 {
					_nombrePerfil = value;
					 PropertyHasChanged("NombrePerfil");
				 }
			 }
		}

		public bool?  Estado
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PerfilId", "PerfilId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("NombrePerfil", "NombrePerfil",50));
		}

		#endregion

	}
}
