using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class AsientoLogic
    {

        #region data Members

        AsientoDao _dataObject = null;

        #endregion

        #region Constructor

        public AsientoLogic()
        {
            _dataObject = new AsientoDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Asiento
        /// </summary>
        /// <param name="businessObject">Asiento object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref AsientoBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing Asiento
        /// </summary>
        /// <param name="businessObject">Asiento object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref AsientoBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get Asiento by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public AsientoBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all Asientos
        /// </summary>
        /// <returns>list</returns>
        public List<AsientoBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of Asiento by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<AsientoBdo> GetAllBy(AsientoBdo.AsientoFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
