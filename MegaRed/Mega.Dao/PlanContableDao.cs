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
	/// Data access layer class for PlanContable
	/// </summary>
	public partial class PlanContableDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public PlanContableDao()
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
		public bool Insert(ref PlanContableBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.CodigoCuenta;
                    PlanContable objectInDb = (from p in context.PlanContable
                                           where p.CodigoCuenta == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.PlanContable.Add(new PlanContable()
                        {                        
							CodigoCuenta = objectBdo.CodigoCuenta,
							Denominacion = objectBdo.Denominacion,
							Naturaleza = objectBdo.Naturaleza,
							TipoCuenta = objectBdo.TipoCuenta,
							Estructura = objectBdo.Estructura,
							Nivel = objectBdo.Nivel,
							CodigoCuentaPadre = objectBdo.CodigoCuentaPadre

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
				throw new Exception("PlanContable::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref PlanContableBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.CodigoCuenta;
                    PlanContable objectInDb = (from p in context.PlanContable
                                           where p.CodigoCuenta == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.CodigoCuenta = objectBdo.CodigoCuenta;
						objectInDb.Denominacion = objectBdo.Denominacion;
						objectInDb.Naturaleza = objectBdo.Naturaleza;
						objectInDb.TipoCuenta = objectBdo.TipoCuenta;
						objectInDb.Estructura = objectBdo.Estructura;
						objectInDb.Nivel = objectBdo.Nivel;
						objectInDb.CodigoCuentaPadre = objectBdo.CodigoCuentaPadre;

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
                throw new Exception("PlanContable::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>PlanContable business object</returns>
        public PlanContableBdo GetById(string id)
        {
            try
            {
                PlanContableBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    PlanContable objectInDb = (from p in context.PlanContable
                                       where p.CodigoCuenta == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new PlanContableBdo()
                        {
							CodigoCuenta = objectInDb.CodigoCuenta,
							Denominacion = objectInDb.Denominacion,
							Naturaleza = objectInDb.Naturaleza,
							TipoCuenta = objectInDb.TipoCuenta,
							Estructura = objectInDb.Estructura,
							Nivel = objectInDb.Nivel,
							CodigoCuentaPadre = objectInDb.CodigoCuentaPadre

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("PlanContable::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of PlanContable</returns>
        public List<PlanContableBdo> GetAll()
        {            
            try
            {
                
                var PlanContableBdos = new List<PlanContableBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.PlanContable.ToList();
                
                    PlanContableBdos.AddRange(items.Select(item => new PlanContableBdo()
                    {
						CodigoCuenta = item.CodigoCuenta,
						Denominacion = item.Denominacion,
						Naturaleza = item.Naturaleza,
						TipoCuenta = item.TipoCuenta,
						Estructura = item.Estructura,
						Nivel = item.Nivel,
						CodigoCuentaPadre = item.CodigoCuentaPadre

                    }));
                }
                return PlanContableBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("PlanContable::GetAll::Error occured.", ex);
            }            
        }

        public List<PlanContableBdo> GetAllBy(string fieldName, object value)
        {
            var PlanContableBdos = new List<PlanContableBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM PlanContable WHERE {0} = {1} ";

                    var items = context.PlanContable.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    PlanContableBdos.AddRange(items.Select(item => new PlanContableBdo()
                    {
						CodigoCuenta = item.CodigoCuenta,
						Denominacion = item.Denominacion,
						Naturaleza = item.Naturaleza,
						TipoCuenta = item.TipoCuenta,
						Estructura = item.Estructura,
						Nivel = item.Nivel,
						CodigoCuentaPadre = item.CodigoCuentaPadre

                    }));
                }

                return PlanContableBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("PlanContable::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
