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
	/// Data access layer class for Persona
	/// </summary>
	public partial class PersonaDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public PersonaDao()
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
		public bool Insert(ref PersonaBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.CodigoPersona;
                    Persona objectInDb = (from p in context.Persona
                                           where p.CodigoPersona == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.Persona.Add(new Persona()
                        {                        
							CodigoPersona = objectBdo.CodigoPersona,
							TipoPersona = objectBdo.TipoPersona,
							RazonSocial = objectBdo.RazonSocial,
							PrimerNombre = objectBdo.PrimerNombre,
							SegundoNombre = objectBdo.SegundoNombre,
							ApellidoPaterno = objectBdo.ApellidoPaterno,
							ApellidoMaterno = objectBdo.ApellidoMaterno,
							TipoDocumentoId = objectBdo.TipoDocumentoId,
							NumeroDocumento = objectBdo.NumeroDocumento,
							CodigoUbigeo = objectBdo.CodigoUbigeo,
							DireccionDomicilio = objectBdo.DireccionDomicilio,
							Telefono = objectBdo.Telefono,
							Celular = objectBdo.Celular,
							Email = objectBdo.Email,
							Web = objectBdo.Web,
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
				throw new Exception("Persona::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref PersonaBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.CodigoPersona;
                    Persona objectInDb = (from p in context.Persona
                                           where p.CodigoPersona == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.CodigoPersona = objectBdo.CodigoPersona;
						objectInDb.TipoPersona = objectBdo.TipoPersona;
						objectInDb.RazonSocial = objectBdo.RazonSocial;
						objectInDb.PrimerNombre = objectBdo.PrimerNombre;
						objectInDb.SegundoNombre = objectBdo.SegundoNombre;
						objectInDb.ApellidoPaterno = objectBdo.ApellidoPaterno;
						objectInDb.ApellidoMaterno = objectBdo.ApellidoMaterno;
						objectInDb.TipoDocumentoId = objectBdo.TipoDocumentoId;
						objectInDb.NumeroDocumento = objectBdo.NumeroDocumento;
						objectInDb.CodigoUbigeo = objectBdo.CodigoUbigeo;
						objectInDb.DireccionDomicilio = objectBdo.DireccionDomicilio;
						objectInDb.Telefono = objectBdo.Telefono;
						objectInDb.Celular = objectBdo.Celular;
						objectInDb.Email = objectBdo.Email;
						objectInDb.Web = objectBdo.Web;
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
                throw new Exception("Persona::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>Persona business object</returns>
        public PersonaBdo GetById(string id)
        {
            try
            {
                PersonaBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    Persona objectInDb = (from p in context.Persona
                                       where p.CodigoPersona == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new PersonaBdo()
                        {
							CodigoPersona = objectInDb.CodigoPersona,
							TipoPersona = objectInDb.TipoPersona,
							RazonSocial = objectInDb.RazonSocial,
							PrimerNombre = objectInDb.PrimerNombre,
							SegundoNombre = objectInDb.SegundoNombre,
							ApellidoPaterno = objectInDb.ApellidoPaterno,
							ApellidoMaterno = objectInDb.ApellidoMaterno,
							TipoDocumentoId = objectInDb.TipoDocumentoId,
							NumeroDocumento = objectInDb.NumeroDocumento,
							CodigoUbigeo = objectInDb.CodigoUbigeo,
							DireccionDomicilio = objectInDb.DireccionDomicilio,
							Telefono = objectInDb.Telefono,
							Celular = objectInDb.Celular,
							Email = objectInDb.Email,
							Web = objectInDb.Web,
							Estado = objectInDb.Estado

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Persona::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of Persona</returns>
        public List<PersonaBdo> GetAll()
        {            
            try
            {
                
                var PersonaBdos = new List<PersonaBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.Persona.ToList();
                
                    PersonaBdos.AddRange(items.Select(item => new PersonaBdo()
                    {
						CodigoPersona = item.CodigoPersona,
						TipoPersona = item.TipoPersona,
						RazonSocial = item.RazonSocial,
						PrimerNombre = item.PrimerNombre,
						SegundoNombre = item.SegundoNombre,
						ApellidoPaterno = item.ApellidoPaterno,
						ApellidoMaterno = item.ApellidoMaterno,
						TipoDocumentoId = item.TipoDocumentoId,
						NumeroDocumento = item.NumeroDocumento,
						CodigoUbigeo = item.CodigoUbigeo,
						DireccionDomicilio = item.DireccionDomicilio,
						Telefono = item.Telefono,
						Celular = item.Celular,
						Email = item.Email,
						Web = item.Web,
						Estado = item.Estado

                    }));
                }
                return PersonaBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("Persona::GetAll::Error occured.", ex);
            }            
        }

        public List<PersonaBdo> GetAllBy(string fieldName, object value)
        {
            var PersonaBdos = new List<PersonaBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM Persona WHERE {0} = {1} ";

                    var items = context.Persona.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    PersonaBdos.AddRange(items.Select(item => new PersonaBdo()
                    {
						CodigoPersona = item.CodigoPersona,
						TipoPersona = item.TipoPersona,
						RazonSocial = item.RazonSocial,
						PrimerNombre = item.PrimerNombre,
						SegundoNombre = item.SegundoNombre,
						ApellidoPaterno = item.ApellidoPaterno,
						ApellidoMaterno = item.ApellidoMaterno,
						TipoDocumentoId = item.TipoDocumentoId,
						NumeroDocumento = item.NumeroDocumento,
						CodigoUbigeo = item.CodigoUbigeo,
						DireccionDomicilio = item.DireccionDomicilio,
						Telefono = item.Telefono,
						Celular = item.Celular,
						Email = item.Email,
						Web = item.Web,
						Estado = item.Estado

                    }));
                }

                return PersonaBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("Persona::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
