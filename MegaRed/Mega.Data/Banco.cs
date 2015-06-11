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
    
    public partial class Banco
    {
        public Banco()
        {
            this.Transferencia = new HashSet<Transferencia>();
            this.MovimientoFondos = new HashSet<MovimientoFondos>();
        }
    
        public int BancoId { get; set; }
        public Nullable<int> EntidadId { get; set; }
        public string Direccion { get; set; }
        public string CodigoUbigeo { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        public virtual EntidadFinanciera EntidadFinanciera { get; set; }
        public virtual ICollection<Transferencia> Transferencia { get; set; }
        public virtual ICollection<MovimientoFondos> MovimientoFondos { get; set; }
    }
}
