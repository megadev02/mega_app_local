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
	/// Data access layer class for AsientoDetalle
	/// </summary>
	public partial class AsientoDetalleDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public AsientoDetalleDao()
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
		public bool Insert(ref AsientoDetalleBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.AsientoDetalleId;
                    AsientoDetalle objectInDb = (from p in context.AsientoDetalle
                                           where p.AsientoDetalleId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.AsientoDetalle.Add(new AsientoDetalle()
                        {                        
							AsientoDetalleId = objectBdo.AsientoDetalleId,
							Debe = objectBdo.Debe,
							Haber = objectBdo.Haber,
							Tipo = objectBdo.Tipo,
							DebeDolar = objectBdo.DebeDolar,
							HaberDolar = objectBdo.HaberDolar,
							AsientoId = objectBdo.AsientoId,
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
				throw new Exception("AsientoDetalle::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref AsientoDetalleBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.AsientoDetalleId;
                    AsientoDetalle objectInDb = (from p in context.AsientoDetalle
                                           where p.AsientoDetalleId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.AsientoDetalleId = objectBdo.AsientoDetalleId;
						objectInDb.Debe = objectBdo.Debe;
						objectInDb.Haber = objectBdo.Haber;
						objectInDb.Tipo = objectBdo.Tipo;
						objectInDb.DebeDolar = objectBdo.DebeDolar;
						objectInDb.HaberDolar = objectBdo.HaberDolar;
						objectInDb.AsientoId = objectBdo.AsientoId;
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
                throw new Exception("AsientoDetalle::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>AsientoDetalle business object</returns>
        public AsientoDetalleBdo GetById(int id)
        {
            try
            {
                AsientoDetalleBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    AsientoDetalle objectInDb = (from p in context.AsientoDetalle
                                       where p.AsientoDetalleId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new AsientoDetalleBdo()
                        {
							AsientoDetalleId = objectInDb.AsientoDetalleId,
							Debe = objectInDb.Debe,
							Haber = objectInDb.Haber,
							Tipo = objectInDb.Tipo,
							DebeDolar = objectInDb.DebeDolar,
							HaberDolar = objectInDb.HaberDolar,
							AsientoId = objectInDb.AsientoId,
							CodigoCuenta = objectInDb.CodigoCuenta

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("AsientoDetalle::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of AsientoDetalle</returns>
        public List<AsientoDetalleBdo> GetAll()
        {            
            try
            {
                
                var AsientoDetalleBdos = new List<AsientoDetalleBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.AsientoDetalle.ToList();
                
                    AsientoDetalleBdos.AddRange(items.Select(item => new AsientoDetalleBdo()
                    {
						AsientoDetalleId = item.AsientoDetalleId,
						Debe = item.Debe,
						Haber = item.Haber,
						Tipo = item.Tipo,
						DebeDolar = item.DebeDolar,
						HaberDolar = item.HaberDolar,
						AsientoId = item.AsientoId,
						CodigoCuenta = item.CodigoCuenta

                    }));
                }
                return AsientoDetalleBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("AsientoDetalle::GetAll::Error occured.", ex);
            }            
        }

        public List<AsientoDetalleBdo> GetAllBy(string fieldName, object value)
        {
            var AsientoDetalleBdos = new List<AsientoDetalleBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM AsientoDetalle WHERE {0} = {1} ";

                    var items = context.AsientoDetalle.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    AsientoDetalleBdos.AddRange(items.Select(item => new AsientoDetalleBdo()
                    {
						AsientoDetalleId = item.AsientoDetalleId,
						Debe = item.Debe,
						Haber = item.Haber,
						Tipo = item.Tipo,
						DebeDolar = item.DebeDolar,
						HaberDolar = item.HaberDolar,
						AsientoId = item.AsientoId,
						CodigoCuenta = item.CodigoCuenta

                    }));
                }

                return AsientoDetalleBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("AsientoDetalle::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
