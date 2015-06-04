using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class PlanContableLogic
    {

        #region data Members

        PlanContableDao _dataObject = null;

        #endregion

        #region Constructor

        public PlanContableLogic()
        {
            _dataObject = new PlanContableDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new PlanContable
        /// </summary>
        /// <param name="businessObject">PlanContable object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref PlanContableBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing PlanContable
        /// </summary>
        /// <param name="businessObject">PlanContable object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref PlanContableBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get PlanContable by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public PlanContableBdo GetById(string id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all PlanContables
        /// </summary>
        /// <returns>list</returns>
        public List<PlanContableBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of PlanContable by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<PlanContableBdo> GetAllBy(PlanContableBdo.PlanContableFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
