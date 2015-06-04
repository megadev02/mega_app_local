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
	/// Data access layer class for EntidadFinanciera
	/// </summary>
	public partial class EntidadFinancieraDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public EntidadFinancieraDao()
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
		public bool Insert(ref EntidadFinancieraBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.EntidadId;
                    EntidadFinanciera objectInDb = (from p in context.EntidadFinanciera
                                           where p.EntidadId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.EntidadFinanciera.Add(new EntidadFinanciera()
                        {                        
							EntidadId = objectBdo.EntidadId,
							CodEntidad = objectBdo.CodEntidad,
							Nombre = objectBdo.Nombre

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
				throw new Exception("EntidadFinanciera::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref EntidadFinancieraBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.EntidadId;
                    EntidadFinanciera objectInDb = (from p in context.EntidadFinanciera
                                           where p.EntidadId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.EntidadId = objectBdo.EntidadId;
						objectInDb.CodEntidad = objectBdo.CodEntidad;
						objectInDb.Nombre = objectBdo.Nombre;

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
                throw new Exception("EntidadFinanciera::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>EntidadFinanciera business object</returns>
        public EntidadFinancieraBdo GetById(int id)
        {
            try
            {
                EntidadFinancieraBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    EntidadFinanciera objectInDb = (from p in context.EntidadFinanciera
                                       where p.EntidadId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new EntidadFinancieraBdo()
                        {
							EntidadId = objectInDb.EntidadId,
							CodEntidad = objectInDb.CodEntidad,
							Nombre = objectInDb.Nombre

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("EntidadFinanciera::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of EntidadFinanciera</returns>
        public List<EntidadFinancieraBdo> GetAll()
        {            
            try
            {
                
                var EntidadFinancieraBdos = new List<EntidadFinancieraBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.EntidadFinanciera.ToList();
                
                    EntidadFinancieraBdos.AddRange(items.Select(item => new EntidadFinancieraBdo()
                    {
						EntidadId = item.EntidadId,
						CodEntidad = item.CodEntidad,
						Nombre = item.Nombre

                    }));
                }
                return EntidadFinancieraBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("EntidadFinanciera::GetAll::Error occured.", ex);
            }            
        }

        public List<EntidadFinancieraBdo> GetAllBy(string fieldName, object value)
        {
            var EntidadFinancieraBdos = new List<EntidadFinancieraBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM EntidadFinanciera WHERE {0} = {1} ";

                    var items = context.EntidadFinanciera.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    EntidadFinancieraBdos.AddRange(items.Select(item => new EntidadFinancieraBdo()
                    {
						EntidadId = item.EntidadId,
						CodEntidad = item.CodEntidad,
						Nombre = item.Nombre

                    }));
                }

                return EntidadFinancieraBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("EntidadFinanciera::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
