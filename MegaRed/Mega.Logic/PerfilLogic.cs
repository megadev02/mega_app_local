using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class PerfilLogic
    {

        #region data Members

        PerfilDao _dataObject = null;

        #endregion

        #region Constructor

        public PerfilLogic()
        {
            _dataObject = new PerfilDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Perfil
        /// </summary>
        /// <param name="businessObject">Perfil object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref PerfilBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing Perfil
        /// </summary>
        /// <param name="businessObject">Perfil object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref PerfilBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get Perfil by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public PerfilBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all Perfils
        /// </summary>
        /// <returns>list</returns>
        public List<PerfilBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of Perfil by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<PerfilBdo> GetAllBy(PerfilBdo.PerfilFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
