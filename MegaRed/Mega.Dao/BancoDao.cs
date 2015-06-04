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
	/// Data access layer class for Banco
	/// </summary>
	public partial class BancoDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public BancoDao()
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
		public bool Insert(ref BancoBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.BancoId;
                    Banco objectInDb = (from p in context.Banco
                                           where p.BancoId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.Banco.Add(new Banco()
                        {                        
							BancoId = objectBdo.BancoId,
							EntidadId = objectBdo.EntidadId,
							Direccion = objectBdo.Direccion,
							CodigoUbigeo = objectBdo.CodigoUbigeo,
							Telefono1 = objectBdo.Telefono1,
							Telefono2 = objectBdo.Telefono2,
							Telefono3 = objectBdo.Telefono3,
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
				throw new Exception("Banco::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref BancoBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.BancoId;
                    Banco objectInDb = (from p in context.Banco
                                           where p.BancoId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.BancoId = objectBdo.BancoId;
						objectInDb.EntidadId = objectBdo.EntidadId;
						objectInDb.Direccion = objectBdo.Direccion;
						objectInDb.CodigoUbigeo = objectBdo.CodigoUbigeo;
						objectInDb.Telefono1 = objectBdo.Telefono1;
						objectInDb.Telefono2 = objectBdo.Telefono2;
						objectInDb.Telefono3 = objectBdo.Telefono3;
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
                throw new Exception("Banco::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>Banco business object</returns>
        public BancoBdo GetById(int id)
        {
            try
            {
                BancoBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    Banco objectInDb = (from p in context.Banco
                                       where p.BancoId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new BancoBdo()
                        {
							BancoId = objectInDb.BancoId,
							EntidadId = objectInDb.EntidadId,
							Direccion = objectInDb.Direccion,
							CodigoUbigeo = objectInDb.CodigoUbigeo,
							Telefono1 = objectInDb.Telefono1,
							Telefono2 = objectInDb.Telefono2,
							Telefono3 = objectInDb.Telefono3,
							Estado = objectInDb.Estado

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Banco::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of Banco</returns>
        public List<BancoBdo> GetAll()
        {            
            try
            {
                
                var BancoBdos = new List<BancoBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.Banco.ToList();
                
                    BancoBdos.AddRange(items.Select(item => new BancoBdo()
                    {
						BancoId = item.BancoId,
						EntidadId = item.EntidadId,
						Direccion = item.Direccion,
						CodigoUbigeo = item.CodigoUbigeo,
						Telefono1 = item.Telefono1,
						Telefono2 = item.Telefono2,
						Telefono3 = item.Telefono3,
						Estado = item.Estado

                    }));
                }
                return BancoBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("Banco::GetAll::Error occured.", ex);
            }            
        }

        public List<BancoBdo> GetAllBy(string fieldName, object value)
        {
            var BancoBdos = new List<BancoBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM Banco WHERE {0} = {1} ";

                    var items = context.Banco.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    BancoBdos.AddRange(items.Select(item => new BancoBdo()
                    {
						BancoId = item.BancoId,
						EntidadId = item.EntidadId,
						Direccion = item.Direccion,
						CodigoUbigeo = item.CodigoUbigeo,
						Telefono1 = item.Telefono1,
						Telefono2 = item.Telefono2,
						Telefono3 = item.Telefono3,
						Estado = item.Estado

                    }));
                }

                return BancoBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("Banco::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
