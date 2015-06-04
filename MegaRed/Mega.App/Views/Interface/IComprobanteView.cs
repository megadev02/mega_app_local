using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega.App.Views.Interface
{
    public interface IComprobanteView
    {
        string CodComprobante { get; set; }
        string NombreComprobante { get; set; }
        bool CreditoFiscal { get; set; }
    }
}
