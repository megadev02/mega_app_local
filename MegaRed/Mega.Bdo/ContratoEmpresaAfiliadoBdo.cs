using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class ContratoEmpresaAfiliadoBdo : BdoObjectBase
	{

		#region InnerClass
		public enum ContratoEmpresaAfiliadoFields
		{
			ContratoId,
			CodigoOficina,
			EmpresaAfiliadaId,
			ComisionDTDirecto,
			ComisionDTAfiliado,
			Garantia,
			FechaContrato,
			Estado,
			SujetoVariacionArreglo
		}
		#endregion

		#region Data Members

			int _contratoId;
			string _codigoOficina;
			int _empresaAfiliadaId;
			int _comisionDTDirecto;
			int _comisionDTAfiliado;
			decimal _garantia;
			DateTime _fechaContrato;
			bool _estado;
			bool _sujetoVariacionArreglo;

		#endregion

		#region Properties

		public int  ContratoId
		{
			 get { return _contratoId; }
			 set
			 {
				 if (_contratoId != value)
				 {
					_contratoId = value;
					 PropertyHasChanged("ContratoId");
				 }
			 }
		}

		public string  CodigoOficina
		{
			 get { return _codigoOficina; }
			 set
			 {
				 if (_codigoOficina != value)
				 {
					_codigoOficina = value;
					 PropertyHasChanged("CodigoOficina");
				 }
			 }
		}

		public int  EmpresaAfiliadaId
		{
			 get { return _empresaAfiliadaId; }
			 set
			 {
				 if (_empresaAfiliadaId != value)
				 {
					_empresaAfiliadaId = value;
					 PropertyHasChanged("EmpresaAfiliadaId");
				 }
			 }
		}

		public int  ComisionDTDirecto
		{
			 get { return _comisionDTDirecto; }
			 set
			 {
				 if (_comisionDTDirecto != value)
				 {
					_comisionDTDirecto = value;
					 PropertyHasChanged("ComisionDTDirecto");
				 }
			 }
		}

		public int  ComisionDTAfiliado
		{
			 get { return _comisionDTAfiliado; }
			 set
			 {
				 if (_comisionDTAfiliado != value)
				 {
					_comisionDTAfiliado = value;
					 PropertyHasChanged("ComisionDTAfiliado");
				 }
			 }
		}

		public decimal  Garantia
		{
			 get { return _garantia; }
			 set
			 {
				 if (_garantia != value)
				 {
					_garantia = value;
					 PropertyHasChanged("Garantia");
				 }
			 }
		}

		public DateTime  FechaContrato
		{
			 get { return _fechaContrato; }
			 set
			 {
				 if (_fechaContrato != value)
				 {
					_fechaContrato = value;
					 PropertyHasChanged("FechaContrato");
				 }
			 }
		}

		public bool  Estado
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

		public bool  SujetoVariacionArreglo
		{
			 get { return _sujetoVariacionArreglo; }
			 set
			 {
				 if (_sujetoVariacionArreglo != value)
				 {
					_sujetoVariacionArreglo = value;
					 PropertyHasChanged("SujetoVariacionArreglo");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ContratoId", "ContratoId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodigoOficina", "CodigoOficina"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoOficina", "CodigoOficina",10));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("EmpresaAfiliadaId", "EmpresaAfiliadaId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ComisionDTDirecto", "ComisionDTDirecto"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ComisionDTAfiliado", "ComisionDTAfiliado"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Garantia", "Garantia"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("FechaContrato", "FechaContrato"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Estado", "Estado"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("SujetoVariacionArreglo", "SujetoVariacionArreglo"));
		}

		#endregion

	}
}
