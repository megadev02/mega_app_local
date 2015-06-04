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
	/// Data access layer class for TipoComunero
	/// </summary>
	public partial class TipoComuneroDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public TipoComuneroDao()
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
		public bool Insert(ref TipoComuneroBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.TipoComuneroId;
                    TipoComunero objectInDb = (from p in context.TipoComunero
                                           where p.TipoComuneroId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.TipoComunero.Add(new TipoComunero()
                        {                        
							TipoComuneroId = objectBdo.TipoComuneroId,
							Denominacion = objectBdo.Denominacion

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
				throw new Exception("TipoComunero::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref TipoComuneroBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.TipoComuneroId;
                    TipoComunero objectInDb = (from p in context.TipoComunero
                                           where p.TipoComuneroId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.TipoComuneroId = objectBdo.TipoComuneroId;
						objectInDb.Denominacion = objectBdo.Denominacion;

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
                throw new Exception("TipoComunero::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>TipoComunero business object</returns>
        public TipoComuneroBdo GetById(int id)
        {
            try
            {
                TipoComuneroBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    TipoComunero objectInDb = (from p in context.TipoComunero
                                       where p.TipoComuneroId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new TipoComuneroBdo()
                        {
							TipoComuneroId = objectInDb.TipoComuneroId,
							Denominacion = objectInDb.Denominacion

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("TipoComunero::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of TipoComunero</returns>
        public List<TipoComuneroBdo> GetAll()
        {            
            try
            {
                
                var TipoComuneroBdos = new List<TipoComuneroBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.TipoComunero.ToList();
                
                    TipoComuneroBdos.AddRange(items.Select(item => new TipoComuneroBdo()
                    {
						TipoComuneroId = item.TipoComuneroId,
						Denominacion = item.Denominacion

                    }));
                }
                return TipoComuneroBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("TipoComunero::GetAll::Error occured.", ex);
            }            
        }

        public List<TipoComuneroBdo> GetAllBy(string fieldName, object value)
        {
            var TipoComuneroBdos = new List<TipoComuneroBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM TipoComunero WHERE {0} = {1} ";

                    var items = context.TipoComunero.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    TipoComuneroBdos.AddRange(items.Select(item => new TipoComuneroBdo()
                    {
						TipoComuneroId = item.TipoComuneroId,
						Denominacion = item.Denominacion

                    }));
                }

                return TipoComuneroBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("TipoComunero::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
