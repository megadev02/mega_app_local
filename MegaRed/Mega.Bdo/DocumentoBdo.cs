using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class DocumentoBdo : BdoObjectBase
	{

		#region InnerClass
		public enum DocumentoFields
		{
			CodDocumento,
			CodComprobante,
			NombreDocumento,
			ProcesoAsociado,
			FormatoImpresion,
			PrimerDocumento,
			Estado
		}
		#endregion

		#region Data Members

			string _codDocumento;
			string _codComprobante;
			string _nombreDocumento;
			string _procesoAsociado;
			string _formatoImpresion;
			int _primerDocumento;
			bool? _estado;

		#endregion

		#region Properties

		public string  CodDocumento
		{
			 get { return _codDocumento; }
			 set
			 {
				 if (_codDocumento != value)
				 {
					_codDocumento = value;
					 PropertyHasChanged("CodDocumento");
				 }
			 }
		}

		public string  CodComprobante
		{
			 get { return _codComprobante; }
			 set
			 {
				 if (_codComprobante != value)
				 {
					_codComprobante = value;
					 PropertyHasChanged("CodComprobante");
				 }
			 }
		}

		public string  NombreDocumento
		{
			 get { return _nombreDocumento; }
			 set
			 {
				 if (_nombreDocumento != value)
				 {
					_nombreDocumento = value;
					 PropertyHasChanged("NombreDocumento");
				 }
			 }
		}

		public string  ProcesoAsociado
		{
			 get { return _procesoAsociado; }
			 set
			 {
				 if (_procesoAsociado != value)
				 {
					_procesoAsociado = value;
					 PropertyHasChanged("ProcesoAsociado");
				 }
			 }
		}

		public string  FormatoImpresion
		{
			 get { return _formatoImpresion; }
			 set
			 {
				 if (_formatoImpresion != value)
				 {
					_formatoImpresion = value;
					 PropertyHasChanged("FormatoImpresion");
				 }
			 }
		}

		public int  PrimerDocumento
		{
			 get { return _primerDocumento; }
			 set
			 {
				 if (_primerDocumento != value)
				 {
					_primerDocumento = value;
					 PropertyHasChanged("PrimerDocumento");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodDocumento", "CodDocumento"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodDocumento", "CodDocumento",6));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CodComprobante", "CodComprobante"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodComprobante", "CodComprobante",2));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("NombreDocumento", "NombreDocumento",80));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("ProcesoAsociado", "ProcesoAsociado",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("FormatoImpresion", "FormatoImpresion",50));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PrimerDocumento", "PrimerDocumento"));
		}

		#endregion

	}
}
