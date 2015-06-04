using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class CajaAperturaBdo : BdoObjectBase
	{

		#region InnerClass
		public enum CajaAperturaFields
		{
			CajaAperturaId,
			CajaId,
			FechaTrabajo,
			UsuarioId,
			FechaHoraApertura,
			MontoAperturaS,
			MontoAperturaD,
			MontoCierreS,
			MontoCierreD,
			FechaHoraArqueo,
			FlagCerrado,
			Observacion
		}
		#endregion

		#region Data Members

			int _cajaAperturaId;
			int? _cajaId;
			DateTime? _fechaTrabajo;
			string _usuarioId;
			DateTime? _fechaHoraApertura;
			decimal? _montoAperturaS;
			decimal? _montoAperturaD;
			decimal? _montoCierreS;
			decimal? _montoCierreD;
			DateTime? _fechaHoraArqueo;
			bool _flagCerrado;
			string _observacion;

		#endregion

		#region Properties

		public int  CajaAperturaId
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

		public int?  CajaId
		{
			 get { return _cajaId; }
			 set
			 {
				 if (_cajaId != value)
				 {
					_cajaId = value;
					 PropertyHasChanged("CajaId");
				 }
			 }
		}

		public DateTime?  FechaTrabajo
		{
			 get { return _fechaTrabajo; }
			 set
			 {
				 if (_fechaTrabajo != value)
				 {
					_fechaTrabajo = value;
					 PropertyHasChanged("FechaTrabajo");
				 }
			 }
		}

		public string  UsuarioId
		{
			 get { return _usuarioId; }
			 set
			 {
				 if (_usuarioId != value)
				 {
					_usuarioId = value;
					 PropertyHasChanged("UsuarioId");
				 }
			 }
		}

		public DateTime?  FechaHoraApertura
		{
			 get { return _fechaHoraApertura; }
			 set
			 {
				 if (_fechaHoraApertura != value)
				 {
					_fechaHoraApertura = value;
					 PropertyHasChanged("FechaHoraApertura");
				 }
			 }
		}

		public decimal?  MontoAperturaS
		{
			 get { return _montoAperturaS; }
			 set
			 {
				 if (_montoAperturaS != value)
				 {
					_montoAperturaS = value;
					 PropertyHasChanged("MontoAperturaS");
				 }
			 }
		}

		public decimal?  MontoAperturaD
		{
			 get { return _montoAperturaD; }
			 set
			 {
				 if (_montoAperturaD != value)
				 {
					_montoAperturaD = value;
					 PropertyHasChanged("MontoAperturaD");
				 }
			 }
		}

		public decimal?  MontoCierreS
		{
			 get { return _montoCierreS; }
			 set
			 {
				 if (_montoCierreS != value)
				 {
					_montoCierreS = value;
					 PropertyHasChanged("MontoCierreS");
				 }
			 }
		}

		public decimal?  MontoCierreD
		{
			 get { return _montoCierreD; }
			 set
			 {
				 if (_montoCierreD != value)
				 {
					_montoCierreD = value;
					 PropertyHasChanged("MontoCierreD");
				 }
			 }
		}

		public DateTime?  FechaHoraArqueo
		{
			 get { return _fechaHoraArqueo; }
			 set
			 {
				 if (_fechaHoraArqueo != value)
				 {
					_fechaHoraArqueo = value;
					 PropertyHasChanged("FechaHoraArqueo");
				 }
			 }
		}

		public bool  FlagCerrado
		{
			 get { return _flagCerrado; }
			 set
			 {
				 if (_flagCerrado != value)
				 {
					_flagCerrado = value;
					 PropertyHasChanged("FlagCerrado");
				 }
			 }
		}

		public string  Observacion
		{
			 get { return _observacion; }
			 set
			 {
				 if (_observacion != value)
				 {
					_observacion = value;
					 PropertyHasChanged("Observacion");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CajaAperturaId", "CajaAperturaId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("UsuarioId", "UsuarioId",20));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("FlagCerrado", "FlagCerrado"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Observacion", "Observacion",50));
		}

		#endregion

	}
}
