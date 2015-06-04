using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class CajaLogic
    {

        #region data Members

        CajaDao _dataObject = null;

        #endregion

        #region Constructor

        public CajaLogic()
        {
            _dataObject = new CajaDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Caja
        /// </summary>
        /// <param name="businessObject">Caja object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref CajaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing Caja
        /// </summary>
        /// <param name="businessObject">Caja object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref CajaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get Caja by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CajaBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all Cajas
        /// </summary>
        /// <returns>list</returns>
        public List<CajaBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of Caja by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CajaBdo> GetAllBy(CajaBdo.CajaFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
