using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class TipoCambioBdo : BdoObjectBase
	{

		#region InnerClass
		public enum TipoCambioFields
		{
			Fecha,
			ValorCambioCompra,
			ValorCambioVenta
		}
		#endregion

		#region Data Members

			DateTime _fecha;
			decimal? _valorCambioCompra;
			decimal? _valorCambioVenta;

		#endregion

		#region Properties

		public DateTime  Fecha
		{
			 get { return _fecha; }
			 set
			 {
				 if (_fecha != value)
				 {
					_fecha = value;
					 PropertyHasChanged("Fecha");
				 }
			 }
		}

		public decimal?  ValorCambioCompra
		{
			 get { return _valorCambioCompra; }
			 set
			 {
				 if (_valorCambioCompra != value)
				 {
					_valorCambioCompra = value;
					 PropertyHasChanged("ValorCambioCompra");
				 }
			 }
		}

		public decimal?  ValorCambioVenta
		{
			 get { return _valorCambioVenta; }
			 set
			 {
				 if (_valorCambioVenta != value)
				 {
					_valorCambioVenta = value;
					 PropertyHasChanged("ValorCambioVenta");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Fecha", "Fecha"));
		}

		#endregion

	}
}
