using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class CambioMonedaLogic
    {

        #region data Members

        CambioMonedaDao _dataObject = null;

        #endregion

        #region Constructor

        public CambioMonedaLogic()
        {
            _dataObject = new CambioMonedaDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CambioMoneda
        /// </summary>
        /// <param name="businessObject">CambioMoneda object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref CambioMonedaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing CambioMoneda
        /// </summary>
        /// <param name="businessObject">CambioMoneda object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref CambioMonedaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get CambioMoneda by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CambioMonedaBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all CambioMonedas
        /// </summary>
        /// <returns>list</returns>
        public List<CambioMonedaBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of CambioMoneda by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CambioMonedaBdo> GetAllBy(CambioMonedaBdo.CambioMonedaFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
