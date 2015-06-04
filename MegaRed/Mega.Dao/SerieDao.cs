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
	/// Data access layer class for Serie
	/// </summary>
	public partial class SerieDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public SerieDao()
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
		public bool Insert(ref SerieBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.SerieId;
                    Serie objectInDb = (from p in context.Serie
                                           where p.SerieId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.Serie.Add(new Serie()
                        {                        
							SerieId = objectBdo.SerieId,
							CodComprobante = objectBdo.CodComprobante,
							NumeroSerie = objectBdo.NumeroSerie,
							NumeroDigitos = objectBdo.NumeroDigitos,
							CierreSerie = objectBdo.CierreSerie,
							CodigoOficina = objectBdo.CodigoOficina

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
				throw new Exception("Serie::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref SerieBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.SerieId;
                    Serie objectInDb = (from p in context.Serie
                                           where p.SerieId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.SerieId = objectBdo.SerieId;
						objectInDb.CodComprobante = objectBdo.CodComprobante;
						objectInDb.NumeroSerie = objectBdo.NumeroSerie;
						objectInDb.NumeroDigitos = objectBdo.NumeroDigitos;
						objectInDb.CierreSerie = objectBdo.CierreSerie;
						objectInDb.CodigoOficina = objectBdo.CodigoOficina;

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
                throw new Exception("Serie::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>Serie business object</returns>
        public SerieBdo GetById(int id)
        {
            try
            {
                SerieBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    Serie objectInDb = (from p in context.Serie
                                       where p.SerieId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new SerieBdo()
                        {
							SerieId = objectInDb.SerieId,
							CodComprobante = objectInDb.CodComprobante,
							NumeroSerie = objectInDb.NumeroSerie,
							NumeroDigitos = objectInDb.NumeroDigitos,
							CierreSerie = objectInDb.CierreSerie,
							CodigoOficina = objectInDb.CodigoOficina

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Serie::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of Serie</returns>
        public List<SerieBdo> GetAll()
        {            
            try
            {
                
                var SerieBdos = new List<SerieBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.Serie.ToList();
                
                    SerieBdos.AddRange(items.Select(item => new SerieBdo()
                    {
						SerieId = item.SerieId,
						CodComprobante = item.CodComprobante,
						NumeroSerie = item.NumeroSerie,
						NumeroDigitos = item.NumeroDigitos,
						CierreSerie = item.CierreSerie,
						CodigoOficina = item.CodigoOficina

                    }));
                }
                return SerieBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("Serie::GetAll::Error occured.", ex);
            }            
        }

        public List<SerieBdo> GetAllBy(string fieldName, object value)
        {
            var SerieBdos = new List<SerieBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM Serie WHERE {0} = {1} ";

                    var items = context.Serie.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    SerieBdos.AddRange(items.Select(item => new SerieBdo()
                    {
						SerieId = item.SerieId,
						CodComprobante = item.CodComprobante,
						NumeroSerie = item.NumeroSerie,
						NumeroDigitos = item.NumeroDigitos,
						CierreSerie = item.CierreSerie,
						CodigoOficina = item.CodigoOficina

                    }));
                }

                return SerieBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("Serie::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
