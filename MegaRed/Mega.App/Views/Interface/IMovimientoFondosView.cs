using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mega.Bdo;

namespace Mega.App.Views.Interface
{
    public interface IMovimientoFondosView
    {
        int MovimientoFondosId { get; set; }
        int? NumeroDocumento { get; set; }
        string CodDocumento { get; set; }
        decimal? Importe { get; set; }
        string OficinaIdProcedencia { get; set; }
        string OficinaIdDestino { get; set; }
        string CodigoPersona { get; set; }
        int? BancoId { get; set; }
        int? NumeroCuentaBanco { get; set; }
        string CodigoVoucher { get; set; }
        string NumeroOperacion { get; set; }
        int? CajaAperturaId { get; set; }
        DateTime? FechaHoraAnulacion { get; set; }
        int? Estado { get; set; }
        string UsuarioAnulacion { get; set; }
        int? ConceptoId { get; set; }
        int? MonedaId { get; set; }
        int? TipoMovimiento { get; set; }
        DateTime? FechaHoraTransaccion { get; set; }
        string CodDocumentoDescargo { get; set; }
        int? NroDocumentoDescargo { get; set; }
        DateTime? FechaHoraDescargo { get; set; }
        bool FlagImpreso { get; set; }
        string Observacion { get; set; }

        BindingList<ReciboCajaBdo> ListRecibos { get; set; }
    }
}
