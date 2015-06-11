using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using Mega.Bdo;
using Mega.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Mega.Dao
{
	/// <summary>
	/// Data access layer class for Persona
	/// </summary>
	public partial class PersonaDao
	{
        public DataTable GetSearchPersona()
        {
            try
            {
                var dt = new DataTable();
                using (var context = new MegaEntities())
                {
                    var query =
                    @"SELECT CodigoPersona AS Id, CodigoPersona AS Code, TipoPersona, RazonSocial, PrimerNombre, SegundoNombre, ApellidoPaterno, ApellidoMaterno, NumeroDocumento, 
                         SegundoNombre + ' ' + PrimerNombre + ' ' + PrimerNombre + ' ' + SegundoNombre AS Name, 
                         NumeroDocumento + ' - ' + SegundoNombre + ' ' + PrimerNombre + ' ' + PrimerNombre + ' ' + SegundoNombre AS TextSearch
                        FROM Persona";

                    var dataSet = SqlHelper.ExecuteDataset(context.Database.Connection.ConnectionString, CommandType.Text,
                        query);

                    dt = dataSet.Tables[0];
                }
                return dt;
            }
            catch (Exception exception)
            {
                throw new Exception("MovimientoFondos:Select:", exception);
            }
        }
	}
}
