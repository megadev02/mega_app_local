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
	/// Data access layer class for EmpresaAfiliada
	/// </summary>
	public partial class EmpresaAfiliadaDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public EmpresaAfiliadaDao()
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
		public bool Insert(ref EmpresaAfiliadaBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.EmpresaAfiliadaId;
                    EmpresaAfiliada objectInDb = (from p in context.EmpresaAfiliada
                                           where p.EmpresaAfiliadaId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.EmpresaAfiliada.Add(new EmpresaAfiliada()
                        {                        
							EmpresaAfiliadaId = objectBdo.EmpresaAfiliadaId,
							CodigoPersona = objectBdo.CodigoPersona

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
				throw new Exception("EmpresaAfiliada::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref EmpresaAfiliadaBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.EmpresaAfiliadaId;
                    EmpresaAfiliada objectInDb = (from p in context.EmpresaAfiliada
                                           where p.EmpresaAfiliadaId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.EmpresaAfiliadaId = objectBdo.EmpresaAfiliadaId;
						objectInDb.CodigoPersona = objectBdo.CodigoPersona;

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
                throw new Exception("EmpresaAfiliada::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>EmpresaAfiliada business object</returns>
        public EmpresaAfiliadaBdo GetById(int id)
        {
            try
            {
                EmpresaAfiliadaBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    EmpresaAfiliada objectInDb = (from p in context.EmpresaAfiliada
                                       where p.EmpresaAfiliadaId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new EmpresaAfiliadaBdo()
                        {
							EmpresaAfiliadaId = objectInDb.EmpresaAfiliadaId,
							CodigoPersona = objectInDb.CodigoPersona

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("EmpresaAfiliada::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of EmpresaAfiliada</returns>
        public List<EmpresaAfiliadaBdo> GetAll()
        {            
            try
            {
                
                var EmpresaAfiliadaBdos = new List<EmpresaAfiliadaBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.EmpresaAfiliada.ToList();
                
                    EmpresaAfiliadaBdos.AddRange(items.Select(item => new EmpresaAfiliadaBdo()
                    {
						EmpresaAfiliadaId = item.EmpresaAfiliadaId,
						CodigoPersona = item.CodigoPersona

                    }));
                }
                return EmpresaAfiliadaBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("EmpresaAfiliada::GetAll::Error occured.", ex);
            }            
        }

        public List<EmpresaAfiliadaBdo> GetAllBy(string fieldName, object value)
        {
            var EmpresaAfiliadaBdos = new List<EmpresaAfiliadaBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM EmpresaAfiliada WHERE {0} = {1} ";

                    var items = context.EmpresaAfiliada.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    EmpresaAfiliadaBdos.AddRange(items.Select(item => new EmpresaAfiliadaBdo()
                    {
						EmpresaAfiliadaId = item.EmpresaAfiliadaId,
						CodigoPersona = item.CodigoPersona

                    }));
                }

                return EmpresaAfiliadaBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("EmpresaAfiliada::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
