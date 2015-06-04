using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega.App.Views.Interface
{
    public interface ISerieView
    {

        string CodComprobante { get; set; }
        int NumeroSerie { get; set; }
        int NumeroDigitos { get; set; }
        bool CierreSerie { get; set; }
        string CodigoOficina { get; set; }
    }
}
