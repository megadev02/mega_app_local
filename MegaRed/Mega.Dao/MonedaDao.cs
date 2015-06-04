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
	/// Data access layer class for Moneda
	/// </summary>
	public partial class MonedaDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public MonedaDao()
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
		public bool Insert(ref MonedaBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.MonedaId;
                    Moneda objectInDb = (from p in context.Moneda
                                           where p.MonedaId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.Moneda.Add(new Moneda()
                        {                        
							MonedaId = objectBdo.MonedaId,
							Nombre = objectBdo.Nombre,
							Simbolo = objectBdo.Simbolo,
							Abreviatura = objectBdo.Abreviatura,
							Referencia = objectBdo.Referencia,
							EsNacional = objectBdo.EsNacional,
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
				throw new Exception("Moneda::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref MonedaBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.MonedaId;
                    Moneda objectInDb = (from p in context.Moneda
                                           where p.MonedaId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.MonedaId = objectBdo.MonedaId;
						objectInDb.Nombre = objectBdo.Nombre;
						objectInDb.Simbolo = objectBdo.Simbolo;
						objectInDb.Abreviatura = objectBdo.Abreviatura;
						objectInDb.Referencia = objectBdo.Referencia;
						objectInDb.EsNacional = objectBdo.EsNacional;
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
                throw new Exception("Moneda::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>Moneda business object</returns>
        public MonedaBdo GetById(int id)
        {
            try
            {
                MonedaBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    Moneda objectInDb = (from p in context.Moneda
                                       where p.MonedaId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new MonedaBdo()
                        {
							MonedaId = objectInDb.MonedaId,
							Nombre = objectInDb.Nombre,
							Simbolo = objectInDb.Simbolo,
							Abreviatura = objectInDb.Abreviatura,
							Referencia = objectInDb.Referencia,
							EsNacional = objectInDb.EsNacional,
							Estado = objectInDb.Estado

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Moneda::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of Moneda</returns>
        public List<MonedaBdo> GetAll()
        {            
            try
            {
                
                var MonedaBdos = new List<MonedaBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.Moneda.ToList();
                
                    MonedaBdos.AddRange(items.Select(item => new MonedaBdo()
                    {
						MonedaId = item.MonedaId,
						Nombre = item.Nombre,
						Simbolo = item.Simbolo,
						Abreviatura = item.Abreviatura,
						Referencia = item.Referencia,
						EsNacional = item.EsNacional,
						Estado = item.Estado

                    }));
                }
                return MonedaBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("Moneda::GetAll::Error occured.", ex);
            }            
        }

        public List<MonedaBdo> GetAllBy(string fieldName, object value)
        {
            var MonedaBdos = new List<MonedaBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM Moneda WHERE {0} = {1} ";

                    var items = context.Moneda.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    MonedaBdos.AddRange(items.Select(item => new MonedaBdo()
                    {
						MonedaId = item.MonedaId,
						Nombre = item.Nombre,
						Simbolo = item.Simbolo,
						Abreviatura = item.Abreviatura,
						Referencia = item.Referencia,
						EsNacional = item.EsNacional,
						Estado = item.Estado

                    }));
                }

                return MonedaBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("Moneda::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
