using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class OficinaLogic
    {

        #region data Members

        OficinaDao _dataObject = null;

        #endregion

        #region Constructor

        public OficinaLogic()
        {
            _dataObject = new OficinaDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Oficina
        /// </summary>
        /// <param name="businessObject">Oficina object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref OficinaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing Oficina
        /// </summary>
        /// <param name="businessObject">Oficina object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref OficinaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get Oficina by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public OficinaBdo GetById(string id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all Oficinas
        /// </summary>
        /// <returns>list</returns>
        public List<OficinaBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of Oficina by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<OficinaBdo> GetAllBy(OficinaBdo.OficinaFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
