using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class TipoComuneroBdo : BdoObjectBase
	{

		#region InnerClass
		public enum TipoComuneroFields
		{
			TipoComuneroId,
			Denominacion
		}
		#endregion

		#region Data Members

			int _tipoComuneroId;
			string _denominacion;

		#endregion

		#region Properties

		public int  TipoComuneroId
		{
			 get { return _tipoComuneroId; }
			 set
			 {
				 if (_tipoComuneroId != value)
				 {
					_tipoComuneroId = value;
					 PropertyHasChanged("TipoComuneroId");
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("TipoComuneroId", "TipoComuneroId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Denominacion", "Denominacion",50));
		}

		#endregion

	}
}
