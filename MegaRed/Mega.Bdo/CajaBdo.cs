using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class CajaBdo : BdoObjectBase
	{

		#region InnerClass
		public enum CajaFields
		{
			CajaId,
			Nombre,
			Contrasenia,
			Estado,
			CodigoCuenta
		}
		#endregion

		#region Data Members

			int _cajaId;
			string _nombre;
			string _contrasenia;
			bool _estado;
			string _codigoCuenta;

		#endregion

		#region Properties

		public int  CajaId
		{
			 get { return _cajaId; }
			 set
			 {
				 if (_cajaId != value)
				 {
					_cajaId = value;
					 PropertyHasChanged("CajaId");
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

		public bool  Estado
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CajaId", "CajaId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Nombre", "Nombre",30));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Contrasenia", "Contrasenia",100));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Estado", "Estado"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoCuenta", "CodigoCuenta",20));
		}

		#endregion

	}
}
