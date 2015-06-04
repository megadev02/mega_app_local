using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class ArqueoCajaLogic
    {

        #region data Members

        ArqueoCajaDao _dataObject = null;

        #endregion

        #region Constructor

        public ArqueoCajaLogic()
        {
            _dataObject = new ArqueoCajaDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new ArqueoCaja
        /// </summary>
        /// <param name="businessObject">ArqueoCaja object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref ArqueoCajaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing ArqueoCaja
        /// </summary>
        /// <param name="businessObject">ArqueoCaja object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref ArqueoCajaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get ArqueoCaja by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public ArqueoCajaBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all ArqueoCajas
        /// </summary>
        /// <returns>list</returns>
        public List<ArqueoCajaBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of ArqueoCaja by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<ArqueoCajaBdo> GetAllBy(ArqueoCajaBdo.ArqueoCajaFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
