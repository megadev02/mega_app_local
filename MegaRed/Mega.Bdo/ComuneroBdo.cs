using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public class ComuneroBdo : BdoObjectBase
	{

		#region InnerClass
		public enum ComuneroFields
		{
			CodigoComunero,
			SexoId,
			GradoInstruccionId,
			ReligionId,
			TipoComuneroId,
			EstadoCivilId,
			TipoDocumentoId,
			NroDocumentoIdentidad,
			ApellidoPaterno,
			ApellidoMaterno,
			Nombres,
			FechaNacimiento,
			LugarNacimiento,
			Direccion,
			Celular,
			Correo,
			Estado,
			Foto
		}
		#endregion

		#region Data Members

			int _codigoComunero;
			int _sexoId;
			int _gradoInstruccionId;
			int _religionId;
			int _tipoComuneroId;
			int _estadoCivilId;
			int _tipoDocumentoId;
			int? _nroDocumentoIdentidad;
			string _apellidoPaterno;
			string _apellidoMaterno;
			string _nombres;
			DateTime? _fechaNacimiento;
			string _lugarNacimiento;
			string _direccion;
			int? _celular;
			string _correo;
			bool? _estado;
			string _foto;

		#endregion

		#region Properties

		public int  CodigoComunero
		{
			 get { return _codigoComunero; }
			 set
			 {
				 if (_codigoComunero != value)
				 {
					_codigoComunero = value;
					 PropertyHasChanged("CodigoComunero");
				 }
			 }
		}

		public int  SexoId
		{
			 get { return _sexoId; }
			 set
			 {
				 if (_sexoId != value)
				 {
					_sexoId = value;
					 PropertyHasChanged("SexoId");
				 }
			 }
		}

		public int  GradoInstruccionId
		{
			 get { return _gradoInstruccionId; }
			 set
			 {
				 if (_gradoInstruccionId != value)
				 {
					_gradoInstruccionId = value;
					 PropertyHasChanged("GradoInstruccionId");
				 }
			 }
		}

		public int  ReligionId
		{
			 get { return _religionId; }
			 set
			 {
				 if (_religionId != value)
				 {
					_religionId = value;
					 PropertyHasChanged("ReligionId");
				 }
			 }
		}

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

		public int  EstadoCivilId
		{
			 get { return _estadoCivilId; }
			 set
			 {
				 if (_estadoCivilId != value)
				 {
					_estadoCivilId = value;
					 PropertyHasChanged("EstadoCivilId");
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

		public int?  NroDocumentoIdentidad
		{
			 get { return _nroDocumentoIdentidad; }
			 set
			 {
				 if (_nroDocumentoIdentidad != value)
				 {
					_nroDocumentoIdentidad = value;
					 PropertyHasChanged("NroDocumentoIdentidad");
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

		public string  Nombres
		{
			 get { return _nombres; }
			 set
			 {
				 if (_nombres != value)
				 {
					_nombres = value;
					 PropertyHasChanged("Nombres");
				 }
			 }
		}

		public DateTime?  FechaNacimiento
		{
			 get { return _fechaNacimiento; }
			 set
			 {
				 if (_fechaNacimiento != value)
				 {
					_fechaNacimiento = value;
					 PropertyHasChanged("FechaNacimiento");
				 }
			 }
		}

		public string  LugarNacimiento
		{
			 get { return _lugarNacimiento; }
			 set
			 {
				 if (_lugarNacimiento != value)
				 {
					_lugarNacimiento = value;
					 PropertyHasChanged("LugarNacimiento");
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

		public int?  Celular
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

		public string  Correo
		{
			 get { return _correo; }
			 set
			 {
				 if (_correo != value)
				 {
					_correo = value;
					 PropertyHasChanged("Correo");
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

		public string  Foto
		{
			 get { return _foto; }
			 set
			 {
				 if (_foto != value)
				 {
					_foto = value;
					 PropertyHasChanged("Foto");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodigoComunero", "CodigoComunero"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("SexoId", "SexoId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("GradoInstruccionId", "GradoInstruccionId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ReligionId", "ReligionId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("TipoComuneroId", "TipoComuneroId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("EstadoCivilId", "EstadoCivilId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("TipoDocumentoId", "TipoDocumentoId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("ApellidoPaterno", "ApellidoPaterno",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("ApellidoMaterno", "ApellidoMaterno",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Nombres", "Nombres",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("LugarNacimiento", "LugarNacimiento",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Direccion", "Direccion",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Correo", "Correo",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Foto", "Foto",10));
		}

		#endregion

	}
}
