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
	/// Data access layer class for PersonaDetalle
	/// </summary>
	public partial class PersonaDetalleDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public PersonaDetalleDao()
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
		public bool Insert(ref PersonaDetalleBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.PersonaDetalleId;
                    PersonaDetalle objectInDb = (from p in context.PersonaDetalle
                                           where p.PersonaDetalleId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.PersonaDetalle.Add(new PersonaDetalle()
                        {                        
							PersonaDetalleId = objectBdo.PersonaDetalleId,
							CodigoPersona = objectBdo.CodigoPersona,
							FechaHora = objectBdo.FechaHora,
							RutaImagen = objectBdo.RutaImagen,
							HuellaDigital = objectBdo.HuellaDigital

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
				throw new Exception("PersonaDetalle::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref PersonaDetalleBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.PersonaDetalleId;
                    PersonaDetalle objectInDb = (from p in context.PersonaDetalle
                                           where p.PersonaDetalleId == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.PersonaDetalleId = objectBdo.PersonaDetalleId;
						objectInDb.CodigoPersona = objectBdo.CodigoPersona;
						objectInDb.FechaHora = objectBdo.FechaHora;
						objectInDb.RutaImagen = objectBdo.RutaImagen;
						objectInDb.HuellaDigital = objectBdo.HuellaDigital;

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
                throw new Exception("PersonaDetalle::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>PersonaDetalle business object</returns>
        public PersonaDetalleBdo GetById(int id)
        {
            try
            {
                PersonaDetalleBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    PersonaDetalle objectInDb = (from p in context.PersonaDetalle
                                       where p.PersonaDetalleId == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new PersonaDetalleBdo()
                        {
							PersonaDetalleId = objectInDb.PersonaDetalleId,
							CodigoPersona = objectInDb.CodigoPersona,
							FechaHora = objectInDb.FechaHora,
							RutaImagen = objectInDb.RutaImagen,
							HuellaDigital = objectInDb.HuellaDigital

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("PersonaDetalle::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of PersonaDetalle</returns>
        public List<PersonaDetalleBdo> GetAll()
        {            
            try
            {
                
                var PersonaDetalleBdos = new List<PersonaDetalleBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.PersonaDetalle.ToList();
                
                    PersonaDetalleBdos.AddRange(items.Select(item => new PersonaDetalleBdo()
                    {
						PersonaDetalleId = item.PersonaDetalleId,
						CodigoPersona = item.CodigoPersona,
						FechaHora = item.FechaHora,
						RutaImagen = item.RutaImagen,
						HuellaDigital = item.HuellaDigital

                    }));
                }
                return PersonaDetalleBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("PersonaDetalle::GetAll::Error occured.", ex);
            }            
        }

        public List<PersonaDetalleBdo> GetAllBy(string fieldName, object value)
        {
            var PersonaDetalleBdos = new List<PersonaDetalleBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM PersonaDetalle WHERE {0} = {1} ";

                    var items = context.PersonaDetalle.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    PersonaDetalleBdos.AddRange(items.Select(item => new PersonaDetalleBdo()
                    {
						PersonaDetalleId = item.PersonaDetalleId,
						CodigoPersona = item.CodigoPersona,
						FechaHora = item.FechaHora,
						RutaImagen = item.RutaImagen,
						HuellaDigital = item.HuellaDigital

                    }));
                }

                return PersonaDetalleBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("PersonaDetalle::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
