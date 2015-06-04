using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class MonedaBdo : BdoObjectBase
	{

		#region InnerClass
		public enum MonedaFields
		{
			MonedaId,
			Nombre,
			Simbolo,
			Abreviatura,
			Referencia,
			EsNacional,
			Estado
		}
		#endregion

		#region Data Members

			int _monedaId;
			string _nombre;
			string _simbolo;
			string _abreviatura;
			string _referencia;
			bool _esNacional;
			bool _estado;

		#endregion

		#region Properties

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

		public string  Simbolo
		{
			 get { return _simbolo; }
			 set
			 {
				 if (_simbolo != value)
				 {
					_simbolo = value;
					 PropertyHasChanged("Simbolo");
				 }
			 }
		}

		public string  Abreviatura
		{
			 get { return _abreviatura; }
			 set
			 {
				 if (_abreviatura != value)
				 {
					_abreviatura = value;
					 PropertyHasChanged("Abreviatura");
				 }
			 }
		}

		public string  Referencia
		{
			 get { return _referencia; }
			 set
			 {
				 if (_referencia != value)
				 {
					_referencia = value;
					 PropertyHasChanged("Referencia");
				 }
			 }
		}

		public bool  EsNacional
		{
			 get { return _esNacional; }
			 set
			 {
				 if (_esNacional != value)
				 {
					_esNacional = value;
					 PropertyHasChanged("EsNacional");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("MonedaId", "MonedaId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Nombre", "Nombre"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Nombre", "Nombre",50));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Simbolo", "Simbolo"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Simbolo", "Simbolo",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Abreviatura", "Abreviatura",3));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Referencia", "Referencia"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Referencia", "Referencia",50));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("EsNacional", "EsNacional"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Estado", "Estado"));
		}

		#endregion

	}
}
