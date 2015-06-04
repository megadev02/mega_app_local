using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class ConceptoLogic
    {

        #region data Members

        ConceptoDao _dataObject = null;

        #endregion

        #region Constructor

        public ConceptoLogic()
        {
            _dataObject = new ConceptoDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Concepto
        /// </summary>
        /// <param name="businessObject">Concepto object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref ConceptoBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing Concepto
        /// </summary>
        /// <param name="businessObject">Concepto object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref ConceptoBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get Concepto by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public ConceptoBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all Conceptos
        /// </summary>
        /// <returns>list</returns>
        public List<ConceptoBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of Concepto by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<ConceptoBdo> GetAllBy(ConceptoBdo.ConceptoFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
