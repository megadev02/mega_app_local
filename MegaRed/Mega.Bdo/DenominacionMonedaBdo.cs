using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class DenominacionMonedaBdo : BdoObjectBase
	{

		#region InnerClass
		public enum DenominacionMonedaFields
		{
			DenominacionMonedaId,
			Valor,
			Denominacion,
			MonedaId
		}
		#endregion

		#region Data Members

			int _denominacionMonedaId;
			decimal _valor;
			string _denominacion;
			int? _monedaId;

		#endregion

		#region Properties

		public int  DenominacionMonedaId
		{
			 get { return _denominacionMonedaId; }
			 set
			 {
				 if (_denominacionMonedaId != value)
				 {
					_denominacionMonedaId = value;
					 PropertyHasChanged("DenominacionMonedaId");
				 }
			 }
		}

		public decimal  Valor
		{
			 get { return _valor; }
			 set
			 {
				 if (_valor != value)
				 {
					_valor = value;
					 PropertyHasChanged("Valor");
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

		public int?  MonedaId
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("DenominacionMonedaId", "DenominacionMonedaId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Valor", "Valor"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Denominacion", "Denominacion"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Denominacion", "Denominacion",20));
		}

		#endregion

	}
}
