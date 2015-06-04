using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class ContratoEmpresaAfiliadoLogic
    {

        #region data Members

        ContratoEmpresaAfiliadoDao _dataObject = null;

        #endregion

        #region Constructor

        public ContratoEmpresaAfiliadoLogic()
        {
            _dataObject = new ContratoEmpresaAfiliadoDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new ContratoEmpresaAfiliado
        /// </summary>
        /// <param name="businessObject">ContratoEmpresaAfiliado object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref ContratoEmpresaAfiliadoBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing ContratoEmpresaAfiliado
        /// </summary>
        /// <param name="businessObject">ContratoEmpresaAfiliado object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref ContratoEmpresaAfiliadoBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get ContratoEmpresaAfiliado by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public ContratoEmpresaAfiliadoBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all ContratoEmpresaAfiliados
        /// </summary>
        /// <returns>list</returns>
        public List<ContratoEmpresaAfiliadoBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of ContratoEmpresaAfiliado by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<ContratoEmpresaAfiliadoBdo> GetAllBy(ContratoEmpresaAfiliadoBdo.ContratoEmpresaAfiliadoFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
