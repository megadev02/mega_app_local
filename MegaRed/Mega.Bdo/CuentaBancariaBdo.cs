using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class CuentaBancariaBdo : BdoObjectBase
	{

		#region InnerClass
		public enum CuentaBancariaFields
		{
			NumeroCuentaBanco,
			NombreCuentaBancaria,
			TipoCuenta,
			Estado,
			CodigoPersona,
			EntidadId,
			CodigoCuenta,
			MonedaId
		}
		#endregion

		#region Data Members

			int _numeroCuentaBanco;
			string _nombreCuentaBancaria;
			int _tipoCuenta;
			int _estado;
			string _codigoPersona;
			int _entidadId;
			string _codigoCuenta;
			int _monedaId;

		#endregion

		#region Properties

		public int  NumeroCuentaBanco
		{
			 get { return _numeroCuentaBanco; }
			 set
			 {
				 if (_numeroCuentaBanco != value)
				 {
					_numeroCuentaBanco = value;
					 PropertyHasChanged("NumeroCuentaBanco");
				 }
			 }
		}

		public string  NombreCuentaBancaria
		{
			 get { return _nombreCuentaBancaria; }
			 set
			 {
				 if (_nombreCuentaBancaria != value)
				 {
					_nombreCuentaBancaria = value;
					 PropertyHasChanged("NombreCuentaBancaria");
				 }
			 }
		}

		public int  TipoCuenta
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

		public int  Estado
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

		public int  MonedaId
		{
			 get { return _monedaId; }
			 set
			 {
				 if (_monedaId != value)
				 {
					_monedaId = value;
					 PropertyHasChanged("MonedaId");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("NumeroCuentaBanco", "NumeroCuentaBanco"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("NombreCuentaBancaria", "NombreCuentaBancaria"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("NombreCuentaBancaria", "NombreCuentaBancaria",50));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("TipoCuenta", "TipoCuenta"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Estado", "Estado"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodigoPersona", "CodigoPersona"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoPersona", "CodigoPersona",12));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("EntidadId", "EntidadId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodigoCuenta", "CodigoCuenta"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoCuenta", "CodigoCuenta",20));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("MonedaId", "MonedaId"));
		}

		#endregion

	}
}
