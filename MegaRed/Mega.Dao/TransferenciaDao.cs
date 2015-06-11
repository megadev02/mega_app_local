using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using Mega.Bdo;
using Mega.Data;

namespace Mega.Dao
{
	/// <summary>
	/// Data access layer class for Transferencia
	/// </summary>
	public partial class TransferenciaDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public TransferenciaDao()
		{
			// Nothing for now.
		}

        #endregion

        #region Public Methods

        /// <summary>
        /// insert new row in the table
        /// </summary>
		/// <param name="businessObject">business object</param>
		/// <returns>true of successfully insert</returns>
		public bool Insert(ref TransferenciaBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.TransferenciaId;
                    Transferencia objectInDb = (from p in context.Transferencia
                                           where p.TransferenciaId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.Transferencia.Add(new Transferencia()
                        {                        
							TransferenciaId = objectBdo.TransferenciaId,
							NumeroDocumento = objectBdo.NumeroDocumento,
							CodDocumento = objectBdo.CodDocumento,
							OficinaIdProcedencia = objectBdo.OficinaIdProcedencia,
							OficinaIdDestino = objectBdo.OficinaIdDestino,
							PersonaIdSolicitante = objectBdo.PersonaIdSolicitante,
							PersonaIdBeneficiario = objectBdo.PersonaIdBeneficiario,
							FechaHoraTransferencia = objectBdo.FechaHoraTransferencia,
							MonedaId = objectBdo.MonedaId,
							Importe = objectBdo.Importe,
							DerechoTransferencia = objectBdo.DerechoTransferencia,
							DerechoTransferenciaArreglo = objectBdo.DerechoTransferenciaArreglo,
							ObsTransferencia = objectBdo.ObsTransferencia,
							FechaHoraAnulacion = objectBdo.FechaHoraAnulacion,
							UsuarioAnulacion = objectBdo.UsuarioAnulacion,
							BancoId = objectBdo.BancoId,
							NumeroCuentaBanco = objectBdo.NumeroCuentaBanco,
							ComisionBancaria = objectBdo.ComisionBancaria,
							TipoOperacionBancaria = objectBdo.TipoOperacionBancaria,
							CodigoOperacion = objectBdo.CodigoOperacion,
							EstadoOperacionBancaria = objectBdo.EstadoOperacionBancaria,
							MotivoAnulacion = objectBdo.MotivoAnulacion,
							FechaHoraPago = objectBdo.FechaHoraPago,
							CodDocumentoPago = objectBdo.CodDocumentoPago,
							NroDocumentoPago = objectBdo.NroDocumentoPago,
							ObsPagoTransferencia = objectBdo.ObsPagoTransferencia,
							Estado = objectBdo.Estado,
							FlagImpreso = objectBdo.FlagImpreso,
							CajaAperturaId = objectBdo.CajaAperturaId,
							TipoTransaccion = objectBdo.TipoTransaccion,
							ConceptoId = objectBdo.ConceptoId,
							CodigoSeguridad = objectBdo.CodigoSeguridad,
							FlagArregloCuenta = objectBdo.FlagArregloCuenta,
							FlagChequeo = objectBdo.FlagChequeo,
							FechaHoraChequeo = objectBdo.FechaHoraChequeo,
							UsuarioChequeo = objectBdo.UsuarioChequeo,
							UsuarioArregloCuenta = objectBdo.UsuarioArregloCuenta
                        });
                    
                        //elementInDb.RowVersion = elementBdo.RowVersion;                    
                    }
                
                    int num = context.SaveChanges();

                    //elementBdo.RowVersion = elementInDb.RowVersion;

                    if (num >= 1) return ret;
                    ret = false;
                    message = "Error al agregar";
                }
                return ret;
			}
			catch(Exception ex)
			{				
				throw new Exception("Transferencia::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref TransferenciaBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.TransferenciaId;
                    Transferencia objectInDb = (from p in context.Transferencia
                                           where p.TransferenciaId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.TransferenciaId = objectBdo.TransferenciaId;
						objectInDb.NumeroDocumento = objectBdo.NumeroDocumento;
						objectInDb.CodDocumento = objectBdo.CodDocumento;
						objectInDb.OficinaIdProcedencia = objectBdo.OficinaIdProcedencia;
						objectInDb.OficinaIdDestino = objectBdo.OficinaIdDestino;
						objectInDb.PersonaIdSolicitante = objectBdo.PersonaIdSolicitante;
						objectInDb.PersonaIdBeneficiario = objectBdo.PersonaIdBeneficiario;
						objectInDb.FechaHoraTransferencia = objectBdo.FechaHoraTransferencia;
						objectInDb.MonedaId = objectBdo.MonedaId;
						objectInDb.Importe = objectBdo.Importe;
						objectInDb.DerechoTransferencia = objectBdo.DerechoTransferencia;
						objectInDb.DerechoTransferenciaArreglo = objectBdo.DerechoTransferenciaArreglo;
						objectInDb.ObsTransferencia = objectBdo.ObsTransferencia;
						objectInDb.FechaHoraAnulacion = objectBdo.FechaHoraAnulacion;
						objectInDb.UsuarioAnulacion = objectBdo.UsuarioAnulacion;
						objectInDb.BancoId = objectBdo.BancoId;
						objectInDb.NumeroCuentaBanco = objectBdo.NumeroCuentaBanco;
						objectInDb.ComisionBancaria = objectBdo.ComisionBancaria;
						objectInDb.TipoOperacionBancaria = objectBdo.TipoOperacionBancaria;
						objectInDb.CodigoOperacion = objectBdo.CodigoOperacion;
						objectInDb.EstadoOperacionBancaria = objectBdo.EstadoOperacionBancaria;
						objectInDb.MotivoAnulacion = objectBdo.MotivoAnulacion;
						objectInDb.FechaHoraPago = objectBdo.FechaHoraPago;
						objectInDb.CodDocumentoPago = objectBdo.CodDocumentoPago;
						objectInDb.NroDocumentoPago = objectBdo.NroDocumentoPago;
						objectInDb.ObsPagoTransferencia = objectBdo.ObsPagoTransferencia;
						objectInDb.Estado = objectBdo.Estado;
						objectInDb.FlagImpreso = objectBdo.FlagImpreso;
						objectInDb.CajaAperturaId = objectBdo.CajaAperturaId;
						objectInDb.TipoTransaccion = objectBdo.TipoTransaccion;
						objectInDb.ConceptoId = objectBdo.ConceptoId;
						objectInDb.CodigoSeguridad = objectBdo.CodigoSeguridad;
						objectInDb.FlagArregloCuenta = objectBdo.FlagArregloCuenta;
						objectInDb.FlagChequeo = objectBdo.FlagChequeo;
						objectInDb.FechaHoraChequeo = objectBdo.FechaHoraChequeo;
						objectInDb.UsuarioChequeo = objectBdo.UsuarioChequeo;
						objectInDb.UsuarioArregloCuenta = objectBdo.UsuarioArregloCuenta;

                        //elementInDb.RowVersion = elementBdo.RowVersion;                    
                    }

                    int num = context.SaveChanges();

                    //elementBdo.RowVersion = elementInDb.RowVersion;

                    if (num >= 1) return ret;
                    ret = false;
                    message = "El elemento no fue actualizado";
                }
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception("Transferencia::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>Transferencia business object</returns>
        public TransferenciaBdo GetById(int id)
        {
            try
            {
                TransferenciaBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    Transferencia objectInDb = (from p in context.Transferencia
                                       where p.TransferenciaId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new TransferenciaBdo()
                        {
							TransferenciaId = objectInDb.TransferenciaId,
							NumeroDocumento = objectInDb.NumeroDocumento,
							CodDocumento = objectInDb.CodDocumento,
							OficinaIdProcedencia = objectInDb.OficinaIdProcedencia,
							OficinaIdDestino = objectInDb.OficinaIdDestino,
							PersonaIdSolicitante = objectInDb.PersonaIdSolicitante,
							PersonaIdBeneficiario = objectInDb.PersonaIdBeneficiario,
							FechaHoraTransferencia = objectInDb.FechaHoraTransferencia,
							MonedaId = objectInDb.MonedaId,
							Importe = objectInDb.Importe,
							DerechoTransferencia = objectInDb.DerechoTransferencia,
							DerechoTransferenciaArreglo = objectInDb.DerechoTransferenciaArreglo,
							ObsTransferencia = objectInDb.ObsTransferencia,
							FechaHoraAnulacion = objectInDb.FechaHoraAnulacion,
							UsuarioAnulacion = objectInDb.UsuarioAnulacion,
							BancoId = objectInDb.BancoId,
							NumeroCuentaBanco = objectInDb.NumeroCuentaBanco,
							ComisionBancaria = objectInDb.ComisionBancaria,
							TipoOperacionBancaria = objectInDb.TipoOperacionBancaria,
							CodigoOperacion = objectInDb.CodigoOperacion,
							EstadoOperacionBancaria = objectInDb.EstadoOperacionBancaria,
							MotivoAnulacion = objectInDb.MotivoAnulacion,
							FechaHoraPago = objectInDb.FechaHoraPago,
							CodDocumentoPago = objectInDb.CodDocumentoPago,
							NroDocumentoPago = objectInDb.NroDocumentoPago,
							ObsPagoTransferencia = objectInDb.ObsPagoTransferencia,
							Estado = objectInDb.Estado,
							FlagImpreso = objectInDb.FlagImpreso,
							CajaAperturaId = objectInDb.CajaAperturaId,
							TipoTransaccion = objectInDb.TipoTransaccion,
							ConceptoId = objectInDb.ConceptoId,
							CodigoSeguridad = objectInDb.CodigoSeguridad,
							FlagArregloCuenta = objectInDb.FlagArregloCuenta,
							FlagChequeo = objectInDb.FlagChequeo,
							FechaHoraChequeo = objectInDb.FechaHoraChequeo,
							UsuarioChequeo = objectInDb.UsuarioChequeo,
							UsuarioArregloCuenta = objectInDb.UsuarioArregloCuenta

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Transferencia::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of Transferencia</returns>
        public List<TransferenciaBdo> GetAll()
        {            
            try
            {
                
                var TransferenciaBdos = new List<TransferenciaBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.Transferencia.ToList();
                
                    TransferenciaBdos.AddRange(items.Select(item => new TransferenciaBdo()
                    {
						TransferenciaId = item.TransferenciaId,
						NumeroDocumento = item.NumeroDocumento,
						CodDocumento = item.CodDocumento,
						OficinaIdProcedencia = item.OficinaIdProcedencia,
						OficinaIdDestino = item.OficinaIdDestino,
						PersonaIdSolicitante = item.PersonaIdSolicitante,
						PersonaIdBeneficiario = item.PersonaIdBeneficiario,
						FechaHoraTransferencia = item.FechaHoraTransferencia,
						MonedaId = item.MonedaId,
						Importe = item.Importe,
						DerechoTransferencia = item.DerechoTransferencia,
						DerechoTransferenciaArreglo = item.DerechoTransferenciaArreglo,
						ObsTransferencia = item.ObsTransferencia,
						FechaHoraAnulacion = item.FechaHoraAnulacion,
						UsuarioAnulacion = item.UsuarioAnulacion,
						BancoId = item.BancoId,
						NumeroCuentaBanco = item.NumeroCuentaBanco,
						ComisionBancaria = item.ComisionBancaria,
						TipoOperacionBancaria = item.TipoOperacionBancaria,
						CodigoOperacion = item.CodigoOperacion,
						EstadoOperacionBancaria = item.EstadoOperacionBancaria,
						MotivoAnulacion = item.MotivoAnulacion,
						FechaHoraPago = item.FechaHoraPago,
						CodDocumentoPago = item.CodDocumentoPago,
						NroDocumentoPago = item.NroDocumentoPago,
						ObsPagoTransferencia = item.ObsPagoTransferencia,
						Estado = item.Estado,
						FlagImpreso = item.FlagImpreso,
						CajaAperturaId = item.CajaAperturaId,
						TipoTransaccion = item.TipoTransaccion,
						ConceptoId = item.ConceptoId,
						CodigoSeguridad = item.CodigoSeguridad,
						FlagArregloCuenta = item.FlagArregloCuenta,
						FlagChequeo = item.FlagChequeo,
						FechaHoraChequeo = item.FechaHoraChequeo,
						UsuarioChequeo = item.UsuarioChequeo,
						UsuarioArregloCuenta = item.UsuarioArregloCuenta

                    }));
                }
                return TransferenciaBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("Transferencia::GetAll::Error occured.", ex);
            }            
        }

        public List<TransferenciaBdo> GetAllBy(string fieldName, object value)
        {
            var TransferenciaBdos = new List<TransferenciaBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM Transferencia WHERE {0} = {1} ";

                    var items = context.Transferencia.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    TransferenciaBdos.AddRange(items.Select(item => new TransferenciaBdo()
                    {
						TransferenciaId = item.TransferenciaId,
						NumeroDocumento = item.NumeroDocumento,
						CodDocumento = item.CodDocumento,
						OficinaIdProcedencia = item.OficinaIdProcedencia,
						OficinaIdDestino = item.OficinaIdDestino,
						PersonaIdSolicitante = item.PersonaIdSolicitante,
						PersonaIdBeneficiario = item.PersonaIdBeneficiario,
						FechaHoraTransferencia = item.FechaHoraTransferencia,
						MonedaId = item.MonedaId,
						Importe = item.Importe,
						DerechoTransferencia = item.DerechoTransferencia,
						DerechoTransferenciaArreglo = item.DerechoTransferenciaArreglo,
						ObsTransferencia = item.ObsTransferencia,
						FechaHoraAnulacion = item.FechaHoraAnulacion,
						UsuarioAnulacion = item.UsuarioAnulacion,
						BancoId = item.BancoId,
						NumeroCuentaBanco = item.NumeroCuentaBanco,
						ComisionBancaria = item.ComisionBancaria,
						TipoOperacionBancaria = item.TipoOperacionBancaria,
						CodigoOperacion = item.CodigoOperacion,
						EstadoOperacionBancaria = item.EstadoOperacionBancaria,
						MotivoAnulacion = item.MotivoAnulacion,
						FechaHoraPago = item.FechaHoraPago,
						CodDocumentoPago = item.CodDocumentoPago,
						NroDocumentoPago = item.NroDocumentoPago,
						ObsPagoTransferencia = item.ObsPagoTransferencia,
						Estado = item.Estado,
						FlagImpreso = item.FlagImpreso,
						CajaAperturaId = item.CajaAperturaId,
						TipoTransaccion = item.TipoTransaccion,
						ConceptoId = item.ConceptoId,
						CodigoSeguridad = item.CodigoSeguridad,
						FlagArregloCuenta = item.FlagArregloCuenta,
						FlagChequeo = item.FlagChequeo,
						FechaHoraChequeo = item.FechaHoraChequeo,
						UsuarioChequeo = item.UsuarioChequeo,
						UsuarioArregloCuenta = item.UsuarioArregloCuenta

                    }));
                }

                return TransferenciaBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("Transferencia::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
