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
	/// Data access layer class for CajaApertura
	/// </summary>
	public partial class CajaAperturaDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CajaAperturaDao()
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
		public bool Insert(ref CajaAperturaBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.CajaAperturaId;
                    CajaApertura objectInDb = (from p in context.CajaApertura
                                           where p.CajaAperturaId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.CajaApertura.Add(new CajaApertura()
                        {                        
							CajaAperturaId = objectBdo.CajaAperturaId,
							CajaId = objectBdo.CajaId,
							FechaTrabajo = objectBdo.FechaTrabajo,
							UsuarioId = objectBdo.UsuarioId,
							FechaHoraApertura = objectBdo.FechaHoraApertura,
							MontoAperturaS = objectBdo.MontoAperturaS,
							MontoAperturaD = objectBdo.MontoAperturaD,
							MontoCierreS = objectBdo.MontoCierreS,
							MontoCierreD = objectBdo.MontoCierreD,
							FechaHoraArqueo = objectBdo.FechaHoraArqueo,
							FlagCerrado = objectBdo.FlagCerrado,
							Observacion = objectBdo.Observacion

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
				throw new Exception("CajaApertura::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref CajaAperturaBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.CajaAperturaId;
                    CajaApertura objectInDb = (from p in context.CajaApertura
                                           where p.CajaAperturaId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.CajaAperturaId = objectBdo.CajaAperturaId;
						objectInDb.CajaId = objectBdo.CajaId;
						objectInDb.FechaTrabajo = objectBdo.FechaTrabajo;
						objectInDb.UsuarioId = objectBdo.UsuarioId;
						objectInDb.FechaHoraApertura = objectBdo.FechaHoraApertura;
						objectInDb.MontoAperturaS = objectBdo.MontoAperturaS;
						objectInDb.MontoAperturaD = objectBdo.MontoAperturaD;
						objectInDb.MontoCierreS = objectBdo.MontoCierreS;
						objectInDb.MontoCierreD = objectBdo.MontoCierreD;
						objectInDb.FechaHoraArqueo = objectBdo.FechaHoraArqueo;
						objectInDb.FlagCerrado = objectBdo.FlagCerrado;
						objectInDb.Observacion = objectBdo.Observacion;

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
                throw new Exception("CajaApertura::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>CajaApertura business object</returns>
        public CajaAperturaBdo GetById(int id)
        {
            try
            {
                CajaAperturaBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    CajaApertura objectInDb = (from p in context.CajaApertura
                                       where p.CajaAperturaId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new CajaAperturaBdo()
                        {
							CajaAperturaId = objectInDb.CajaAperturaId,
							CajaId = objectInDb.CajaId,
							FechaTrabajo = objectInDb.FechaTrabajo,
							UsuarioId = objectInDb.UsuarioId,
							FechaHoraApertura = objectInDb.FechaHoraApertura,
							MontoAperturaS = objectInDb.MontoAperturaS,
							MontoAperturaD = objectInDb.MontoAperturaD,
							MontoCierreS = objectInDb.MontoCierreS,
							MontoCierreD = objectInDb.MontoCierreD,
							FechaHoraArqueo = objectInDb.FechaHoraArqueo,
							FlagCerrado = objectInDb.FlagCerrado,
							Observacion = objectInDb.Observacion

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("CajaApertura::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of CajaApertura</returns>
        public List<CajaAperturaBdo> GetAll()
        {            
            try
            {
                
                var CajaAperturaBdos = new List<CajaAperturaBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.CajaApertura.ToList();
                
                    CajaAperturaBdos.AddRange(items.Select(item => new CajaAperturaBdo()
                    {
						CajaAperturaId = item.CajaAperturaId,
						CajaId = item.CajaId,
						FechaTrabajo = item.FechaTrabajo,
						UsuarioId = item.UsuarioId,
						FechaHoraApertura = item.FechaHoraApertura,
						MontoAperturaS = item.MontoAperturaS,
						MontoAperturaD = item.MontoAperturaD,
						MontoCierreS = item.MontoCierreS,
						MontoCierreD = item.MontoCierreD,
						FechaHoraArqueo = item.FechaHoraArqueo,
						FlagCerrado = item.FlagCerrado,
						Observacion = item.Observacion

                    }));
                }
                return CajaAperturaBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("CajaApertura::GetAll::Error occured.", ex);
            }            
        }

        public List<CajaAperturaBdo> GetAllBy(string fieldName, object value)
        {
            var CajaAperturaBdos = new List<CajaAperturaBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM CajaApertura WHERE {0} = {1} ";

                    var items = context.CajaApertura.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    CajaAperturaBdos.AddRange(items.Select(item => new CajaAperturaBdo()
                    {
						CajaAperturaId = item.CajaAperturaId,
						CajaId = item.CajaId,
						FechaTrabajo = item.FechaTrabajo,
						UsuarioId = item.UsuarioId,
						FechaHoraApertura = item.FechaHoraApertura,
						MontoAperturaS = item.MontoAperturaS,
						MontoAperturaD = item.MontoAperturaD,
						MontoCierreS = item.MontoCierreS,
						MontoCierreD = item.MontoCierreD,
						FechaHoraArqueo = item.FechaHoraArqueo,
						FlagCerrado = item.FlagCerrado,
						Observacion = item.Observacion

                    }));
                }

                return CajaAperturaBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("CajaApertura::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
