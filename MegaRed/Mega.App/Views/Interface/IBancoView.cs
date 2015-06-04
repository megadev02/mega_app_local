using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega.App.Views.Interface
{
    public interface IBancoView
    {
        
        int? EntidadId { get; set; }
        string Direccion { get; set; }
        string  CodigoUbigeo { get; set; }
        string  Telefono1 { get; set; }
        string Telefono2 { get; set; }
        string Telefono3 { get; set; }
        bool? Estado { get; set; }
    }
}
