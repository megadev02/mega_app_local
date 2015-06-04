using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class TipoComuneroLogic
    {

        #region data Members

        TipoComuneroDao _dataObject = null;

        #endregion

        #region Constructor

        public TipoComuneroLogic()
        {
            _dataObject = new TipoComuneroDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new TipoComunero
        /// </summary>
        /// <param name="businessObject">TipoComunero object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref TipoComuneroBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing TipoComunero
        /// </summary>
        /// <param name="businessObject">TipoComunero object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref TipoComuneroBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get TipoComunero by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public TipoComuneroBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all TipoComuneros
        /// </summary>
        /// <returns>list</returns>
        public List<TipoComuneroBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of TipoComunero by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<TipoComuneroBdo> GetAllBy(TipoComuneroBdo.TipoComuneroFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
