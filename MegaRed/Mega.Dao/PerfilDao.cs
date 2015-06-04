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
	/// Data access layer class for Perfil
	/// </summary>
	public partial class PerfilDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public PerfilDao()
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
		public bool Insert(ref PerfilBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.PerfilId;
                    Perfil objectInDb = (from p in context.Perfil
                                           where p.PerfilId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.Perfil.Add(new Perfil()
                        {                        
							PerfilId = objectBdo.PerfilId,
							NombrePerfil = objectBdo.NombrePerfil,
							Estado = objectBdo.Estado

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
				throw new Exception("Perfil::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref PerfilBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.PerfilId;
                    Perfil objectInDb = (from p in context.Perfil
                                           where p.PerfilId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.PerfilId = objectBdo.PerfilId;
						objectInDb.NombrePerfil = objectBdo.NombrePerfil;
						objectInDb.Estado = objectBdo.Estado;

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
                throw new Exception("Perfil::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>Perfil business object</returns>
        public PerfilBdo GetById(int id)
        {
            try
            {
                PerfilBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    Perfil objectInDb = (from p in context.Perfil
                                       where p.PerfilId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new PerfilBdo()
                        {
							PerfilId = objectInDb.PerfilId,
							NombrePerfil = objectInDb.NombrePerfil,
							Estado = objectInDb.Estado

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Perfil::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of Perfil</returns>
        public List<PerfilBdo> GetAll()
        {            
            try
            {
                
                var PerfilBdos = new List<PerfilBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.Perfil.ToList();
                
                    PerfilBdos.AddRange(items.Select(item => new PerfilBdo()
                    {
						PerfilId = item.PerfilId,
						NombrePerfil = item.NombrePerfil,
						Estado = item.Estado

                    }));
                }
                return PerfilBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("Perfil::GetAll::Error occured.", ex);
            }            
        }

        public List<PerfilBdo> GetAllBy(string fieldName, object value)
        {
            var PerfilBdos = new List<PerfilBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM Perfil WHERE {0} = {1} ";

                    var items = context.Perfil.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    PerfilBdos.AddRange(items.Select(item => new PerfilBdo()
                    {
						PerfilId = item.PerfilId,
						NombrePerfil = item.NombrePerfil,
						Estado = item.Estado

                    }));
                }

                return PerfilBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("Perfil::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
