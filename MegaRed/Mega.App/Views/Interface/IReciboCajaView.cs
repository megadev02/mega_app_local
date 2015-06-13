using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega.App.Views.Interface
{
    public interface IReciboCajaView
    {
        int ReciboCajaId { get; set; }
        string CodDocumento { get; set; }
        int NumeroDocumento { get; set; }
        string Concepto { get; set; }
        decimal Importe { get; set; }
        int MovimientoFondoId { get; set; }
    }
}
