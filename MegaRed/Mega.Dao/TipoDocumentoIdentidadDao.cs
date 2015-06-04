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
	/// Data access layer class for TipoDocumentoIdentidad
	/// </summary>
	public partial class TipoDocumentoIdentidadDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public TipoDocumentoIdentidadDao()
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
		public bool Insert(ref TipoDocumentoIdentidadBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.TipoDocumentoId;
                    TipoDocumentoIdentidad objectInDb = (from p in context.TipoDocumentoIdentidad
                                           where p.TipoDocumentoId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.TipoDocumentoIdentidad.Add(new TipoDocumentoIdentidad()
                        {                        
							TipoDocumentoId = objectBdo.TipoDocumentoId,
							Abreviatura = objectBdo.Abreviatura,
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
				throw new Exception("TipoDocumentoIdentidad::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref TipoDocumentoIdentidadBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.TipoDocumentoId;
                    TipoDocumentoIdentidad objectInDb = (from p in context.TipoDocumentoIdentidad
                                           where p.TipoDocumentoId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.TipoDocumentoId = objectBdo.TipoDocumentoId;
						objectInDb.Abreviatura = objectBdo.Abreviatura;
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
                throw new Exception("TipoDocumentoIdentidad::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>TipoDocumentoIdentidad business object</returns>
        public TipoDocumentoIdentidadBdo GetById(int id)
        {
            try
            {
                TipoDocumentoIdentidadBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    TipoDocumentoIdentidad objectInDb = (from p in context.TipoDocumentoIdentidad
                                       where p.TipoDocumentoId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new TipoDocumentoIdentidadBdo()
                        {
							TipoDocumentoId = objectInDb.TipoDocumentoId,
							Abreviatura = objectInDb.Abreviatura,
							Denominacion = objectInDb.Denominacion

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("TipoDocumentoIdentidad::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of TipoDocumentoIdentidad</returns>
        public List<TipoDocumentoIdentidadBdo> GetAll()
        {            
            try
            {
                
                var TipoDocumentoIdentidadBdos = new List<TipoDocumentoIdentidadBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.TipoDocumentoIdentidad.ToList();
                
                    TipoDocumentoIdentidadBdos.AddRange(items.Select(item => new TipoDocumentoIdentidadBdo()
                    {
						TipoDocumentoId = item.TipoDocumentoId,
						Abreviatura = item.Abreviatura,
						Denominacion = item.Denominacion

                    }));
                }
                return TipoDocumentoIdentidadBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("TipoDocumentoIdentidad::GetAll::Error occured.", ex);
            }            
        }

        public List<TipoDocumentoIdentidadBdo> GetAllBy(string fieldName, object value)
        {
            var TipoDocumentoIdentidadBdos = new List<TipoDocumentoIdentidadBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM TipoDocumentoIdentidad WHERE {0} = {1} ";

                    var items = context.TipoDocumentoIdentidad.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    TipoDocumentoIdentidadBdos.AddRange(items.Select(item => new TipoDocumentoIdentidadBdo()
                    {
						TipoDocumentoId = item.TipoDocumentoId,
						Abreviatura = item.Abreviatura,
						Denominacion = item.Denominacion

                    }));
                }

                return TipoDocumentoIdentidadBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("TipoDocumentoIdentidad::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
