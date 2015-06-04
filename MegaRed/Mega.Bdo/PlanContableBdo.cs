using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class PlanContableBdo : BdoObjectBase
	{

		#region InnerClass
		public enum PlanContableFields
		{
			CodigoCuenta,
			Denominacion,
			Naturaleza,
			TipoCuenta,
			Estructura,
			Nivel,
			CodigoCuentaPadre
		}
		#endregion

		#region Data Members

			string _codigoCuenta;
			string _denominacion;
			string _naturaleza;
			string _tipoCuenta;
			string _estructura;
			int? _nivel;
			string _codigoCuentaPadre;

		#endregion

		#region Properties

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

		public string  Denominacion
		{
			 get { return _denominacion; }
			 set
			 {
				 if (_denominacion != value)
				 {
					_denominacion = value;
					 PropertyHasChanged("Denominacion");
				 }
			 }
		}

		public string  Naturaleza
		{
			 get { return _naturaleza; }
			 set
			 {
				 if (_naturaleza != value)
				 {
					_naturaleza = value;
					 PropertyHasChanged("Naturaleza");
				 }
			 }
		}

		public string  TipoCuenta
		{
			 get { return _tipoCuenta; }
			 set
			 {
				 if (_tipoCuenta != value)
				 {
					_tipoCuenta = value;
					 PropertyHasChanged("TipoCuenta");
				 }
			 }
		}

		public string  Estructura
		{
			 get { return _estructura; }
			 set
			 {
				 if (_estructura != value)
				 {
					_estructura = value;
					 PropertyHasChanged("Estructura");
				 }
			 }
		}

		public int?  Nivel
		{
			 get { return _nivel; }
			 set
			 {
				 if (_nivel != value)
				 {
					_nivel = value;
					 PropertyHasChanged("Nivel");
				 }
			 }
		}

		public string  CodigoCuentaPadre
		{
			 get { return _codigoCuentaPadre; }
			 set
			 {
				 if (_codigoCuentaPadre != value)
				 {
					_codigoCuentaPadre = value;
					 PropertyHasChanged("CodigoCuentaPadre");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodigoCuenta", "CodigoCuenta"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoCuenta", "CodigoCuenta",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Denominacion", "Denominacion",150));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Naturaleza", "Naturaleza",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("TipoCuenta", "TipoCuenta",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Estructura", "Estructura",16));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoCuentaPadre", "CodigoCuentaPadre",20));
		}

		#endregion

	}
}
