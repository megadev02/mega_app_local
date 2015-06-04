using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class DenominacionMonedaLogic
    {

        #region data Members

        DenominacionMonedaDao _dataObject = null;

        #endregion

        #region Constructor

        public DenominacionMonedaLogic()
        {
            _dataObject = new DenominacionMonedaDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new DenominacionMoneda
        /// </summary>
        /// <param name="businessObject">DenominacionMoneda object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref DenominacionMonedaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing DenominacionMoneda
        /// </summary>
        /// <param name="businessObject">DenominacionMoneda object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref DenominacionMonedaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get DenominacionMoneda by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public DenominacionMonedaBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all DenominacionMonedas
        /// </summary>
        /// <returns>list</returns>
        public List<DenominacionMonedaBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of DenominacionMoneda by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<DenominacionMonedaBdo> GetAllBy(DenominacionMonedaBdo.DenominacionMonedaFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
