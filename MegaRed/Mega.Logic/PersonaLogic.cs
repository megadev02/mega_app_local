using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class PersonaLogic
    {

        #region data Members

        PersonaDao _dataObject = null;

        #endregion

        #region Constructor

        public PersonaLogic()
        {
            _dataObject = new PersonaDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Persona
        /// </summary>
        /// <param name="businessObject">Persona object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref PersonaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing Persona
        /// </summary>
        /// <param name="businessObject">Persona object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref PersonaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get Persona by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public PersonaBdo GetById(string id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all Personas
        /// </summary>
        /// <returns>list</returns>
        public List<PersonaBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of Persona by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<PersonaBdo> GetAllBy(PersonaBdo.PersonaFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
