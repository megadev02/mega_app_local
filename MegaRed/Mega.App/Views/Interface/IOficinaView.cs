using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega.App.Views.Interface
{
    public interface IOficinaView
    {
        string CodigoOficina { get; set; }
        string NombreOficina { get; set; }
        string CodigoUbigeo { get; set; }
        int TipoOficina { get; set; }
        string Direccion { get; set; }
        string Telefono { get; set; }
        bool Estado { get; set; }
    }
}
