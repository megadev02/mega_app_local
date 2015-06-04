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
	/// Data access layer class for DenominacionMoneda
	/// </summary>
	public partial class DenominacionMonedaDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public DenominacionMonedaDao()
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
		public bool Insert(ref DenominacionMonedaBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.DenominacionMonedaId;
                    DenominacionMoneda objectInDb = (from p in context.DenominacionMoneda
                                           where p.DenominacionMonedaId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.DenominacionMoneda.Add(new DenominacionMoneda()
                        {                        
							DenominacionMonedaId = objectBdo.DenominacionMonedaId,
							Valor = objectBdo.Valor,
							Denominacion = objectBdo.Denominacion,
							MonedaId = objectBdo.MonedaId

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
				throw new Exception("DenominacionMoneda::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref DenominacionMonedaBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.DenominacionMonedaId;
                    DenominacionMoneda objectInDb = (from p in context.DenominacionMoneda
                                           where p.DenominacionMonedaId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.DenominacionMonedaId = objectBdo.DenominacionMonedaId;
						objectInDb.Valor = objectBdo.Valor;
						objectInDb.Denominacion = objectBdo.Denominacion;
						objectInDb.MonedaId = objectBdo.MonedaId;

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
                throw new Exception("DenominacionMoneda::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>DenominacionMoneda business object</returns>
        public DenominacionMonedaBdo GetById(int id)
        {
            try
            {
                DenominacionMonedaBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    DenominacionMoneda objectInDb = (from p in context.DenominacionMoneda
                                       where p.DenominacionMonedaId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new DenominacionMonedaBdo()
                        {
							DenominacionMonedaId = objectInDb.DenominacionMonedaId,
							Valor = objectInDb.Valor,
							Denominacion = objectInDb.Denominacion,
							MonedaId = objectInDb.MonedaId

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("DenominacionMoneda::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of DenominacionMoneda</returns>
        public List<DenominacionMonedaBdo> GetAll()
        {            
            try
            {
                
                var DenominacionMonedaBdos = new List<DenominacionMonedaBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.DenominacionMoneda.ToList();
                
                    DenominacionMonedaBdos.AddRange(items.Select(item => new DenominacionMonedaBdo()
                    {
						DenominacionMonedaId = item.DenominacionMonedaId,
						Valor = item.Valor,
						Denominacion = item.Denominacion,
						MonedaId = item.MonedaId

                    }));
                }
                return DenominacionMonedaBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("DenominacionMoneda::GetAll::Error occured.", ex);
            }            
        }

        public List<DenominacionMonedaBdo> GetAllBy(string fieldName, object value)
        {
            var DenominacionMonedaBdos = new List<DenominacionMonedaBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM DenominacionMoneda WHERE {0} = {1} ";

                    var items = context.DenominacionMoneda.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    DenominacionMonedaBdos.AddRange(items.Select(item => new DenominacionMonedaBdo()
                    {
						DenominacionMonedaId = item.DenominacionMonedaId,
						Valor = item.Valor,
						Denominacion = item.Denominacion,
						MonedaId = item.MonedaId

                    }));
                }

                return DenominacionMonedaBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("DenominacionMoneda::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
