using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class ComprobanteCompraLogic
    {

        #region data Members

        ComprobanteCompraDao _dataObject = null;

        #endregion

        #region Constructor

        public ComprobanteCompraLogic()
        {
            _dataObject = new ComprobanteCompraDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new ComprobanteCompra
        /// </summary>
        /// <param name="businessObject">ComprobanteCompra object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref ComprobanteCompraBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing ComprobanteCompra
        /// </summary>
        /// <param name="businessObject">ComprobanteCompra object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref ComprobanteCompraBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get ComprobanteCompra by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public ComprobanteCompraBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all ComprobanteCompras
        /// </summary>
        /// <returns>list</returns>
        public List<ComprobanteCompraBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of ComprobanteCompra by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<ComprobanteCompraBdo> GetAllBy(ComprobanteCompraBdo.ComprobanteCompraFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
