using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class AccesosBdo : BdoObjectBase
	{

		#region InnerClass
		public enum AccesosFields
		{
			AccesoId,
			Id,
			UsuarioId
		}
		#endregion

		#region Data Members

			int _accesoId;
			int? _id;
			string _usuarioId;

		#endregion

		#region Properties

		public int  AccesoId
		{
			 get { return _accesoId; }
			 set
			 {
				 if (_accesoId != value)
				 {
					_accesoId = value;
					 PropertyHasChanged("AccesoId");
				 }
			 }
		}

		public int?  Id
		{
			 get { return _id; }
			 set
			 {
				 if (_id != value)
				 {
					_id = value;
					 PropertyHasChanged("Id");
				 }
			 }
		}

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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("AccesoId", "AccesoId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("UsuarioId", "UsuarioId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("UsuarioId", "UsuarioId",20));
		}

		#endregion

	}
}
