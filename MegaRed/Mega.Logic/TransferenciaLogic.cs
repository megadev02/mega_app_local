using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class TransferenciaLogic
    {

        #region data Members

        TransferenciaDao _dataObject = null;

        #endregion

        #region Constructor

        public TransferenciaLogic()
        {
            _dataObject = new TransferenciaDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Transferencia
        /// </summary>
        /// <param name="businessObject">Transferencia object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref TransferenciaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing Transferencia
        /// </summary>
        /// <param name="businessObject">Transferencia object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref TransferenciaBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get Transferencia by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public TransferenciaBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all Transferencias
        /// </summary>
        /// <returns>list</returns>
        public List<TransferenciaBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of Transferencia by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<TransferenciaBdo> GetAllBy(TransferenciaBdo.TransferenciaFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
