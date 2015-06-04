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
	/// Data access layer class for Asiento
	/// </summary>
	public partial class AsientoDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public AsientoDao()
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
		public bool Insert(ref AsientoBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.AsientoId;
                    Asiento objectInDb = (from p in context.Asiento
                                           where p.AsientoId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.Asiento.Add(new Asiento()
                        {                        
							AsientoId = objectBdo.AsientoId,
							Modulo = objectBdo.Modulo,
							FechaAsiento = objectBdo.FechaAsiento,
							NumeroAsiento = objectBdo.NumeroAsiento,
							Glosa = objectBdo.Glosa,
							ValorCambio = objectBdo.ValorCambio,
							CodDocumento = objectBdo.CodDocumento,
							ContratoId = objectBdo.ContratoId

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
				throw new Exception("Asiento::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref AsientoBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.AsientoId;
                    Asiento objectInDb = (from p in context.Asiento
                                           where p.AsientoId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.AsientoId = objectBdo.AsientoId;
						objectInDb.Modulo = objectBdo.Modulo;
						objectInDb.FechaAsiento = objectBdo.FechaAsiento;
						objectInDb.NumeroAsiento = objectBdo.NumeroAsiento;
						objectInDb.Glosa = objectBdo.Glosa;
						objectInDb.ValorCambio = objectBdo.ValorCambio;
						objectInDb.CodDocumento = objectBdo.CodDocumento;
						objectInDb.ContratoId = objectBdo.ContratoId;

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
                throw new Exception("Asiento::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>Asiento business object</returns>
        public AsientoBdo GetById(int id)
        {
            try
            {
                AsientoBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    Asiento objectInDb = (from p in context.Asiento
                                       where p.AsientoId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new AsientoBdo()
                        {
							AsientoId = objectInDb.AsientoId,
							Modulo = objectInDb.Modulo,
							FechaAsiento = objectInDb.FechaAsiento,
							NumeroAsiento = objectInDb.NumeroAsiento,
							Glosa = objectInDb.Glosa,
							ValorCambio = objectInDb.ValorCambio,
							CodDocumento = objectInDb.CodDocumento,
							ContratoId = objectInDb.ContratoId

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Asiento::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of Asiento</returns>
        public List<AsientoBdo> GetAll()
        {            
            try
            {
                
                var AsientoBdos = new List<AsientoBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.Asiento.ToList();
                
                    AsientoBdos.AddRange(items.Select(item => new AsientoBdo()
                    {
						AsientoId = item.AsientoId,
						Modulo = item.Modulo,
						FechaAsiento = item.FechaAsiento,
						NumeroAsiento = item.NumeroAsiento,
						Glosa = item.Glosa,
						ValorCambio = item.ValorCambio,
						CodDocumento = item.CodDocumento,
						ContratoId = item.ContratoId

                    }));
                }
                return AsientoBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("Asiento::GetAll::Error occured.", ex);
            }            
        }

        public List<AsientoBdo> GetAllBy(string fieldName, object value)
        {
            var AsientoBdos = new List<AsientoBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM Asiento WHERE {0} = {1} ";

                    var items = context.Asiento.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    AsientoBdos.AddRange(items.Select(item => new AsientoBdo()
                    {
						AsientoId = item.AsientoId,
						Modulo = item.Modulo,
						FechaAsiento = item.FechaAsiento,
						NumeroAsiento = item.NumeroAsiento,
						Glosa = item.Glosa,
						ValorCambio = item.ValorCambio,
						CodDocumento = item.CodDocumento,
						ContratoId = item.ContratoId

                    }));
                }

                return AsientoBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("Asiento::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
