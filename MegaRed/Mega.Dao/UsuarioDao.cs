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
	/// Data access layer class for Usuario
	/// </summary>
	public partial class UsuarioDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public UsuarioDao()
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
		public bool Insert(ref UsuarioBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.UsuarioId;
                    Usuario objectInDb = (from p in context.Usuario
                                           where p.UsuarioId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.Usuario.Add(new Usuario()
                        {                        
							UsuarioId = objectBdo.UsuarioId,
							Contrasenia = objectBdo.Contrasenia,
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
				throw new Exception("Usuario::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref UsuarioBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.UsuarioId;
                    Usuario objectInDb = (from p in context.Usuario
                                           where p.UsuarioId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.UsuarioId = objectBdo.UsuarioId;
						objectInDb.Contrasenia = objectBdo.Contrasenia;
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
                throw new Exception("Usuario::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>Usuario business object</returns>
        public UsuarioBdo GetById(string id)
        {
            try
            {
                UsuarioBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    Usuario objectInDb = (from p in context.Usuario
                                       where p.UsuarioId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new UsuarioBdo()
                        {
							UsuarioId = objectInDb.UsuarioId,
							Contrasenia = objectInDb.Contrasenia,
							Estado = objectInDb.Estado

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Usuario::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of Usuario</returns>
        public List<UsuarioBdo> GetAll()
        {            
            try
            {
                
                var UsuarioBdos = new List<UsuarioBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.Usuario.ToList();
                
                    UsuarioBdos.AddRange(items.Select(item => new UsuarioBdo()
                    {
						UsuarioId = item.UsuarioId,
						Contrasenia = item.Contrasenia,
						Estado = item.Estado

                    }));
                }
                return UsuarioBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("Usuario::GetAll::Error occured.", ex);
            }            
        }

        public List<UsuarioBdo> GetAllBy(string fieldName, object value)
        {
            var UsuarioBdos = new List<UsuarioBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM Usuario WHERE {0} = {1} ";

                    var items = context.Usuario.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    UsuarioBdos.AddRange(items.Select(item => new UsuarioBdo()
                    {
						UsuarioId = item.UsuarioId,
						Contrasenia = item.Contrasenia,
						Estado = item.Estado

                    }));
                }

                return UsuarioBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("Usuario::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
