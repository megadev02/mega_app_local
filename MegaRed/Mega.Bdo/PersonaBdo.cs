using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class PersonaBdo : BdoObjectBase
	{

		#region InnerClass
		public enum PersonaFields
		{
			CodigoPersona,
			TipoPersona,
			RazonSocial,
			PrimerNombre,
			SegundoNombre,
			ApellidoPaterno,
			ApellidoMaterno,
			TipoDocumentoId,
			NumeroDocumento,
			CodigoUbigeo,
			DireccionDomicilio,
			Telefono,
			Celular,
			Email,
			Web,
			Estado
		}
		#endregion

		#region Data Members

			string _codigoPersona;
			int _tipoPersona;
			string _razonSocial;
			string _primerNombre;
			string _segundoNombre;
			string _apellidoPaterno;
			string _apellidoMaterno;
			int _tipoDocumentoId;
			string _numeroDocumento;
			string _codigoUbigeo;
			string _direccionDomicilio;
			string _telefono;
			string _celular;
			string _email;
			string _web;
			bool? _estado;

		#endregion

		#region Properties

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

		public int  TipoPersona
		{
			 get { return _tipoPersona; }
			 set
			 {
				 if (_tipoPersona != value)
				 {
					_tipoPersona = value;
					 PropertyHasChanged("TipoPersona");
				 }
			 }
		}

		public string  RazonSocial
		{
			 get { return _razonSocial; }
			 set
			 {
				 if (_razonSocial != value)
				 {
					_razonSocial = value;
					 PropertyHasChanged("RazonSocial");
				 }
			 }
		}

		public string  PrimerNombre
		{
			 get { return _primerNombre; }
			 set
			 {
				 if (_primerNombre != value)
				 {
					_primerNombre = value;
					 PropertyHasChanged("PrimerNombre");
				 }
			 }
		}

		public string  SegundoNombre
		{
			 get { return _segundoNombre; }
			 set
			 {
				 if (_segundoNombre != value)
				 {
					_segundoNombre = value;
					 PropertyHasChanged("SegundoNombre");
				 }
			 }
		}

		public string  ApellidoPaterno
		{
			 get { return _apellidoPaterno; }
			 set
			 {
				 if (_apellidoPaterno != value)
				 {
					_apellidoPaterno = value;
					 PropertyHasChanged("ApellidoPaterno");
				 }
			 }
		}

		public string  ApellidoMaterno
		{
			 get { return _apellidoMaterno; }
			 set
			 {
				 if (_apellidoMaterno != value)
				 {
					_apellidoMaterno = value;
					 PropertyHasChanged("ApellidoMaterno");
				 }
			 }
		}

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

		public string  NumeroDocumento
		{
			 get { return _numeroDocumento; }
			 set
			 {
				 if (_numeroDocumento != value)
				 {
					_numeroDocumento = value;
					 PropertyHasChanged("NumeroDocumento");
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

		public string  DireccionDomicilio
		{
			 get { return _direccionDomicilio; }
			 set
			 {
				 if (_direccionDomicilio != value)
				 {
					_direccionDomicilio = value;
					 PropertyHasChanged("DireccionDomicilio");
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

		public string  Celular
		{
			 get { return _celular; }
			 set
			 {
				 if (_celular != value)
				 {
					_celular = value;
					 PropertyHasChanged("Celular");
				 }
			 }
		}

		public string  Email
		{
			 get { return _email; }
			 set
			 {
				 if (_email != value)
				 {
					_email = value;
					 PropertyHasChanged("Email");
				 }
			 }
		}

		public string  Web
		{
			 get { return _web; }
			 set
			 {
				 if (_web != value)
				 {
					_web = value;
					 PropertyHasChanged("Web");
				 }
			 }
		}

		public bool?  Estado
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodigoPersona", "CodigoPersona"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoPersona", "CodigoPersona",12));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("TipoPersona", "TipoPersona"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("RazonSocial", "RazonSocial",150));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("PrimerNombre", "PrimerNombre",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("SegundoNombre", "SegundoNombre",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("ApellidoPaterno", "ApellidoPaterno",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("ApellidoMaterno", "ApellidoMaterno",50));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("TipoDocumentoId", "TipoDocumentoId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("NumeroDocumento", "NumeroDocumento"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("NumeroDocumento", "NumeroDocumento",12));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoUbigeo", "CodigoUbigeo",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("DireccionDomicilio", "DireccionDomicilio",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Telefono", "Telefono",12));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Celular", "Celular",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Email", "Email",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Web", "Web",60));
		}

		#endregion

	}
}
