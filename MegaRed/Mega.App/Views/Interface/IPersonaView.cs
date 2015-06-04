using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega.App.Views.Interface
{
    public  interface IPersonaView
    {
      string CodigoPersona { get; set; }
      int  TipoPersona{ get; set; }
      string RazonSocial{ get; set; }
      string PrimerNombre{ get; set; }
      string SegundoNombre{ get; set; }
      string ApellidoPaterno{ get; set; }
      string ApellidoMaterno{ get; set; }
      int TipoDocumentoId{ get; set; }
      string NumeroDocumento{ get; set; }
      string CodigoUbigeo{ get; set; }
      string DireccionDomicilio{ get; set; }
      string Telefono{ get; set; }
      string Celular{ get; set; }
      string Email{ get; set; }
      string Web{ get; set; }
      bool? Estado{ get; set; }
    }
}
