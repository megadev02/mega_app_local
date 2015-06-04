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
	/// Data access layer class for Accesos
	/// </summary>
	public partial class AccesosDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public AccesosDao()
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
		public bool Insert(ref AccesosBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.AccesoId;
                    Accesos objectInDb = (from p in context.Accesos
                                           where p.AccesoId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.Accesos.Add(new Accesos()
                        {                        
							AccesoId = objectBdo.AccesoId,
							Id = objectBdo.Id,
							UsuarioId = objectBdo.UsuarioId

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
				throw new Exception("Accesos::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref AccesosBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.AccesoId;
                    Accesos objectInDb = (from p in context.Accesos
                                           where p.AccesoId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.AccesoId = objectBdo.AccesoId;
						objectInDb.Id = objectBdo.Id;
						objectInDb.UsuarioId = objectBdo.UsuarioId;

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
                throw new Exception("Accesos::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>Accesos business object</returns>
        public AccesosBdo GetById(int id)
        {
            try
            {
                AccesosBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    Accesos objectInDb = (from p in context.Accesos
                                       where p.AccesoId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new AccesosBdo()
                        {
							AccesoId = objectInDb.AccesoId,
							Id = objectInDb.Id,
							UsuarioId = objectInDb.UsuarioId

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Accesos::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of Accesos</returns>
        public List<AccesosBdo> GetAll()
        {            
            try
            {
                
                var AccesosBdos = new List<AccesosBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.Accesos.ToList();
                
                    AccesosBdos.AddRange(items.Select(item => new AccesosBdo()
                    {
						AccesoId = item.AccesoId,
						Id = item.Id,
						UsuarioId = item.UsuarioId

                    }));
                }
                return AccesosBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("Accesos::GetAll::Error occured.", ex);
            }            
        }

        public List<AccesosBdo> GetAllBy(string fieldName, object value)
        {
            var AccesosBdos = new List<AccesosBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM Accesos WHERE {0} = {1} ";

                    var items = context.Accesos.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    AccesosBdos.AddRange(items.Select(item => new AccesosBdo()
                    {
						AccesoId = item.AccesoId,
						Id = item.Id,
						UsuarioId = item.UsuarioId

                    }));
                }

                return AccesosBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("Accesos::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
