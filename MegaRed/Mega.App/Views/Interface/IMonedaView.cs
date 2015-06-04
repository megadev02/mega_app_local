using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega.App.Views.Interface
{
    public interface IMonedaView
    {
        
        string Nombre { get; set; }
        string Simbolo { get; set; }
        string Abreviatura { get; set; }
        string Referencia { get; set; }
        bool EsNacional { get; set; }
        bool Estado { get; set; }
    }
}
