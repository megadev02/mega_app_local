using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class TipoCambioLogic
    {

        #region data Members

        TipoCambioDao _dataObject = null;

        #endregion

        #region Constructor

        public TipoCambioLogic()
        {
            _dataObject = new TipoCambioDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new TipoCambio
        /// </summary>
        /// <param name="businessObject">TipoCambio object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref TipoCambioBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing TipoCambio
        /// </summary>
        /// <param name="businessObject">TipoCambio object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref TipoCambioBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get TipoCambio by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public TipoCambioBdo GetById(DateTime id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all TipoCambios
        /// </summary>
        /// <returns>list</returns>
        public List<TipoCambioBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of TipoCambio by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<TipoCambioBdo> GetAllBy(TipoCambioBdo.TipoCambioFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
