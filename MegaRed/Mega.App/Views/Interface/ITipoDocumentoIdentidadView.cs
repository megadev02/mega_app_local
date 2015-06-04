using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Accessibility;

namespace Mega.App.Views.Interface
{
    public interface ITipoDocumentoIdentidadView
    {
        string Denominacion { get; set; }
        string Abreviatura { get; set; }
    }
}
