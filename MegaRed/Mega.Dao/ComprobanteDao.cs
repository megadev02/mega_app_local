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
	/// Data access layer class for Comprobante
	/// </summary>
	public partial class ComprobanteDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public ComprobanteDao()
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
		public bool Insert(ref ComprobanteBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.CodComprobante;
                    Comprobante objectInDb = (from p in context.Comprobante
                                           where p.CodComprobante == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.Comprobante.Add(new Comprobante()
                        {                        
							CodComprobante = objectBdo.CodComprobante,
							NombreComprobante = objectBdo.NombreComprobante,
							CreditoFiscal = objectBdo.CreditoFiscal

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
				throw new Exception("Comprobante::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref ComprobanteBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.CodComprobante;
                    Comprobante objectInDb = (from p in context.Comprobante
                                           where p.CodComprobante == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.CodComprobante = objectBdo.CodComprobante;
						objectInDb.NombreComprobante = objectBdo.NombreComprobante;
						objectInDb.CreditoFiscal = objectBdo.CreditoFiscal;

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
                throw new Exception("Comprobante::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>Comprobante business object</returns>
        public ComprobanteBdo GetById(string id)
        {
            try
            {
                ComprobanteBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    Comprobante objectInDb = (from p in context.Comprobante
                                       where p.CodComprobante == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new ComprobanteBdo()
                        {
							CodComprobante = objectInDb.CodComprobante,
							NombreComprobante = objectInDb.NombreComprobante,
							CreditoFiscal = objectInDb.CreditoFiscal

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Comprobante::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of Comprobante</returns>
        public List<ComprobanteBdo> GetAll()
        {            
            try
            {
                
                var ComprobanteBdos = new List<ComprobanteBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.Comprobante.ToList();
                
                    ComprobanteBdos.AddRange(items.Select(item => new ComprobanteBdo()
                    {
						CodComprobante = item.CodComprobante,
						NombreComprobante = item.NombreComprobante,
						CreditoFiscal = item.CreditoFiscal

                    }));
                }
                return ComprobanteBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("Comprobante::GetAll::Error occured.", ex);
            }            
        }

        public List<ComprobanteBdo> GetAllBy(string fieldName, object value)
        {
            var ComprobanteBdos = new List<ComprobanteBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM Comprobante WHERE {0} = {1} ";

                    var items = context.Comprobante.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    ComprobanteBdos.AddRange(items.Select(item => new ComprobanteBdo()
                    {
						CodComprobante = item.CodComprobante,
						NombreComprobante = item.NombreComprobante,
						CreditoFiscal = item.CreditoFiscal

                    }));
                }

                return ComprobanteBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("Comprobante::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
