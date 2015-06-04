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
	/// Data access layer class for CuentaBancaria
	/// </summary>
	public partial class CuentaBancariaDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CuentaBancariaDao()
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
		public bool Insert(ref CuentaBancariaBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.NumeroCuentaBanco;
                    CuentaBancaria objectInDb = (from p in context.CuentaBancaria
                                           where p.NumeroCuentaBanco == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.CuentaBancaria.Add(new CuentaBancaria()
                        {                        
							NumeroCuentaBanco = objectBdo.NumeroCuentaBanco,
							NombreCuentaBancaria = objectBdo.NombreCuentaBancaria,
							TipoCuenta = objectBdo.TipoCuenta,
							Estado = objectBdo.Estado,
							CodigoPersona = objectBdo.CodigoPersona,
							EntidadId = objectBdo.EntidadId,
							CodigoCuenta = objectBdo.CodigoCuenta,
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
				throw new Exception("CuentaBancaria::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref CuentaBancariaBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.NumeroCuentaBanco;
                    CuentaBancaria objectInDb = (from p in context.CuentaBancaria
                                           where p.NumeroCuentaBanco == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.NumeroCuentaBanco = objectBdo.NumeroCuentaBanco;
						objectInDb.NombreCuentaBancaria = objectBdo.NombreCuentaBancaria;
						objectInDb.TipoCuenta = objectBdo.TipoCuenta;
						objectInDb.Estado = objectBdo.Estado;
						objectInDb.CodigoPersona = objectBdo.CodigoPersona;
						objectInDb.EntidadId = objectBdo.EntidadId;
						objectInDb.CodigoCuenta = objectBdo.CodigoCuenta;
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
                throw new Exception("CuentaBancaria::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>CuentaBancaria business object</returns>
        public CuentaBancariaBdo GetById(int id)
        {
            try
            {
                CuentaBancariaBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    CuentaBancaria objectInDb = (from p in context.CuentaBancaria
                                       where p.NumeroCuentaBanco == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new CuentaBancariaBdo()
                        {
							NumeroCuentaBanco = objectInDb.NumeroCuentaBanco,
							NombreCuentaBancaria = objectInDb.NombreCuentaBancaria,
							TipoCuenta = objectInDb.TipoCuenta,
							Estado = objectInDb.Estado,
							CodigoPersona = objectInDb.CodigoPersona,
							EntidadId = objectInDb.EntidadId,
							CodigoCuenta = objectInDb.CodigoCuenta,
							MonedaId = objectInDb.MonedaId

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("CuentaBancaria::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of CuentaBancaria</returns>
        public List<CuentaBancariaBdo> GetAll()
        {            
            try
            {
                
                var CuentaBancariaBdos = new List<CuentaBancariaBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.CuentaBancaria.ToList();
                
                    CuentaBancariaBdos.AddRange(items.Select(item => new CuentaBancariaBdo()
                    {
						NumeroCuentaBanco = item.NumeroCuentaBanco,
						NombreCuentaBancaria = item.NombreCuentaBancaria,
						TipoCuenta = item.TipoCuenta,
						Estado = item.Estado,
						CodigoPersona = item.CodigoPersona,
						EntidadId = item.EntidadId,
						CodigoCuenta = item.CodigoCuenta,
						MonedaId = item.MonedaId

                    }));
                }
                return CuentaBancariaBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("CuentaBancaria::GetAll::Error occured.", ex);
            }            
        }

        public List<CuentaBancariaBdo> GetAllBy(string fieldName, object value)
        {
            var CuentaBancariaBdos = new List<CuentaBancariaBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM CuentaBancaria WHERE {0} = {1} ";

                    var items = context.CuentaBancaria.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    CuentaBancariaBdos.AddRange(items.Select(item => new CuentaBancariaBdo()
                    {
						NumeroCuentaBanco = item.NumeroCuentaBanco,
						NombreCuentaBancaria = item.NombreCuentaBancaria,
						TipoCuenta = item.TipoCuenta,
						Estado = item.Estado,
						CodigoPersona = item.CodigoPersona,
						EntidadId = item.EntidadId,
						CodigoCuenta = item.CodigoCuenta,
						MonedaId = item.MonedaId

                    }));
                }

                return CuentaBancariaBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("CuentaBancaria::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
