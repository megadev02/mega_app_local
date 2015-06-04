using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class BancoLogic
    {

        #region data Members

        BancoDao _dataObject = null;

        #endregion

        #region Constructor

        public BancoLogic()
        {
            _dataObject = new BancoDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Banco
        /// </summary>
        /// <param name="businessObject">Banco object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref BancoBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing Banco
        /// </summary>
        /// <param name="businessObject">Banco object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref BancoBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get Banco by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public BancoBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all Bancos
        /// </summary>
        /// <returns>list</returns>
        public List<BancoBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of Banco by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<BancoBdo> GetAllBy(BancoBdo.BancoFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
