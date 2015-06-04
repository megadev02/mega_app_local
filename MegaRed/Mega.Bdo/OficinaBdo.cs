using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class OficinaBdo : BdoObjectBase
	{

		#region InnerClass
		public enum OficinaFields
		{
			CodigoOficina,
			NombreOficina,
			CodigoUbigeo,
			TipoOficina,
			Direccion,
			Telefono,
			Estado
		}
		#endregion

		#region Data Members

			string _codigoOficina;
			string _nombreOficina;
			string _codigoUbigeo;
			int _tipoOficina;
			string _direccion;
			string _telefono;
			bool _estado;

		#endregion

		#region Properties

		public string  CodigoOficina
		{
			 get { return _codigoOficina; }
			 set
			 {
				 if (_codigoOficina != value)
				 {
					_codigoOficina = value;
					 PropertyHasChanged("CodigoOficina");
				 }
			 }
		}

		public string  NombreOficina
		{
			 get { return _nombreOficina; }
			 set
			 {
				 if (_nombreOficina != value)
				 {
					_nombreOficina = value;
					 PropertyHasChanged("NombreOficina");
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

		public int  TipoOficina
		{
			 get { return _tipoOficina; }
			 set
			 {
				 if (_tipoOficina != value)
				 {
					_tipoOficina = value;
					 PropertyHasChanged("TipoOficina");
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

		public string  Telefono
		{
			 get { return _telefono; }
			 set
			 {
				 if (_telefono != value)
				 {
					_telefono = value;
					 PropertyHasChanged("Telefono");
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodigoOficina", "CodigoOficina"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoOficina", "CodigoOficina",10));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("NombreOficina", "NombreOficina"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("NombreOficina", "NombreOficina",50));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodigoUbigeo", "CodigoUbigeo"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoUbigeo", "CodigoUbigeo",10));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("TipoOficina", "TipoOficina"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Direccion", "Direccion"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Direccion", "Direccion",50));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Telefono", "Telefono"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Telefono", "Telefono",10));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Estado", "Estado"));
		}

		#endregion

	}
}
