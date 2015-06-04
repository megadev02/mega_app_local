using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class ArqueoCajaBdo : BdoObjectBase
	{

		#region InnerClass
		public enum ArqueoCajaFields
		{
			ArqueoCajaId,
			IdDenominacionMoneda,
			Cantidad,
			CajaAperturaId
		}
		#endregion

		#region Data Members

			int _arqueoCajaId;
			int? _idDenominacionMoneda;
			int _cantidad;
			int? _cajaAperturaId;

		#endregion

		#region Properties

		public int  ArqueoCajaId
		{
			 get { return _arqueoCajaId; }
			 set
			 {
				 if (_arqueoCajaId != value)
				 {
					_arqueoCajaId = value;
					 PropertyHasChanged("ArqueoCajaId");
				 }
			 }
		}

		public int?  IdDenominacionMoneda
		{
			 get { return _idDenominacionMoneda; }
			 set
			 {
				 if (_idDenominacionMoneda != value)
				 {
					_idDenominacionMoneda = value;
					 PropertyHasChanged("IdDenominacionMoneda");
				 }
			 }
		}

		public int  Cantidad
		{
			 get { return _cantidad; }
			 set
			 {
				 if (_cantidad != value)
				 {
					_cantidad = value;
					 PropertyHasChanged("Cantidad");
				 }
			 }
		}

		public int?  CajaAperturaId
		{
			 get { return _cajaAperturaId; }
			 set
			 {
				 if (_cajaAperturaId != value)
				 {
					_cajaAperturaId = value;
					 PropertyHasChanged("CajaAperturaId");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ArqueoCajaId", "ArqueoCajaId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Cantidad", "Cantidad"));
		}

		#endregion

	}
}
