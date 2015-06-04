using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class AsientoDetalleBdo : BdoObjectBase
	{

		#region InnerClass
		public enum AsientoDetalleFields
		{
			AsientoDetalleId,
			Debe,
			Haber,
			Tipo,
			DebeDolar,
			HaberDolar,
			AsientoId,
			CodigoCuenta
		}
		#endregion

		#region Data Members

			int _asientoDetalleId;
			decimal _debe;
			decimal _haber;
			int _tipo;
			decimal _debeDolar;
			decimal _haberDolar;
			int _asientoId;
			string _codigoCuenta;

		#endregion

		#region Properties

		public int  AsientoDetalleId
		{
			 get { return _asientoDetalleId; }
			 set
			 {
				 if (_asientoDetalleId != value)
				 {
					_asientoDetalleId = value;
					 PropertyHasChanged("AsientoDetalleId");
				 }
			 }
		}

		public decimal  Debe
		{
			 get { return _debe; }
			 set
			 {
				 if (_debe != value)
				 {
					_debe = value;
					 PropertyHasChanged("Debe");
				 }
			 }
		}

		public decimal  Haber
		{
			 get { return _haber; }
			 set
			 {
				 if (_haber != value)
				 {
					_haber = value;
					 PropertyHasChanged("Haber");
				 }
			 }
		}

		public int  Tipo
		{
			 get { return _tipo; }
			 set
			 {
				 if (_tipo != value)
				 {
					_tipo = value;
					 PropertyHasChanged("Tipo");
				 }
			 }
		}

		public decimal  DebeDolar
		{
			 get { return _debeDolar; }
			 set
			 {
				 if (_debeDolar != value)
				 {
					_debeDolar = value;
					 PropertyHasChanged("DebeDolar");
				 }
			 }
		}

		public decimal  HaberDolar
		{
			 get { return _haberDolar; }
			 set
			 {
				 if (_haberDolar != value)
				 {
					_haberDolar = value;
					 PropertyHasChanged("HaberDolar");
				 }
			 }
		}

		public int  AsientoId
		{
			 get { return _asientoId; }
			 set
			 {
				 if (_asientoId != value)
				 {
					_asientoId = value;
					 PropertyHasChanged("AsientoId");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("AsientoDetalleId", "AsientoDetalleId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Debe", "Debe"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Haber", "Haber"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Tipo", "Tipo"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("DebeDolar", "DebeDolar"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("HaberDolar", "HaberDolar"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("AsientoId", "AsientoId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodigoCuenta", "CodigoCuenta"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoCuenta", "CodigoCuenta",20));
		}

		#endregion

	}
}
