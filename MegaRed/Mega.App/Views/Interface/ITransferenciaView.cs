using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega.App.Views.Interface
{
    public enum TipoShowView
    {
        Origen,
        Destino,
        Central
    }
    
    public interface ITransferenciaView
    {
        TipoShowView TipoView { get; set; }
        int NumeroDocumento { get; set; }
        string CodDocumento { get; set; }
        string OficinaIdProcedencia { get; set; }
        string OficinaIdDestino { get; set; }
        string PersonaIdSolicitante { get; set; }
        string PersonaIdBeneficiario { get; set; }
        DateTime? FechaHoraTransferencia { get; set; }
        int MonedaId { get; set; }
        decimal Importe { get; set; }
        decimal DerechoTransferencia { get; set; }
        decimal DerechoTransferenciaArreglo { get; set; }
        string ObsTransferencia { get; set; }
        DateTime? FechaHoraAnulacion { get; set; }
        string UsuarioAnulacion { get; set; }
        int? BancoId { get; set; }
        string NumeroCuentaBanco { get; set; }
        decimal? ComisionBancaria { get; set; }
        int? TipoOperacionBancaria { get; set; }
        string CodigoOperacion { get; set; }
        int? EstadoOperacionBancaria { get; set; }
        string MotivoAnulacion { get; set; }
        DateTime? FechaHoraPago { get; set; }
        string CodDocumentoPago { get; set; }
        int? NroDocumentoPago { get; set; }
        string ObsPagoTransferencia { get; set; }
        int? Estado { get; set; }
        bool? FlagImpreso { get; set; }
        int? CajaAperturaId { get; set; }
        int? TipoTransaccion { get; set; }
        int? ConceptoId { get; set; }
        string CodigoSeguridad { get; set; }
        bool FlagArregloCuenta { get; set; }
        bool FlagChequeo { get; set; }
        DateTime? FechaHoraChequeo { get; set; }
        string UsuarioChequeo { get; set; }
        string UsuarioArregloCuenta { get; set; }
    }
}
