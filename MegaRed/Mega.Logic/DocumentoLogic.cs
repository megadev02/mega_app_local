using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class DocumentoLogic
    {

        #region data Members

        DocumentoDao _dataObject = null;

        #endregion

        #region Constructor

        public DocumentoLogic()
        {
            _dataObject = new DocumentoDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Documento
        /// </summary>
        /// <param name="businessObject">Documento object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref DocumentoBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing Documento
        /// </summary>
        /// <param name="businessObject">Documento object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref DocumentoBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get Documento by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public DocumentoBdo GetById(string id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all Documentos
        /// </summary>
        /// <returns>list</returns>
        public List<DocumentoBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of Documento by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<DocumentoBdo> GetAllBy(DocumentoBdo.DocumentoFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
