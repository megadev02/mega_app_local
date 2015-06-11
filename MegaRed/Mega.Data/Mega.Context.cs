﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class MegaEntities : DbContext
    {
        public MegaEntities()
            : base("name=MegaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Accesos> Accesos { get; set; }
        public DbSet<ArqueoCaja> ArqueoCaja { get; set; }
        public DbSet<Asiento> Asiento { get; set; }
        public DbSet<AsientoDetalle> AsientoDetalle { get; set; }
        public DbSet<Banco> Banco { get; set; }
        public DbSet<Caja> Caja { get; set; }
        public DbSet<CajaApertura> CajaApertura { get; set; }
        public DbSet<CambioMoneda> CambioMoneda { get; set; }
        public DbSet<Comprobante> Comprobante { get; set; }
        public DbSet<ComprobanteCompra> ComprobanteCompra { get; set; }
        public DbSet<Concepto> Concepto { get; set; }
        public DbSet<ContratoEmpresaAfiliado> ContratoEmpresaAfiliado { get; set; }
        public DbSet<CuentaBancaria> CuentaBancaria { get; set; }
        public DbSet<DenominacionMoneda> DenominacionMoneda { get; set; }
        public DbSet<DepositoPrestamo> DepositoPrestamo { get; set; }
        public DbSet<Documento> Documento { get; set; }
        public DbSet<EmpresaAfiliada> EmpresaAfiliada { get; set; }
        public DbSet<EntidadFinanciera> EntidadFinanciera { get; set; }
        public DbSet<Moneda> Moneda { get; set; }
        public DbSet<Oficina> Oficina { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<PersonaDetalle> PersonaDetalle { get; set; }
        public DbSet<PlanContable> PlanContable { get; set; }
        public DbSet<Serie> Serie { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<TipoCambio> TipoCambio { get; set; }
        public DbSet<TipoComunero> TipoComunero { get; set; }
        public DbSet<TipoDocumentoIdentidad> TipoDocumentoIdentidad { get; set; }
        public DbSet<Transferencia> Transferencia { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<MovimientoFondos> MovimientoFondos { get; set; }
        public DbSet<ReciboCaja> ReciboCaja { get; set; }
    
        public virtual ObjectResult<spSearchMovFondos_Result> spSearchMovFondos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSearchMovFondos_Result>("spSearchMovFondos");
        }
    }
}
