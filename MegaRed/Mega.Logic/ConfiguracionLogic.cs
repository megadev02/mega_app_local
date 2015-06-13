using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mega.Bdo;
using Mega.Comun;

namespace Mega.Logic
{
    public class ConfiguracionLogic
    {        
        public List<DocumentoBdo> GetListCodDocumentByModule(string moduleName)
        {
            var listDocument = new List<DocumentoBdo>();

            if (moduleName ==  Constantes.MODULE_INGRESO_FONDOS)
            {
                //extracción desde la base de datos
                listDocument.Add(new DocumentoBdo{CodDocumento = "IF"});
            }
            else if (moduleName == Constantes.MODULE_EGRESO_FONDOS)
            {
                //extracción desde la base de datos
                listDocument.Add(new DocumentoBdo{CodDocumento = "EF"});
            }
            else if (moduleName == Constantes.MODULE_RECIBO_INGRESO)
            {
                //extracción desde la base de datos
                listDocument.Add(new DocumentoBdo{CodDocumento = "RI"});
            }
            else if (moduleName == Constantes.MODULE_RECIBO_EGRESO)
            {
                //extracción desde la base de datos
                listDocument.Add(new DocumentoBdo{CodDocumento = "RE"});
            }
            return listDocument;
        }
    }
}
