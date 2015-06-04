using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class MonedaLogic
    {

        #region data Members

        MonedaDao _dataObject = null;

        #endregion

        #region Constructor

        public MonedaLogic()
        {
            _dataObject = new MonedaDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Moneda
        /// </summary>
        /// <param name="businessObject">Moneda object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref MonedaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing Moneda
        /// </summary>
        /// <param name="businessObject">Moneda object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref MonedaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get Moneda by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public MonedaBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all Monedas
        /// </summary>
        /// <returns>list</returns>
        public List<MonedaBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of Moneda by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<MonedaBdo> GetAllBy(MonedaBdo.MonedaFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
