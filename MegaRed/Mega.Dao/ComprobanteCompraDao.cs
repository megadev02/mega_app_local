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
	/// Data access layer class for ComprobanteCompra
	/// </summary>
	public partial class ComprobanteCompraDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public ComprobanteCompraDao()
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
		public bool Insert(ref ComprobanteCompraBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.ComprobanteCompraId;
                    ComprobanteCompra objectInDb = (from p in context.ComprobanteCompra
                                           where p.ComprobanteCompraId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.ComprobanteCompra.Add(new ComprobanteCompra()
                        {                        
							ComprobanteCompraId = objectBdo.ComprobanteCompraId,
							RUC = objectBdo.RUC,
							RazonSocial = objectBdo.RazonSocial,
							NumeroDocumento = objectBdo.NumeroDocumento,
							NumeroSerie = objectBdo.NumeroSerie

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
				throw new Exception("ComprobanteCompra::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref ComprobanteCompraBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.ComprobanteCompraId;
                    ComprobanteCompra objectInDb = (from p in context.ComprobanteCompra
                                           where p.ComprobanteCompraId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.ComprobanteCompraId = objectBdo.ComprobanteCompraId;
						objectInDb.RUC = objectBdo.RUC;
						objectInDb.RazonSocial = objectBdo.RazonSocial;
						objectInDb.NumeroDocumento = objectBdo.NumeroDocumento;
						objectInDb.NumeroSerie = objectBdo.NumeroSerie;

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
                throw new Exception("ComprobanteCompra::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>ComprobanteCompra business object</returns>
        public ComprobanteCompraBdo GetById(int id)
        {
            try
            {
                ComprobanteCompraBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    ComprobanteCompra objectInDb = (from p in context.ComprobanteCompra
                                       where p.ComprobanteCompraId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new ComprobanteCompraBdo()
                        {
							ComprobanteCompraId = objectInDb.ComprobanteCompraId,
							RUC = objectInDb.RUC,
							RazonSocial = objectInDb.RazonSocial,
							NumeroDocumento = objectInDb.NumeroDocumento,
							NumeroSerie = objectInDb.NumeroSerie

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("ComprobanteCompra::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of ComprobanteCompra</returns>
        public List<ComprobanteCompraBdo> GetAll()
        {            
            try
            {
                
                var ComprobanteCompraBdos = new List<ComprobanteCompraBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.ComprobanteCompra.ToList();
                
                    ComprobanteCompraBdos.AddRange(items.Select(item => new ComprobanteCompraBdo()
                    {
						ComprobanteCompraId = item.ComprobanteCompraId,
						RUC = item.RUC,
						RazonSocial = item.RazonSocial,
						NumeroDocumento = item.NumeroDocumento,
						NumeroSerie = item.NumeroSerie

                    }));
                }
                return ComprobanteCompraBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("ComprobanteCompra::GetAll::Error occured.", ex);
            }            
        }

        public List<ComprobanteCompraBdo> GetAllBy(string fieldName, object value)
        {
            var ComprobanteCompraBdos = new List<ComprobanteCompraBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM ComprobanteCompra WHERE {0} = {1} ";

                    var items = context.ComprobanteCompra.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    ComprobanteCompraBdos.AddRange(items.Select(item => new ComprobanteCompraBdo()
                    {
						ComprobanteCompraId = item.ComprobanteCompraId,
						RUC = item.RUC,
						RazonSocial = item.RazonSocial,
						NumeroDocumento = item.NumeroDocumento,
						NumeroSerie = item.NumeroSerie

                    }));
                }

                return ComprobanteCompraBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("ComprobanteCompra::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
