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
	/// Data access layer class for Caja
	/// </summary>
	public partial class CajaDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CajaDao()
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
		public bool Insert(ref CajaBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.CajaId;
                    Caja objectInDb = (from p in context.Caja
                                           where p.CajaId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.Caja.Add(new Caja()
                        {                        
							CajaId = objectBdo.CajaId,
							Nombre = objectBdo.Nombre,
							Contrasenia = objectBdo.Contrasenia,
							Estado = objectBdo.Estado,
							CodigoCuenta = objectBdo.CodigoCuenta

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
				throw new Exception("Caja::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref CajaBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.CajaId;
                    Caja objectInDb = (from p in context.Caja
                                           where p.CajaId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.CajaId = objectBdo.CajaId;
						objectInDb.Nombre = objectBdo.Nombre;
						objectInDb.Contrasenia = objectBdo.Contrasenia;
						objectInDb.Estado = objectBdo.Estado;
						objectInDb.CodigoCuenta = objectBdo.CodigoCuenta;

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
                throw new Exception("Caja::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>Caja business object</returns>
        public CajaBdo GetById(int id)
        {
            try
            {
                CajaBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    Caja objectInDb = (from p in context.Caja
                                       where p.CajaId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new CajaBdo()
                        {
							CajaId = objectInDb.CajaId,
							Nombre = objectInDb.Nombre,
							Contrasenia = objectInDb.Contrasenia,
							Estado = objectInDb.Estado,
							CodigoCuenta = objectInDb.CodigoCuenta

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Caja::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of Caja</returns>
        public List<CajaBdo> GetAll()
        {            
            try
            {
                
                var CajaBdos = new List<CajaBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.Caja.ToList();
                
                    CajaBdos.AddRange(items.Select(item => new CajaBdo()
                    {
						CajaId = item.CajaId,
						Nombre = item.Nombre,
						Contrasenia = item.Contrasenia,
						Estado = item.Estado,
						CodigoCuenta = item.CodigoCuenta

                    }));
                }
                return CajaBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("Caja::GetAll::Error occured.", ex);
            }            
        }

        public List<CajaBdo> GetAllBy(string fieldName, object value)
        {
            var CajaBdos = new List<CajaBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM Caja WHERE {0} = {1} ";

                    var items = context.Caja.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    CajaBdos.AddRange(items.Select(item => new CajaBdo()
                    {
						CajaId = item.CajaId,
						Nombre = item.Nombre,
						Contrasenia = item.Contrasenia,
						Estado = item.Estado,
						CodigoCuenta = item.CodigoCuenta

                    }));
                }

                return CajaBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("Caja::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
