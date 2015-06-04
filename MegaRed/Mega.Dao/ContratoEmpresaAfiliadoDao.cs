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
	/// Data access layer class for ContratoEmpresaAfiliado
	/// </summary>
	public partial class ContratoEmpresaAfiliadoDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public ContratoEmpresaAfiliadoDao()
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
		public bool Insert(ref ContratoEmpresaAfiliadoBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.ContratoId;
                    ContratoEmpresaAfiliado objectInDb = (from p in context.ContratoEmpresaAfiliado
                                           where p.ContratoId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.ContratoEmpresaAfiliado.Add(new ContratoEmpresaAfiliado()
                        {                        
							ContratoId = objectBdo.ContratoId,
							CodigoOficina = objectBdo.CodigoOficina,
							EmpresaAfiliadaId = objectBdo.EmpresaAfiliadaId,
							ComisionDTDirecto = objectBdo.ComisionDTDirecto,
							ComisionDTAfiliado = objectBdo.ComisionDTAfiliado,
							Garantia = objectBdo.Garantia,
							FechaContrato = objectBdo.FechaContrato,
							Estado = objectBdo.Estado,
							SujetoVariacionArreglo = objectBdo.SujetoVariacionArreglo

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
				throw new Exception("ContratoEmpresaAfiliado::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref ContratoEmpresaAfiliadoBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.ContratoId;
                    ContratoEmpresaAfiliado objectInDb = (from p in context.ContratoEmpresaAfiliado
                                           where p.ContratoId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.ContratoId = objectBdo.ContratoId;
						objectInDb.CodigoOficina = objectBdo.CodigoOficina;
						objectInDb.EmpresaAfiliadaId = objectBdo.EmpresaAfiliadaId;
						objectInDb.ComisionDTDirecto = objectBdo.ComisionDTDirecto;
						objectInDb.ComisionDTAfiliado = objectBdo.ComisionDTAfiliado;
						objectInDb.Garantia = objectBdo.Garantia;
						objectInDb.FechaContrato = objectBdo.FechaContrato;
						objectInDb.Estado = objectBdo.Estado;
						objectInDb.SujetoVariacionArreglo = objectBdo.SujetoVariacionArreglo;

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
                throw new Exception("ContratoEmpresaAfiliado::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>ContratoEmpresaAfiliado business object</returns>
        public ContratoEmpresaAfiliadoBdo GetById(int id)
        {
            try
            {
                ContratoEmpresaAfiliadoBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    ContratoEmpresaAfiliado objectInDb = (from p in context.ContratoEmpresaAfiliado
                                       where p.ContratoId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new ContratoEmpresaAfiliadoBdo()
                        {
							ContratoId = objectInDb.ContratoId,
							CodigoOficina = objectInDb.CodigoOficina,
							EmpresaAfiliadaId = objectInDb.EmpresaAfiliadaId,
							ComisionDTDirecto = objectInDb.ComisionDTDirecto,
							ComisionDTAfiliado = objectInDb.ComisionDTAfiliado,
							Garantia = objectInDb.Garantia,
							FechaContrato = objectInDb.FechaContrato,
							Estado = objectInDb.Estado,
							SujetoVariacionArreglo = objectInDb.SujetoVariacionArreglo

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("ContratoEmpresaAfiliado::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of ContratoEmpresaAfiliado</returns>
        public List<ContratoEmpresaAfiliadoBdo> GetAll()
        {            
            try
            {
                
                var ContratoEmpresaAfiliadoBdos = new List<ContratoEmpresaAfiliadoBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.ContratoEmpresaAfiliado.ToList();
                
                    ContratoEmpresaAfiliadoBdos.AddRange(items.Select(item => new ContratoEmpresaAfiliadoBdo()
                    {
						ContratoId = item.ContratoId,
						CodigoOficina = item.CodigoOficina,
						EmpresaAfiliadaId = item.EmpresaAfiliadaId,
						ComisionDTDirecto = item.ComisionDTDirecto,
						ComisionDTAfiliado = item.ComisionDTAfiliado,
						Garantia = item.Garantia,
						FechaContrato = item.FechaContrato,
						Estado = item.Estado,
						SujetoVariacionArreglo = item.SujetoVariacionArreglo

                    }));
                }
                return ContratoEmpresaAfiliadoBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("ContratoEmpresaAfiliado::GetAll::Error occured.", ex);
            }            
        }

        public List<ContratoEmpresaAfiliadoBdo> GetAllBy(string fieldName, object value)
        {
            var ContratoEmpresaAfiliadoBdos = new List<ContratoEmpresaAfiliadoBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM ContratoEmpresaAfiliado WHERE {0} = {1} ";

                    var items = context.ContratoEmpresaAfiliado.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    ContratoEmpresaAfiliadoBdos.AddRange(items.Select(item => new ContratoEmpresaAfiliadoBdo()
                    {
						ContratoId = item.ContratoId,
						CodigoOficina = item.CodigoOficina,
						EmpresaAfiliadaId = item.EmpresaAfiliadaId,
						ComisionDTDirecto = item.ComisionDTDirecto,
						ComisionDTAfiliado = item.ComisionDTAfiliado,
						Garantia = item.Garantia,
						FechaContrato = item.FechaContrato,
						Estado = item.Estado,
						SujetoVariacionArreglo = item.SujetoVariacionArreglo

                    }));
                }

                return ContratoEmpresaAfiliadoBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("ContratoEmpresaAfiliado::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
