using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class CajaAperturaLogic
    {

        #region data Members

        CajaAperturaDao _dataObject = null;

        #endregion

        #region Constructor

        public CajaAperturaLogic()
        {
            _dataObject = new CajaAperturaDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CajaApertura
        /// </summary>
        /// <param name="businessObject">CajaApertura object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref CajaAperturaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing CajaApertura
        /// </summary>
        /// <param name="businessObject">CajaApertura object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref CajaAperturaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get CajaApertura by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CajaAperturaBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all CajaAperturas
        /// </summary>
        /// <returns>list</returns>
        public List<CajaAperturaBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of CajaApertura by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CajaAperturaBdo> GetAllBy(CajaAperturaBdo.CajaAperturaFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
