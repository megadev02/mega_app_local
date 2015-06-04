using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class TipoDocumentoIdentidadLogic
    {

        #region data Members

        TipoDocumentoIdentidadDao _dataObject = null;

        #endregion

        #region Constructor

        public TipoDocumentoIdentidadLogic()
        {
            _dataObject = new TipoDocumentoIdentidadDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new TipoDocumentoIdentidad
        /// </summary>
        /// <param name="businessObject">TipoDocumentoIdentidad object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref TipoDocumentoIdentidadBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing TipoDocumentoIdentidad
        /// </summary>
        /// <param name="businessObject">TipoDocumentoIdentidad object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref TipoDocumentoIdentidadBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get TipoDocumentoIdentidad by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public TipoDocumentoIdentidadBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all TipoDocumentoIdentidads
        /// </summary>
        /// <returns>list</returns>
        public List<TipoDocumentoIdentidadBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of TipoDocumentoIdentidad by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<TipoDocumentoIdentidadBdo> GetAllBy(TipoDocumentoIdentidadBdo.TipoDocumentoIdentidadFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
