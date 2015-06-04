using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class PersonaDetalleBdo : BdoObjectBase
	{

		#region InnerClass
		public enum PersonaDetalleFields
		{
			PersonaDetalleId,
			CodigoPersona,
			FechaHora,
			RutaImagen,
			HuellaDigital
		}
		#endregion

		#region Data Members

			int _personaDetalleId;
			string _codigoPersona;
			DateTime _fechaHora;
			string _rutaImagen;
			string _huellaDigital;

		#endregion

		#region Properties

		public int  PersonaDetalleId
		{
			 get { return _personaDetalleId; }
			 set
			 {
				 if (_personaDetalleId != value)
				 {
					_personaDetalleId = value;
					 PropertyHasChanged("PersonaDetalleId");
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

		public DateTime  FechaHora
		{
			 get { return _fechaHora; }
			 set
			 {
				 if (_fechaHora != value)
				 {
					_fechaHora = value;
					 PropertyHasChanged("FechaHora");
				 }
			 }
		}

		public string  RutaImagen
		{
			 get { return _rutaImagen; }
			 set
			 {
				 if (_rutaImagen != value)
				 {
					_rutaImagen = value;
					 PropertyHasChanged("RutaImagen");
				 }
			 }
		}

		public string  HuellaDigital
		{
			 get { return _huellaDigital; }
			 set
			 {
				 if (_huellaDigital != value)
				 {
					_huellaDigital = value;
					 PropertyHasChanged("HuellaDigital");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PersonaDetalleId", "PersonaDetalleId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoPersona", "CodigoPersona",12));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("FechaHora", "FechaHora"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("RutaImagen", "RutaImagen",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("HuellaDigital", "HuellaDigital",100));
		}

		#endregion

	}
}
