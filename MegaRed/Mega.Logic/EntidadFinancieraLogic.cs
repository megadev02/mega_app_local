using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class EntidadFinancieraLogic
    {

        #region data Members

        EntidadFinancieraDao _dataObject = null;

        #endregion

        #region Constructor

        public EntidadFinancieraLogic()
        {
            _dataObject = new EntidadFinancieraDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new EntidadFinanciera
        /// </summary>
        /// <param name="businessObject">EntidadFinanciera object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref EntidadFinancieraBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing EntidadFinanciera
        /// </summary>
        /// <param name="businessObject">EntidadFinanciera object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref EntidadFinancieraBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get EntidadFinanciera by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public EntidadFinancieraBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all EntidadFinancieras
        /// </summary>
        /// <returns>list</returns>
        public List<EntidadFinancieraBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of EntidadFinanciera by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<EntidadFinancieraBdo> GetAllBy(EntidadFinancieraBdo.EntidadFinancieraFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
