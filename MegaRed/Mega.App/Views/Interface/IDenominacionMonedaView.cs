using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega.App.Views.Interface
{
   public  interface IDenominacionMonedaView
    {
        string Denominacion { get; set; }
        decimal Valor { get; set; }
        int? MonedaId { get; set; }         
    }
}
