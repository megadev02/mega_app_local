using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class TipoDocumentoIdentidadBdo : BdoObjectBase
	{

		#region InnerClass
		public enum TipoDocumentoIdentidadFields
		{
			TipoDocumentoId,
			Abreviatura,
			Denominacion
		}
		#endregion

		#region Data Members

			int _tipoDocumentoId;
			string _abreviatura;
			string _denominacion;

		#endregion

		#region Properties

		public int  TipoDocumentoId
		{
			 get { return _tipoDocumentoId; }
			 set
			 {
				 if (_tipoDocumentoId != value)
				 {
					_tipoDocumentoId = value;
					 PropertyHasChanged("TipoDocumentoId");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("TipoDocumentoId", "TipoDocumentoId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Abreviatura", "Abreviatura",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Denominacion", "Denominacion",50));
		}

		#endregion

	}
}
