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
	/// Data access layer class for CambioMoneda
	/// </summary>
	public partial class CambioMonedaDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CambioMonedaDao()
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
		public bool Insert(ref CambioMonedaBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.NumeroDocumento;
                    CambioMoneda objectInDb = (from p in context.CambioMoneda
                                           where p.NumeroDocumento == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.CambioMoneda.Add(new CambioMoneda()
                        {                        
							NumeroDocumento = objectBdo.NumeroDocumento,
							MonedaOrigenId = objectBdo.MonedaOrigenId,
							MonedaDestinoId = objectBdo.MonedaDestinoId,
							RazonSocial = objectBdo.RazonSocial,
							Importe = objectBdo.Importe,
							Fecha = objectBdo.Fecha,
							FlagImpreso = objectBdo.FlagImpreso,
							CajaAperturaId = objectBdo.CajaAperturaId,
							UsuarioAnulado = objectBdo.UsuarioAnulado,
							FechaHoraAnulacion = objectBdo.FechaHoraAnulacion,
							ConceptoId = objectBdo.ConceptoId

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
				throw new Exception("CambioMoneda::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref CambioMonedaBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.NumeroDocumento;
                    CambioMoneda objectInDb = (from p in context.CambioMoneda
                                           where p.NumeroDocumento == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.NumeroDocumento = objectBdo.NumeroDocumento;
						objectInDb.MonedaOrigenId = objectBdo.MonedaOrigenId;
						objectInDb.MonedaDestinoId = objectBdo.MonedaDestinoId;
						objectInDb.RazonSocial = objectBdo.RazonSocial;
						objectInDb.Importe = objectBdo.Importe;
						objectInDb.Fecha = objectBdo.Fecha;
						objectInDb.FlagImpreso = objectBdo.FlagImpreso;
						objectInDb.CajaAperturaId = objectBdo.CajaAperturaId;
						objectInDb.UsuarioAnulado = objectBdo.UsuarioAnulado;
						objectInDb.FechaHoraAnulacion = objectBdo.FechaHoraAnulacion;
						objectInDb.ConceptoId = objectBdo.ConceptoId;

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
                throw new Exception("CambioMoneda::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>CambioMoneda business object</returns>
        public CambioMonedaBdo GetById(int id)
        {
            try
            {
                CambioMonedaBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    CambioMoneda objectInDb = (from p in context.CambioMoneda
                                       where p.NumeroDocumento == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new CambioMonedaBdo()
                        {
							NumeroDocumento = objectInDb.NumeroDocumento,
							MonedaOrigenId = objectInDb.MonedaOrigenId,
							MonedaDestinoId = objectInDb.MonedaDestinoId,
							RazonSocial = objectInDb.RazonSocial,
							Importe = objectInDb.Importe,
							Fecha = objectInDb.Fecha,
							FlagImpreso = objectInDb.FlagImpreso,
							CajaAperturaId = objectInDb.CajaAperturaId,
							UsuarioAnulado = objectInDb.UsuarioAnulado,
							FechaHoraAnulacion = objectInDb.FechaHoraAnulacion,
							ConceptoId = objectInDb.ConceptoId

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("CambioMoneda::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of CambioMoneda</returns>
        public List<CambioMonedaBdo> GetAll()
        {            
            try
            {
                
                var CambioMonedaBdos = new List<CambioMonedaBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.CambioMoneda.ToList();
                
                    CambioMonedaBdos.AddRange(items.Select(item => new CambioMonedaBdo()
                    {
						NumeroDocumento = item.NumeroDocumento,
						MonedaOrigenId = item.MonedaOrigenId,
						MonedaDestinoId = item.MonedaDestinoId,
						RazonSocial = item.RazonSocial,
						Importe = item.Importe,
						Fecha = item.Fecha,
						FlagImpreso = item.FlagImpreso,
						CajaAperturaId = item.CajaAperturaId,
						UsuarioAnulado = item.UsuarioAnulado,
						FechaHoraAnulacion = item.FechaHoraAnulacion,
						ConceptoId = item.ConceptoId

                    }));
                }
                return CambioMonedaBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("CambioMoneda::GetAll::Error occured.", ex);
            }            
        }

        public List<CambioMonedaBdo> GetAllBy(string fieldName, object value)
        {
            var CambioMonedaBdos = new List<CambioMonedaBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM CambioMoneda WHERE {0} = {1} ";

                    var items = context.CambioMoneda.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    CambioMonedaBdos.AddRange(items.Select(item => new CambioMonedaBdo()
                    {
						NumeroDocumento = item.NumeroDocumento,
						MonedaOrigenId = item.MonedaOrigenId,
						MonedaDestinoId = item.MonedaDestinoId,
						RazonSocial = item.RazonSocial,
						Importe = item.Importe,
						Fecha = item.Fecha,
						FlagImpreso = item.FlagImpreso,
						CajaAperturaId = item.CajaAperturaId,
						UsuarioAnulado = item.UsuarioAnulado,
						FechaHoraAnulacion = item.FechaHoraAnulacion,
						ConceptoId = item.ConceptoId

                    }));
                }

                return CambioMonedaBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("CambioMoneda::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
