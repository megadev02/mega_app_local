using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class ComprobanteLogic
    {

        #region data Members

        ComprobanteDao _dataObject = null;

        #endregion

        #region Constructor

        public ComprobanteLogic()
        {
            _dataObject = new ComprobanteDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Comprobante
        /// </summary>
        /// <param name="businessObject">Comprobante object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref ComprobanteBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing Comprobante
        /// </summary>
        /// <param name="businessObject">Comprobante object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref ComprobanteBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get Comprobante by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public ComprobanteBdo GetById(string id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all Comprobantes
        /// </summary>
        /// <returns>list</returns>
        public List<ComprobanteBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of Comprobante by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<ComprobanteBdo> GetAllBy(ComprobanteBdo.ComprobanteFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
