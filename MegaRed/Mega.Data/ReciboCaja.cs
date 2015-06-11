//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mega.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReciboCaja
    {
        public int ReciboCajaId { get; set; }
        public Nullable<int> NumeroDocumento { get; set; }
        public Nullable<int> CajaAperturaId { get; set; }
        public string CodDocumento { get; set; }
        public Nullable<int> TipoRecibo { get; set; }
        public Nullable<int> MonedaId { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public Nullable<System.DateTime> FechaHoraTransaccion { get; set; }
        public string CodigoPersona { get; set; }
        public string Concepto { get; set; }
        public Nullable<bool> FlagImpreso { get; set; }
        public string ObsRecibo { get; set; }
        public Nullable<System.DateTime> FechaHoraAnulacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public Nullable<int> ComprobanteCompraId { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<int> ConceptoId { get; set; }
        public string CodigoOficinaProcedencia { get; set; }
        public Nullable<int> MovimientoFondosId { get; set; }
    
        public virtual CajaApertura CajaApertura { get; set; }
        public virtual ComprobanteCompra ComprobanteCompra { get; set; }
        public virtual Concepto Concepto1 { get; set; }
        public virtual Documento Documento { get; set; }
        public virtual Moneda Moneda { get; set; }
        public virtual MovimientoFondos MovimientoFondos { get; set; }
        public virtual Oficina Oficina { get; set; }
        public virtual Persona Persona { get; set; }
    }
}
