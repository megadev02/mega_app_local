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
	/// Data access layer class for ReciboCaja
	/// </summary>
	public partial class ReciboCajaDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public ReciboCajaDao()
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
		public bool Insert(ref ReciboCajaBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.NumeroDocumento;
                    ReciboCaja objectInDb = (from p in context.ReciboCaja
                                           where p.NumeroDocumento == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.ReciboCaja.Add(new ReciboCaja()
                        {                        
							NumeroDocumento = objectBdo.NumeroDocumento,
							CajaAperturaId = objectBdo.CajaAperturaId,
							CodDocumento = objectBdo.CodDocumento,
							TipoRecibo = objectBdo.TipoRecibo,
							MonedaId = objectBdo.MonedaId,
							Importe = objectBdo.Importe,
							FechaHoraTransaccion = objectBdo.FechaHoraTransaccion,
							CodigoPersona = objectBdo.CodigoPersona,
							Concepto = objectBdo.Concepto,
							FlagImpreso = objectBdo.FlagImpreso,
							ObsRecibo = objectBdo.ObsRecibo,
							FechaHoraAnulacion = objectBdo.FechaHoraAnulacion,
							UsuarioAnulacion = objectBdo.UsuarioAnulacion,
							ComprobanteCompraId = objectBdo.ComprobanteCompraId,
							Estado = objectBdo.Estado,
							ConceptoId = objectBdo.ConceptoId

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
				throw new Exception("ReciboCaja::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref ReciboCajaBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.NumeroDocumento;
                    ReciboCaja objectInDb = (from p in context.ReciboCaja
                                           where p.NumeroDocumento == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.NumeroDocumento = objectBdo.NumeroDocumento;
						objectInDb.CajaAperturaId = objectBdo.CajaAperturaId;
						objectInDb.CodDocumento = objectBdo.CodDocumento;
						objectInDb.TipoRecibo = objectBdo.TipoRecibo;
						objectInDb.MonedaId = objectBdo.MonedaId;
						objectInDb.Importe = objectBdo.Importe;
						objectInDb.FechaHoraTransaccion = objectBdo.FechaHoraTransaccion;
						objectInDb.CodigoPersona = objectBdo.CodigoPersona;
						objectInDb.Concepto = objectBdo.Concepto;
						objectInDb.FlagImpreso = objectBdo.FlagImpreso;
						objectInDb.ObsRecibo = objectBdo.ObsRecibo;
						objectInDb.FechaHoraAnulacion = objectBdo.FechaHoraAnulacion;
						objectInDb.UsuarioAnulacion = objectBdo.UsuarioAnulacion;
						objectInDb.ComprobanteCompraId = objectBdo.ComprobanteCompraId;
						objectInDb.Estado = objectBdo.Estado;
						objectInDb.ConceptoId = objectBdo.ConceptoId;

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
                throw new Exception("ReciboCaja::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>ReciboCaja business object</returns>
        public ReciboCajaBdo GetById(int id)
        {
            try
            {
                ReciboCajaBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    ReciboCaja objectInDb = (from p in context.ReciboCaja
                                       where p.NumeroDocumento == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new ReciboCajaBdo()
                        {
							NumeroDocumento = objectInDb.NumeroDocumento,
							CajaAperturaId = objectInDb.CajaAperturaId,
							CodDocumento = objectInDb.CodDocumento,
							TipoRecibo = objectInDb.TipoRecibo,
							MonedaId = objectInDb.MonedaId,
							Importe = objectInDb.Importe,
							FechaHoraTransaccion = objectInDb.FechaHoraTransaccion,
							CodigoPersona = objectInDb.CodigoPersona,
							Concepto = objectInDb.Concepto,
							FlagImpreso = objectInDb.FlagImpreso,
							ObsRecibo = objectInDb.ObsRecibo,
							FechaHoraAnulacion = objectInDb.FechaHoraAnulacion,
							UsuarioAnulacion = objectInDb.UsuarioAnulacion,
							ComprobanteCompraId = objectInDb.ComprobanteCompraId,
							Estado = objectInDb.Estado,
							ConceptoId = objectInDb.ConceptoId

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("ReciboCaja::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of ReciboCaja</returns>
        public List<ReciboCajaBdo> GetAll()
        {            
            try
            {
                
                var ReciboCajaBdos = new List<ReciboCajaBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.ReciboCaja.ToList();
                
                    ReciboCajaBdos.AddRange(items.Select(item => new ReciboCajaBdo()
                    {
						NumeroDocumento = item.NumeroDocumento,
						CajaAperturaId = item.CajaAperturaId,
						CodDocumento = item.CodDocumento,
						TipoRecibo = item.TipoRecibo,
						MonedaId = item.MonedaId,
						Importe = item.Importe,
						FechaHoraTransaccion = item.FechaHoraTransaccion,
						CodigoPersona = item.CodigoPersona,
						Concepto = item.Concepto,
						FlagImpreso = item.FlagImpreso,
						ObsRecibo = item.ObsRecibo,
						FechaHoraAnulacion = item.FechaHoraAnulacion,
						UsuarioAnulacion = item.UsuarioAnulacion,
						ComprobanteCompraId = item.ComprobanteCompraId,
						Estado = item.Estado,
						ConceptoId = item.ConceptoId

                    }));
                }
                return ReciboCajaBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("ReciboCaja::GetAll::Error occured.", ex);
            }            
        }

        public List<ReciboCajaBdo> GetAllBy(string fieldName, object value)
        {
            var ReciboCajaBdos = new List<ReciboCajaBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM ReciboCaja WHERE {0} = {1} ";

                    var items = context.ReciboCaja.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    ReciboCajaBdos.AddRange(items.Select(item => new ReciboCajaBdo()
                    {
						NumeroDocumento = item.NumeroDocumento,
						CajaAperturaId = item.CajaAperturaId,
						CodDocumento = item.CodDocumento,
						TipoRecibo = item.TipoRecibo,
						MonedaId = item.MonedaId,
						Importe = item.Importe,
						FechaHoraTransaccion = item.FechaHoraTransaccion,
						CodigoPersona = item.CodigoPersona,
						Concepto = item.Concepto,
						FlagImpreso = item.FlagImpreso,
						ObsRecibo = item.ObsRecibo,
						FechaHoraAnulacion = item.FechaHoraAnulacion,
						UsuarioAnulacion = item.UsuarioAnulacion,
						ComprobanteCompraId = item.ComprobanteCompraId,
						Estado = item.Estado,
						ConceptoId = item.ConceptoId

                    }));
                }

                return ReciboCajaBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("ReciboCaja::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
