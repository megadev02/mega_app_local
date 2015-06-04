using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class UsuarioLogic
    {

        #region data Members

        UsuarioDao _dataObject = null;

        #endregion

        #region Constructor

        public UsuarioLogic()
        {
            _dataObject = new UsuarioDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Usuario
        /// </summary>
        /// <param name="businessObject">Usuario object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref UsuarioBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing Usuario
        /// </summary>
        /// <param name="businessObject">Usuario object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref UsuarioBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get Usuario by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public UsuarioBdo GetById(string id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all Usuarios
        /// </summary>
        /// <returns>list</returns>
        public List<UsuarioBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of Usuario by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<UsuarioBdo> GetAllBy(UsuarioBdo.UsuarioFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
