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
	/// Data access layer class for MovimientoFondos
	/// </summary>
	public partial class MovimientoFondosDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public MovimientoFondosDao()
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
		public bool Insert(ref MovimientoFondosBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.MovimientoFondosId;
                    MovimientoFondos objectInDb = (from p in context.MovimientoFondos
                                           where p.MovimientoFondosId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.MovimientoFondos.Add(new MovimientoFondos()
                        {                        
							MovimientoFondosId = objectBdo.MovimientoFondosId,
							NumeroDocumento = objectBdo.NumeroDocumento,
							CodDocumento = objectBdo.CodDocumento,
							Importe = objectBdo.Importe,
							OficinaIdProcedencia = objectBdo.OficinaIdProcedencia,
							OficinaIdDestino = objectBdo.OficinaIdDestino,
							CodigoPersona = objectBdo.CodigoPersona,
							BancoId = objectBdo.BancoId,
							NumeroCuentaBanco = objectBdo.NumeroCuentaBanco,
							CodigoVoucher = objectBdo.CodigoVoucher,
							NumeroOperacion = objectBdo.NumeroOperacion,
							CajaAperturaId = objectBdo.CajaAperturaId,
							FechaHoraAnulacion = objectBdo.FechaHoraAnulacion,
							Estado = objectBdo.Estado,
							UsuarioAnulacion = objectBdo.UsuarioAnulacion,
							ConceptoId = objectBdo.ConceptoId,
							MonedaId = objectBdo.MonedaId,
							TipoMovimiento = objectBdo.TipoMovimiento,
							FechaHoraTransaccion = objectBdo.FechaHoraTransaccion,
							CodDocumentoDescargo = objectBdo.CodDocumentoDescargo,
							NroDocumentoDescargo = objectBdo.NroDocumentoDescargo,
							FechaHoraDescargo = objectBdo.FechaHoraDescargo,
							FlagImpreso = objectBdo.FlagImpreso,
							Observacion = objectBdo.Observacion

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
				throw new Exception("MovimientoFondos::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref MovimientoFondosBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.MovimientoFondosId;
                    MovimientoFondos objectInDb = (from p in context.MovimientoFondos
                                           where p.MovimientoFondosId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.MovimientoFondosId = objectBdo.MovimientoFondosId;
						objectInDb.NumeroDocumento = objectBdo.NumeroDocumento;
						objectInDb.CodDocumento = objectBdo.CodDocumento;
						objectInDb.Importe = objectBdo.Importe;
						objectInDb.OficinaIdProcedencia = objectBdo.OficinaIdProcedencia;
						objectInDb.OficinaIdDestino = objectBdo.OficinaIdDestino;
						objectInDb.CodigoPersona = objectBdo.CodigoPersona;
						objectInDb.BancoId = objectBdo.BancoId;
						objectInDb.NumeroCuentaBanco = objectBdo.NumeroCuentaBanco;
						objectInDb.CodigoVoucher = objectBdo.CodigoVoucher;
						objectInDb.NumeroOperacion = objectBdo.NumeroOperacion;
						objectInDb.CajaAperturaId = objectBdo.CajaAperturaId;
						objectInDb.FechaHoraAnulacion = objectBdo.FechaHoraAnulacion;
						objectInDb.Estado = objectBdo.Estado;
						objectInDb.UsuarioAnulacion = objectBdo.UsuarioAnulacion;
						objectInDb.ConceptoId = objectBdo.ConceptoId;
						objectInDb.MonedaId = objectBdo.MonedaId;
						objectInDb.TipoMovimiento = objectBdo.TipoMovimiento;
						objectInDb.FechaHoraTransaccion = objectBdo.FechaHoraTransaccion;
						objectInDb.CodDocumentoDescargo = objectBdo.CodDocumentoDescargo;
						objectInDb.NroDocumentoDescargo = objectBdo.NroDocumentoDescargo;
						objectInDb.FechaHoraDescargo = objectBdo.FechaHoraDescargo;
						objectInDb.FlagImpreso = objectBdo.FlagImpreso;
						objectInDb.Observacion = objectBdo.Observacion;

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
                throw new Exception("MovimientoFondos::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>MovimientoFondos business object</returns>
        public MovimientoFondosBdo GetById(int id)
        {
            try
            {
                MovimientoFondosBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    MovimientoFondos objectInDb = (from p in context.MovimientoFondos
                                       where p.MovimientoFondosId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new MovimientoFondosBdo()
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

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("MovimientoFondos::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of MovimientoFondos</returns>
        public List<MovimientoFondosBdo> GetAll()
        {            
            try
            {
                
                var MovimientoFondosBdos = new List<MovimientoFondosBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.MovimientoFondos.ToList();
                
                    MovimientoFondosBdos.AddRange(items.Select(item => new MovimientoFondosBdo()
                    {
						MovimientoFondosId = item.MovimientoFondosId,
						NumeroDocumento = item.NumeroDocumento,
						CodDocumento = item.CodDocumento,
						Importe = item.Importe,
						OficinaIdProcedencia = item.OficinaIdProcedencia,
						OficinaIdDestino = item.OficinaIdDestino,
						CodigoPersona = item.CodigoPersona,
						BancoId = item.BancoId,
						NumeroCuentaBanco = item.NumeroCuentaBanco,
						CodigoVoucher = item.CodigoVoucher,
						NumeroOperacion = item.NumeroOperacion,
						CajaAperturaId = item.CajaAperturaId,
						FechaHoraAnulacion = item.FechaHoraAnulacion,
						Estado = item.Estado,
						UsuarioAnulacion = item.UsuarioAnulacion,
						ConceptoId = item.ConceptoId,
						MonedaId = item.MonedaId,
						TipoMovimiento = item.TipoMovimiento,
						FechaHoraTransaccion = item.FechaHoraTransaccion,
						CodDocumentoDescargo = item.CodDocumentoDescargo,
						NroDocumentoDescargo = item.NroDocumentoDescargo,
						FechaHoraDescargo = item.FechaHoraDescargo,
						FlagImpreso = item.FlagImpreso,
						Observacion = item.Observacion

                    }));
                }
                return MovimientoFondosBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("MovimientoFondos::GetAll::Error occured.", ex);
            }            
        }

        public List<MovimientoFondosBdo> GetAllBy(string fieldName, object value)
        {
            var MovimientoFondosBdos = new List<MovimientoFondosBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM MovimientoFondos WHERE {0} = {1} ";

                    var items = context.MovimientoFondos.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    MovimientoFondosBdos.AddRange(items.Select(item => new MovimientoFondosBdo()
                    {
						MovimientoFondosId = item.MovimientoFondosId,
						NumeroDocumento = item.NumeroDocumento,
						CodDocumento = item.CodDocumento,
						Importe = item.Importe,
						OficinaIdProcedencia = item.OficinaIdProcedencia,
						OficinaIdDestino = item.OficinaIdDestino,
						CodigoPersona = item.CodigoPersona,
						BancoId = item.BancoId,
						NumeroCuentaBanco = item.NumeroCuentaBanco,
						CodigoVoucher = item.CodigoVoucher,
						NumeroOperacion = item.NumeroOperacion,
						CajaAperturaId = item.CajaAperturaId,
						FechaHoraAnulacion = item.FechaHoraAnulacion,
						Estado = item.Estado,
						UsuarioAnulacion = item.UsuarioAnulacion,
						ConceptoId = item.ConceptoId,
						MonedaId = item.MonedaId,
						TipoMovimiento = item.TipoMovimiento,
						FechaHoraTransaccion = item.FechaHoraTransaccion,
						CodDocumentoDescargo = item.CodDocumentoDescargo,
						NroDocumentoDescargo = item.NroDocumentoDescargo,
						FechaHoraDescargo = item.FechaHoraDescargo,
						FlagImpreso = item.FlagImpreso,
						Observacion = item.Observacion

                    }));
                }

                return MovimientoFondosBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("MovimientoFondos::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
