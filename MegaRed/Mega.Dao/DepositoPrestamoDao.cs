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
	/// Data access layer class for DepositoPrestamo
	/// </summary>
	public partial class DepositoPrestamoDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public DepositoPrestamoDao()
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
		public bool Insert(ref DepositoPrestamoBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.NumeroDocumento;
                    DepositoPrestamo objectInDb = (from p in context.DepositoPrestamo
                                           where p.NumeroDocumento == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.DepositoPrestamo.Add(new DepositoPrestamo()
                        {                        
							NumeroDocumento = objectBdo.NumeroDocumento,
							FechaHoraTransaccion = objectBdo.FechaHoraTransaccion,
							TipoOperacion = objectBdo.TipoOperacion,
							MonedaId = objectBdo.MonedaId,
							Importe = objectBdo.Importe,
							FechaHoraAnulacion = objectBdo.FechaHoraAnulacion,
							UsuarioAnulacion = objectBdo.UsuarioAnulacion,
							CodigoPersona = objectBdo.CodigoPersona,
							CajaAperturaId = objectBdo.CajaAperturaId,
							ConceptoId = objectBdo.ConceptoId,
							Fecha = objectBdo.Fecha,
							FlagImpreso = objectBdo.FlagImpreso,
							Interes = objectBdo.Interes

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
				throw new Exception("DepositoPrestamo::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref DepositoPrestamoBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.NumeroDocumento;
                    DepositoPrestamo objectInDb = (from p in context.DepositoPrestamo
                                           where p.NumeroDocumento == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.NumeroDocumento = objectBdo.NumeroDocumento;
						objectInDb.FechaHoraTransaccion = objectBdo.FechaHoraTransaccion;
						objectInDb.TipoOperacion = objectBdo.TipoOperacion;
						objectInDb.MonedaId = objectBdo.MonedaId;
						objectInDb.Importe = objectBdo.Importe;
						objectInDb.FechaHoraAnulacion = objectBdo.FechaHoraAnulacion;
						objectInDb.UsuarioAnulacion = objectBdo.UsuarioAnulacion;
						objectInDb.CodigoPersona = objectBdo.CodigoPersona;
						objectInDb.CajaAperturaId = objectBdo.CajaAperturaId;
						objectInDb.ConceptoId = objectBdo.ConceptoId;
						objectInDb.Fecha = objectBdo.Fecha;
						objectInDb.FlagImpreso = objectBdo.FlagImpreso;
						objectInDb.Interes = objectBdo.Interes;

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
                throw new Exception("DepositoPrestamo::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>DepositoPrestamo business object</returns>
        public DepositoPrestamoBdo GetById(int id)
        {
            try
            {
                DepositoPrestamoBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    DepositoPrestamo objectInDb = (from p in context.DepositoPrestamo
                                       where p.NumeroDocumento == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new DepositoPrestamoBdo()
                        {
							NumeroDocumento = objectInDb.NumeroDocumento,
							FechaHoraTransaccion = objectInDb.FechaHoraTransaccion,
							TipoOperacion = objectInDb.TipoOperacion,
							MonedaId = objectInDb.MonedaId,
							Importe = objectInDb.Importe,
							FechaHoraAnulacion = objectInDb.FechaHoraAnulacion,
							UsuarioAnulacion = objectInDb.UsuarioAnulacion,
							CodigoPersona = objectInDb.CodigoPersona,
							CajaAperturaId = objectInDb.CajaAperturaId,
							ConceptoId = objectInDb.ConceptoId,
							Fecha = objectInDb.Fecha,
							FlagImpreso = objectInDb.FlagImpreso,
							Interes = objectInDb.Interes

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("DepositoPrestamo::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of DepositoPrestamo</returns>
        public List<DepositoPrestamoBdo> GetAll()
        {            
            try
            {
                
                var DepositoPrestamoBdos = new List<DepositoPrestamoBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.DepositoPrestamo.ToList();
                
                    DepositoPrestamoBdos.AddRange(items.Select(item => new DepositoPrestamoBdo()
                    {
						NumeroDocumento = item.NumeroDocumento,
						FechaHoraTransaccion = item.FechaHoraTransaccion,
						TipoOperacion = item.TipoOperacion,
						MonedaId = item.MonedaId,
						Importe = item.Importe,
						FechaHoraAnulacion = item.FechaHoraAnulacion,
						UsuarioAnulacion = item.UsuarioAnulacion,
						CodigoPersona = item.CodigoPersona,
						CajaAperturaId = item.CajaAperturaId,
						ConceptoId = item.ConceptoId,
						Fecha = item.Fecha,
						FlagImpreso = item.FlagImpreso,
						Interes = item.Interes

                    }));
                }
                return DepositoPrestamoBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("DepositoPrestamo::GetAll::Error occured.", ex);
            }            
        }

        public List<DepositoPrestamoBdo> GetAllBy(string fieldName, object value)
        {
            var DepositoPrestamoBdos = new List<DepositoPrestamoBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM DepositoPrestamo WHERE {0} = {1} ";

                    var items = context.DepositoPrestamo.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    DepositoPrestamoBdos.AddRange(items.Select(item => new DepositoPrestamoBdo()
                    {
						NumeroDocumento = item.NumeroDocumento,
						FechaHoraTransaccion = item.FechaHoraTransaccion,
						TipoOperacion = item.TipoOperacion,
						MonedaId = item.MonedaId,
						Importe = item.Importe,
						FechaHoraAnulacion = item.FechaHoraAnulacion,
						UsuarioAnulacion = item.UsuarioAnulacion,
						CodigoPersona = item.CodigoPersona,
						CajaAperturaId = item.CajaAperturaId,
						ConceptoId = item.ConceptoId,
						Fecha = item.Fecha,
						FlagImpreso = item.FlagImpreso,
						Interes = item.Interes

                    }));
                }

                return DepositoPrestamoBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("DepositoPrestamo::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
