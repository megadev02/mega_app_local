using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class UsuarioBdo : BdoObjectBase
	{

		#region InnerClass
		public enum UsuarioFields
		{
			UsuarioId,
			Contrasenia,
			Estado
		}
		#endregion

		#region Data Members

			string _usuarioId;
			string _contrasenia;
			bool? _estado;

		#endregion

		#region Properties

		public string  UsuarioId
		{
			 get { return _usuarioId; }
			 set
			 {
				 if (_usuarioId != value)
				 {
					_usuarioId = value;
					 PropertyHasChanged("UsuarioId");
				 }
			 }
		}

		public string  Contrasenia
		{
			 get { return _contrasenia; }
			 set
			 {
				 if (_contrasenia != value)
				 {
					_contrasenia = value;
					 PropertyHasChanged("Contrasenia");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("UsuarioId", "UsuarioId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("UsuarioId", "UsuarioId",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Contrasenia", "Contrasenia",100));
		}

		#endregion

	}
}
