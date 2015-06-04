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
	/// Data access layer class for Oficina
	/// </summary>
	public partial class OficinaDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public OficinaDao()
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
		public bool Insert(ref OficinaBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.CodigoOficina;
                    Oficina objectInDb = (from p in context.Oficina
                                           where p.CodigoOficina == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.Oficina.Add(new Oficina()
                        {                        
							CodigoOficina = objectBdo.CodigoOficina,
							NombreOficina = objectBdo.NombreOficina,
							CodigoUbigeo = objectBdo.CodigoUbigeo,
							TipoOficina = objectBdo.TipoOficina,
							Direccion = objectBdo.Direccion,
							Telefono = objectBdo.Telefono,
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
				throw new Exception("Oficina::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref OficinaBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.CodigoOficina;
                    Oficina objectInDb = (from p in context.Oficina
                                           where p.CodigoOficina == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.CodigoOficina = objectBdo.CodigoOficina;
						objectInDb.NombreOficina = objectBdo.NombreOficina;
						objectInDb.CodigoUbigeo = objectBdo.CodigoUbigeo;
						objectInDb.TipoOficina = objectBdo.TipoOficina;
						objectInDb.Direccion = objectBdo.Direccion;
						objectInDb.Telefono = objectBdo.Telefono;
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
                throw new Exception("Oficina::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>Oficina business object</returns>
        public OficinaBdo GetById(string id)
        {
            try
            {
                OficinaBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    Oficina objectInDb = (from p in context.Oficina
                                       where p.CodigoOficina == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new OficinaBdo()
                        {
							CodigoOficina = objectInDb.CodigoOficina,
							NombreOficina = objectInDb.NombreOficina,
							CodigoUbigeo = objectInDb.CodigoUbigeo,
							TipoOficina = objectInDb.TipoOficina,
							Direccion = objectInDb.Direccion,
							Telefono = objectInDb.Telefono,
							Estado = objectInDb.Estado

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Oficina::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of Oficina</returns>
        public List<OficinaBdo> GetAll()
        {            
            try
            {
                
                var OficinaBdos = new List<OficinaBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.Oficina.ToList();
                
                    OficinaBdos.AddRange(items.Select(item => new OficinaBdo()
                    {
						CodigoOficina = item.CodigoOficina,
						NombreOficina = item.NombreOficina,
						CodigoUbigeo = item.CodigoUbigeo,
						TipoOficina = item.TipoOficina,
						Direccion = item.Direccion,
						Telefono = item.Telefono,
						Estado = item.Estado

                    }));
                }
                return OficinaBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("Oficina::GetAll::Error occured.", ex);
            }            
        }

        public List<OficinaBdo> GetAllBy(string fieldName, object value)
        {
            var OficinaBdos = new List<OficinaBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM Oficina WHERE {0} = {1} ";

                    var items = context.Oficina.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    OficinaBdos.AddRange(items.Select(item => new OficinaBdo()
                    {
						CodigoOficina = item.CodigoOficina,
						NombreOficina = item.NombreOficina,
						CodigoUbigeo = item.CodigoUbigeo,
						TipoOficina = item.TipoOficina,
						Direccion = item.Direccion,
						Telefono = item.Telefono,
						Estado = item.Estado

                    }));
                }

                return OficinaBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("Oficina::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
