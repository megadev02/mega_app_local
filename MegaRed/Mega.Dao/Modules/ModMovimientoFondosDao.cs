using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mega.Bdo;
using Mega.Bdo.Modules;
using Mega.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Mega.Dao.Modules
{
    public class ModMovimientoFondosDao
    {
        public bool Insert(ref ModMovimientoFondosBdo objectBdo, ref string message)
        {
            message = "Agregado correctamente";
            bool ret = true;
            try
            {
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.MovimientoFondosBdo.MovimientoFondosId;

                    MovimientoFondos objectInDb = (from p in context.MovimientoFondos
                                           where p.MovimientoFondosId == objectId
                                           select p).FirstOrDefault();

                    if (objectInDb == null)
                    {
                        var movimientoFondos = objectBdo.MovimientoFondosBdo;
                        var movFon = context.MovimientoFondos.Add(new MovimientoFondos
                        {
                            NumeroDocumento = movimientoFondos.NumeroDocumento,
                            CodDocumento = movimientoFondos.CodDocumento,
                            Importe = movimientoFondos.Importe,
                            OficinaIdProcedencia = movimientoFondos.OficinaIdProcedencia,
                            OficinaIdDestino = movimientoFondos.OficinaIdDestino,
                            CodigoPersona = movimientoFondos.CodigoPersona,
                            BancoId = movimientoFondos.BancoId,
                            NumeroCuentaBanco = movimientoFondos.NumeroCuentaBanco,
                            CodigoVoucher = movimientoFondos.CodigoVoucher,
                            NumeroOperacion = movimientoFondos.NumeroOperacion,
                            CajaAperturaId = movimientoFondos.CajaAperturaId,
                            ConceptoId = movimientoFondos.ConceptoId,
                            MonedaId = movimientoFondos.MonedaId,
                            TipoMovimiento = movimientoFondos.TipoMovimiento,
                            FechaHoraTransaccion = movimientoFondos.FechaHoraTransaccion                            
                        });

                        //int num = context.SaveChanges();

                        //if (num >= 1)
                        {
                            //ingresos/egresos
                            foreach (var rc in objectBdo.ListReciboCaja)
                            {
                                context.ReciboCaja.Add(new ReciboCaja
                                {
                                    NumeroDocumento = rc.NumeroDocumento,
                                    CajaAperturaId = rc.CajaAperturaId,
                                    CodDocumento = rc.CodDocumento,
                                    TipoRecibo = rc.TipoRecibo,
                                    MonedaId = rc.MonedaId,
                                    Importe = rc.Importe,
                                    ConceptoId = rc.ConceptoId,
                                    Concepto = rc.Concepto,
                                    MovimientoFondos = movFon
                                });
                            }                                                        
                        }

                        int num = context.SaveChanges();

                        if (num >= 1) return ret;
                        ret = false;
                        message = "Error al agregar";
                    }
                }
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception("Movimiento de fondos::Insert::Error occured.", ex);
            }
        }

        public ModMovimientoFondosBdo GetById(int id)
        {
            try
            {
                var modMovFondos = new ModMovimientoFondosBdo();
                using (var context = new MegaEntities())
                {
                    MovimientoFondos objectInDb = (from p in context.MovimientoFondos
                                                where p.MovimientoFondosId == id
                                                select p).FirstOrDefault();

                    if (objectInDb != null)
                    {
                        modMovFondos.MovimientoFondosBdo = new MovimientoFondosBdo()
                        {
                            MovimientoFondosId = objectInDb.MovimientoFondosId,
                            NumeroDocumento = objectInDb.NumeroDocumento,
                            CodDocumento = objectInDb.CodDocumento,
                            Importe = objectInDb.Importe,
                            OficinaIdProcedencia = objectInDb.OficinaIdProcedencia,
                            OficinaIdDestino = objectInDb.OficinaIdDestino,
                            CodigoPersona = objectInDb.CodigoPersona,
                            BancoId = objectInDb.BancoId,
                            NumeroCuentaBanco = objectInDb.NumeroCuentaBanco,
                            CodigoVoucher = objectInDb.CodigoVoucher,
                            NumeroOperacion = objectInDb.NumeroOperacion,
                            CajaAperturaId = objectInDb.CajaAperturaId,
                            FechaHoraAnulacion = objectInDb.FechaHoraAnulacion,
                            Estado = objectInDb.Estado,
                            UsuarioAnulacion = objectInDb.UsuarioAnulacion,
                            ConceptoId = objectInDb.ConceptoId,
                            MonedaId = objectInDb.MonedaId,
                            TipoMovimiento = objectInDb.TipoMovimiento,
                            FechaHoraTransaccion = objectInDb.FechaHoraTransaccion,
                            CodDocumentoDescargo = objectInDb.CodDocumentoDescargo,
                            NroDocumentoDescargo = objectInDb.NroDocumentoDescargo,
                            FechaHoraDescargo = objectInDb.FechaHoraDescargo,
                            FlagImpreso = objectInDb.FlagImpreso,
                            Observacion = objectInDb.Observacion
                        };

                        var recibos = (from m in context.ReciboCaja
                                       where m.MovimientoFondosId == modMovFondos.MovimientoFondosBdo.MovimientoFondosId
                                       select m);

                        modMovFondos.ListReciboCaja.AddRange(recibos.Select(r => new ReciboCajaBdo
                        {
                            ReciboCajaId = r.ReciboCajaId,
                            NumeroDocumento = r.NumeroDocumento,
                            CajaAperturaId = r.CajaAperturaId,
                            CodDocumento = r.CodDocumento,
                            TipoRecibo = r.TipoRecibo,
                            MonedaId = r.MonedaId,
                            Importe = r.Importe,
                            FechaHoraTransaccion = r.FechaHoraTransaccion,
                            CodigoPersona = r.CodigoPersona,
                            Concepto = r.Concepto,
                            FlagImpreso = r.FlagImpreso,
                            ObsRecibo = r.ObsRecibo,
                            FechaHoraAnulacion = r.FechaHoraAnulacion,
                            UsuarioAnulacion = r.UsuarioAnulacion,
                            ComprobanteCompraId = r.ComprobanteCompraId,
                            Estado = r.Estado,
                            ConceptoId = r.ConceptoId,
                            CodigoOficinaProcedencia = r.CodigoOficinaProcedencia,
                            MovimientoFondosId = r.MovimientoFondosId
                        }));
                    }
                }
                return modMovFondos;
            }
            catch (Exception ex)
            {
                throw new Exception("Transferencia::GetById::Error occured.", ex);
            }
        }

        public DataTable GetSearchMovFondos()
        {
            try
            {
                var dt = new DataTable();
                using (var context = new MegaEntities())
                {
                    var query =
                    @"SELECT A.MovimientoFondosId, A.CodDocumento, A.NumeroDocumento, 
		                A.OficinaIdProcedencia, A.OficinaIdDestino, 
		                B.ApellidoPaterno + ' ' + B.ApellidoMaterno + ' ' + B.PrimerNombre + ' '+ B.SegundoNombre AS 'NombrePersona',
		                D.Nombre As 'NombreEntidad', C.Direccion As 'DirEntidad'
	                FROM MovimientoFondos A LEFT JOIN Persona B ON A.CodigoPersona = B.CodigoPersona
		                LEFT JOIN Banco C ON A.BancoId = C.BancoId
		                LEFT JOIN EntidadFinanciera D ON C.EntidadId = D.EntidadId";

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
