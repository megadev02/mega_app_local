using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega.Comun
{
    public class Types
    {        
        public enum TipoOficina
        {
            Propio = 1,
            Afiliado = 2
        }

        public enum EstadoOficina
        {
            Habilitado = 1,
            Deshabilitado = 0
        }
        public enum EstadoMoneda
        {
            Habilitado = 1,
            Deshabilitado = 0
        }
        public enum EstadoBanco
        {
            Habilitado = 1,
            Deshabilitado = 0
        }
        public enum EsNacional
        {
            Si = 1,
            No = 0
        }

        public enum TipoPersona
        {
            Natural = 1,
            Jurídico = 0
        }
        public enum EstadoPersona
        {
            Habilitado = 1,
            Deshabilitado = 0
        }
        public enum CreditoFiscal
        {
            Si = 1,
            No = 0
        }
        public enum CierreSerie
        {
            Habilitado = 1,
            Cerrado = 0
        }
    }
}
