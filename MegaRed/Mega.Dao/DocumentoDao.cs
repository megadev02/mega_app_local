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
	/// Data access layer class for Documento
	/// </summary>
	public partial class DocumentoDao
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public DocumentoDao()
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
		public bool Insert(ref DocumentoBdo objectBdo, ref string message)
		{
            message = "Agregado correctamente";
            bool ret = true;

			try
			{                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.CodDocumento;
                    Documento objectInDb = (from p in context.Documento
                                           where p.CodDocumento == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb == null)
                    {
                        context.Documento.Add(new Documento()
                        {                        
							CodDocumento = objectBdo.CodDocumento,
							CodComprobante = objectBdo.CodComprobante,
							NombreDocumento = objectBdo.NombreDocumento,
							ProcesoAsociado = objectBdo.ProcesoAsociado,
							FormatoImpresion = objectBdo.FormatoImpresion,
							PrimerDocumento = objectBdo.PrimerDocumento,
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
				throw new Exception("Documento::Insert::Error occured.", ex);
			}			
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(ref DocumentoBdo objectBdo, ref string message)
        {
            message = "El elemento fue actualizado";
            bool ret = true;

            try
            {                
                using (var context = new MegaEntities())
                {
                    var objectId = objectBdo.CodDocumento;
                    Documento objectInDb = (from p in context.Documento
                                           where p.CodDocumento == objectId
                                           select p).FirstOrDefault();

                    //check product
                    if (objectInDb != null)
                    {
						objectInDb.CodDocumento = objectBdo.CodDocumento;
						objectInDb.CodComprobante = objectBdo.CodComprobante;
						objectInDb.NombreDocumento = objectBdo.NombreDocumento;
						objectInDb.ProcesoAsociado = objectBdo.ProcesoAsociado;
						objectInDb.FormatoImpresion = objectBdo.FormatoImpresion;
						objectInDb.PrimerDocumento = objectBdo.PrimerDocumento;
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
                throw new Exception("Documento::Update::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>Documento business object</returns>
        public DocumentoBdo GetById(string id)
        {
            try
            {
                DocumentoBdo objectBdo = null;
                using (var context = new MegaEntities())
                {
                    Documento objectInDb = (from p in context.Documento
                                       where p.CodDocumento == id
                                       select p).FirstOrDefault();

                    if (objectInDb != null)
                        objectBdo = new DocumentoBdo()
                        {
							CodDocumento = objectInDb.CodDocumento,
							CodComprobante = objectInDb.CodComprobante,
							NombreDocumento = objectInDb.NombreDocumento,
							ProcesoAsociado = objectInDb.ProcesoAsociado,
							FormatoImpresion = objectInDb.FormatoImpresion,
							PrimerDocumento = objectInDb.PrimerDocumento,
							Estado = objectInDb.Estado

                            
                            //RowVersion = element.RowVersion
                        };
                }
                return objectBdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Documento::GetById::Error occured.", ex);
            }            
        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of Documento</returns>
        public List<DocumentoBdo> GetAll()
        {            
            try
            {
                
                var DocumentoBdos = new List<DocumentoBdo>();
                using (var context = new MegaEntities())
                {
                    var items = context.Documento.ToList();
                
                    DocumentoBdos.AddRange(items.Select(item => new DocumentoBdo()
                    {
						CodDocumento = item.CodDocumento,
						CodComprobante = item.CodComprobante,
						NombreDocumento = item.NombreDocumento,
						ProcesoAsociado = item.ProcesoAsociado,
						FormatoImpresion = item.FormatoImpresion,
						PrimerDocumento = item.PrimerDocumento,
						Estado = item.Estado

                    }));
                }
                return DocumentoBdos;

            }
            catch (Exception ex)
            {                
                throw new Exception("Documento::GetAll::Error occured.", ex);
            }            
        }

        public List<DocumentoBdo> GetAllBy(string fieldName, object value)
        {
            var DocumentoBdos = new List<DocumentoBdo>();

            try
            {
                using (var context = new MegaEntities())
                {
                    string sql = "SELECT * FROM Documento WHERE {0} = {1} ";

                    var items = context.Documento.SqlQuery(String.Format(sql, fieldName, value)).ToList();

                    DocumentoBdos.AddRange(items.Select(item => new DocumentoBdo()
                    {
						CodDocumento = item.CodDocumento,
						CodComprobante = item.CodComprobante,
						NombreDocumento = item.NombreDocumento,
						ProcesoAsociado = item.ProcesoAsociado,
						FormatoImpresion = item.FormatoImpresion,
						PrimerDocumento = item.PrimerDocumento,
						Estado = item.Estado

                    }));
                }

                return DocumentoBdos;
            }
            catch (Exception ex)
            {                
                throw new Exception("Documento::GetAllBy::Error occured.", ex);
            }
            
        }
        #endregion
	}
}
