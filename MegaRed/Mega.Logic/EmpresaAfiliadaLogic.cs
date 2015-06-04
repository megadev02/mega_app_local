using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class EmpresaAfiliadaLogic
    {

        #region data Members

        EmpresaAfiliadaDao _dataObject = null;

        #endregion

        #region Constructor

        public EmpresaAfiliadaLogic()
        {
            _dataObject = new EmpresaAfiliadaDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new EmpresaAfiliada
        /// </summary>
        /// <param name="businessObject">EmpresaAfiliada object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref EmpresaAfiliadaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing EmpresaAfiliada
        /// </summary>
        /// <param name="businessObject">EmpresaAfiliada object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref EmpresaAfiliadaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get EmpresaAfiliada by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public EmpresaAfiliadaBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all EmpresaAfiliadas
        /// </summary>
        /// <returns>list</returns>
        public List<EmpresaAfiliadaBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of EmpresaAfiliada by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<EmpresaAfiliadaBdo> GetAllBy(EmpresaAfiliadaBdo.EmpresaAfiliadaFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
