using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mega.Bdo;

namespace Mega.App
{        

    #region Mensajes de objetos de la base de datos
        
    public class CMsgTransferencia
    {
        public string CodOfDestino { get; set; }
        public string MsgId {
            get
            {
                if (Transferencia != null)
                {
                    const string formatoCodigo = "{0}-{1}-{2}";
                    return string.Format(formatoCodigo, Transferencia.OficinaIdProcedencia, Transferencia.CodDocumento,
                        Transferencia.NumeroDocumento);
                }
                return "";
            }
        }
        public PersonaBdo Solicitante { get; set; }
        public PersonaBdo Beneficiario { get; set; }
        public TransferenciaBdo Transferencia { get; set; }
    }

    public class CMsgPersona
    {
        public string CodOfDestino { get; set; }
        public PersonaBdo Persona { get; set; }
    }

    public class CMsgOficina
    {
        public string CodOfDestino { get; set; }
        public OficinaBdo Oficina { get; set; }
    }

    #endregion

    #region Mensajes de confirmación de objetos de la base de datos
    
    

    #endregion
}
