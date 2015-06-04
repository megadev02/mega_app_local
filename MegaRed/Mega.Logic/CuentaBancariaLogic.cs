using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class CuentaBancariaLogic
    {

        #region data Members

        CuentaBancariaDao _dataObject = null;

        #endregion

        #region Constructor

        public CuentaBancariaLogic()
        {
            _dataObject = new CuentaBancariaDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CuentaBancaria
        /// </summary>
        /// <param name="businessObject">CuentaBancaria object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref CuentaBancariaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing CuentaBancaria
        /// </summary>
        /// <param name="businessObject">CuentaBancaria object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref CuentaBancariaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get CuentaBancaria by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CuentaBancariaBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all CuentaBancarias
        /// </summary>
        /// <returns>list</returns>
        public List<CuentaBancariaBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of CuentaBancaria by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CuentaBancariaBdo> GetAllBy(CuentaBancariaBdo.CuentaBancariaFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
