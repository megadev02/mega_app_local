using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class ReciboCajaLogic
    {

        #region data Members

        ReciboCajaDao _dataObject = null;

        #endregion

        #region Constructor

        public ReciboCajaLogic()
        {
            _dataObject = new ReciboCajaDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new ReciboCaja
        /// </summary>
        /// <param name="businessObject">ReciboCaja object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref ReciboCajaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing ReciboCaja
        /// </summary>
        /// <param name="businessObject">ReciboCaja object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref ReciboCajaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get ReciboCaja by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public ReciboCajaBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all ReciboCajas
        /// </summary>
        /// <returns>list</returns>
        public List<ReciboCajaBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of ReciboCaja by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<ReciboCajaBdo> GetAllBy(ReciboCajaBdo.ReciboCajaFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
