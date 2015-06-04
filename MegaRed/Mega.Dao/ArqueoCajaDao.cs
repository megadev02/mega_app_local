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
	/// Data access layer class for ArqueoCaja
	/// </summary>
	public partial class ArqueoCajaDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public ArqueoCajaDao()
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
		public bool Insert(ref ArqueoCajaBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.ArqueoCajaId;
                    ArqueoCaja objectInDb = (from p in context.ArqueoCaja
                                           where p.ArqueoCajaId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.ArqueoCaja.Add(new ArqueoCaja()
                        {                        
							ArqueoCajaId = objectBdo.ArqueoCajaId,
							IdDenominacionMoneda = objectBdo.IdDenominacionMoneda,
							Cantidad = objectBdo.Cantidad,
							CajaAperturaId = objectBdo.CajaAperturaId

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
				throw new Exception("ArqueoCaja::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref ArqueoCajaBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.ArqueoCajaId;
                    ArqueoCaja objectInDb = (from p in context.ArqueoCaja
                                           where p.ArqueoCajaId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.ArqueoCajaId = objectBdo.ArqueoCajaId;
						objectInDb.IdDenominacionMoneda = objectBdo.IdDenominacionMoneda;
						objectInDb.Cantidad = objectBdo.Cantidad;
						objectInDb.CajaAperturaId = objectBdo.CajaAperturaId;

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
                throw new Exception("ArqueoCaja::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>ArqueoCaja business object</returns>
        public ArqueoCajaBdo GetById(int id)
        {
            try
            {
                ArqueoCajaBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    ArqueoCaja objectInDb = (from p in context.ArqueoCaja
                                       where p.ArqueoCajaId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new ArqueoCajaBdo()
                        {
							ArqueoCajaId = objectInDb.ArqueoCajaId,
							IdDenominacionMoneda = objectInDb.IdDenominacionMoneda,
							Cantidad = objectInDb.Cantidad,
							CajaAperturaId = objectInDb.CajaAperturaId

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("ArqueoCaja::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of ArqueoCaja</returns>
        public List<ArqueoCajaBdo> GetAll()
        {            
            try
            {
                
                var ArqueoCajaBdos = new List<ArqueoCajaBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.ArqueoCaja.ToList();
                
                    ArqueoCajaBdos.AddRange(items.Select(item => new ArqueoCajaBdo()
                    {
						ArqueoCajaId = item.ArqueoCajaId,
						IdDenominacionMoneda = item.IdDenominacionMoneda,
						Cantidad = item.Cantidad,
						CajaAperturaId = item.CajaAperturaId

                    }));
                }
                return ArqueoCajaBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("ArqueoCaja::GetAll::Error occured.", ex);
            }            
        }

        public List<ArqueoCajaBdo> GetAllBy(string fieldName, object value)
        {
            var ArqueoCajaBdos = new List<ArqueoCajaBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM ArqueoCaja WHERE {0} = {1} ";

                    var items = context.ArqueoCaja.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    ArqueoCajaBdos.AddRange(items.Select(item => new ArqueoCajaBdo()
                    {
						ArqueoCajaId = item.ArqueoCajaId,
						IdDenominacionMoneda = item.IdDenominacionMoneda,
						Cantidad = item.Cantidad,
						CajaAperturaId = item.CajaAperturaId

                    }));
                }

                return ArqueoCajaBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("ArqueoCaja::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
