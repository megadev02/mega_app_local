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
	/// Data access layer class for Concepto
	/// </summary>
	public partial class ConceptoDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public ConceptoDao()
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
		public bool Insert(ref ConceptoBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.ConceptoId;
                    Concepto objectInDb = (from p in context.Concepto
                                           where p.ConceptoId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.Concepto.Add(new Concepto()
                        {                        
							ConceptoId = objectBdo.ConceptoId,
							Nombre = objectBdo.Nombre,
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
				throw new Exception("Concepto::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref ConceptoBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.ConceptoId;
                    Concepto objectInDb = (from p in context.Concepto
                                           where p.ConceptoId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.ConceptoId = objectBdo.ConceptoId;
						objectInDb.Nombre = objectBdo.Nombre;
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
                throw new Exception("Concepto::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>Concepto business object</returns>
        public ConceptoBdo GetById(int id)
        {
            try
            {
                ConceptoBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    Concepto objectInDb = (from p in context.Concepto
                                       where p.ConceptoId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new ConceptoBdo()
                        {
							ConceptoId = objectInDb.ConceptoId,
							Nombre = objectInDb.Nombre,
							CodigoCuenta = objectInDb.CodigoCuenta

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Concepto::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of Concepto</returns>
        public List<ConceptoBdo> GetAll()
        {            
            try
            {
                
                var ConceptoBdos = new List<ConceptoBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.Concepto.ToList();
                
                    ConceptoBdos.AddRange(items.Select(item => new ConceptoBdo()
                    {
						ConceptoId = item.ConceptoId,
						Nombre = item.Nombre,
						CodigoCuenta = item.CodigoCuenta

                    }));
                }
                return ConceptoBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("Concepto::GetAll::Error occured.", ex);
            }            
        }

        public List<ConceptoBdo> GetAllBy(string fieldName, object value)
        {
            var ConceptoBdos = new List<ConceptoBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM Concepto WHERE {0} = {1} ";

                    var items = context.Concepto.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    ConceptoBdos.AddRange(items.Select(item => new ConceptoBdo()
                    {
						ConceptoId = item.ConceptoId,
						Nombre = item.Nombre,
						CodigoCuenta = item.CodigoCuenta

                    }));
                }

                return ConceptoBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("Concepto::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
