using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class DepositoPrestamoLogic
    {

        #region data Members

        DepositoPrestamoDao _dataObject = null;

        #endregion

        #region Constructor

        public DepositoPrestamoLogic()
        {
            _dataObject = new DepositoPrestamoDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new DepositoPrestamo
        /// </summary>
        /// <param name="businessObject">DepositoPrestamo object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref DepositoPrestamoBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing DepositoPrestamo
        /// </summary>
        /// <param name="businessObject">DepositoPrestamo object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref DepositoPrestamoBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get DepositoPrestamo by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public DepositoPrestamoBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all DepositoPrestamos
        /// </summary>
        /// <returns>list</returns>
        public List<DepositoPrestamoBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of DepositoPrestamo by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<DepositoPrestamoBdo> GetAllBy(DepositoPrestamoBdo.DepositoPrestamoFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
