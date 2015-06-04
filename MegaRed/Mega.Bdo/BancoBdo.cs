using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class BancoBdo : BdoObjectBase
	{

		#region InnerClass
		public enum BancoFields
		{
			BancoId,
			EntidadId,
			Direccion,
			CodigoUbigeo,
			Telefono1,
			Telefono2,
			Telefono3,
			Estado
		}
		#endregion

		#region Data Members

			int _bancoId;
			int? _entidadId;
			string _direccion;
			string _codigoUbigeo;
			string _telefono1;
			string _telefono2;
			string _telefono3;
			bool? _estado;

		#endregion

		#region Properties

		public int  BancoId
		{
			 get { return _bancoId; }
			 set
			 {
				 if (_bancoId != value)
				 {
					_bancoId = value;
					 PropertyHasChanged("BancoId");
				 }
			 }
		}

		public int?  EntidadId
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

		public string  Direccion
		{
			 get { return _direccion; }
			 set
			 {
				 if (_direccion != value)
				 {
					_direccion = value;
					 PropertyHasChanged("Direccion");
				 }
			 }
		}

		public string  CodigoUbigeo
		{
			 get { return _codigoUbigeo; }
			 set
			 {
				 if (_codigoUbigeo != value)
				 {
					_codigoUbigeo = value;
					 PropertyHasChanged("CodigoUbigeo");
				 }
			 }
		}

		public string  Telefono1
		{
			 get { return _telefono1; }
			 set
			 {
				 if (_telefono1 != value)
				 {
					_telefono1 = value;
					 PropertyHasChanged("Telefono1");
				 }
			 }
		}

		public string  Telefono2
		{
			 get { return _telefono2; }
			 set
			 {
				 if (_telefono2 != value)
				 {
					_telefono2 = value;
					 PropertyHasChanged("Telefono2");
				 }
			 }
		}

		public string  Telefono3
		{
			 get { return _telefono3; }
			 set
			 {
				 if (_telefono3 != value)
				 {
					_telefono3 = value;
					 PropertyHasChanged("Telefono3");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("BancoId", "BancoId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Direccion", "Direccion",60));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoUbigeo", "CodigoUbigeo",12));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Telefono1", "Telefono1",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Telefono2", "Telefono2",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Telefono3", "Telefono3",20));
		}

		#endregion

	}
}
