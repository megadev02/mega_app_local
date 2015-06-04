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
	/// Data access layer class for TipoCambio
	/// </summary>
	public partial class TipoCambioDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public TipoCambioDao()
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
		public bool Insert(ref TipoCambioBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.Fecha;
                    TipoCambio objectInDb = (from p in context.TipoCambio
                                           where p.Fecha == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.TipoCambio.Add(new TipoCambio()
                        {                        
							Fecha = objectBdo.Fecha,
							ValorCambioCompra = objectBdo.ValorCambioCompra,
							ValorCambioVenta = objectBdo.ValorCambioVenta

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
				throw new Exception("TipoCambio::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref TipoCambioBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.Fecha;
                    TipoCambio objectInDb = (from p in context.TipoCambio
                                           where p.Fecha == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.Fecha = objectBdo.Fecha;
						objectInDb.ValorCambioCompra = objectBdo.ValorCambioCompra;
						objectInDb.ValorCambioVenta = objectBdo.ValorCambioVenta;

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
                throw new Exception("TipoCambio::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>TipoCambio business object</returns>
        public TipoCambioBdo GetById(DateTime id)
        {
            try
            {
                TipoCambioBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    TipoCambio objectInDb = (from p in context.TipoCambio
                                       where p.Fecha == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new TipoCambioBdo()
                        {
							Fecha = objectInDb.Fecha,
							ValorCambioCompra = objectInDb.ValorCambioCompra,
							ValorCambioVenta = objectInDb.ValorCambioVenta

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("TipoCambio::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of TipoCambio</returns>
        public List<TipoCambioBdo> GetAll()
        {            
            try
            {
                
                var TipoCambioBdos = new List<TipoCambioBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.TipoCambio.ToList();
                
                    TipoCambioBdos.AddRange(items.Select(item => new TipoCambioBdo()
                    {
						Fecha = item.Fecha,
						ValorCambioCompra = item.ValorCambioCompra,
						ValorCambioVenta = item.ValorCambioVenta

                    }));
                }
                return TipoCambioBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("TipoCambio::GetAll::Error occured.", ex);
            }            
        }

        public List<TipoCambioBdo> GetAllBy(string fieldName, object value)
        {
            var TipoCambioBdos = new List<TipoCambioBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM TipoCambio WHERE {0} = {1} ";

                    var items = context.TipoCambio.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    TipoCambioBdos.AddRange(items.Select(item => new TipoCambioBdo()
                    {
						Fecha = item.Fecha,
						ValorCambioCompra = item.ValorCambioCompra,
						ValorCambioVenta = item.ValorCambioVenta

                    }));
                }

                return TipoCambioBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("TipoCambio::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
