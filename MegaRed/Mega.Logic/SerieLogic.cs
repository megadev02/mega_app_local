using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class SerieLogic
    {

        #region data Members

        SerieDao _dataObject = null;

        #endregion

        #region Constructor

        public SerieLogic()
        {
            _dataObject = new SerieDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Serie
        /// </summary>
        /// <param name="businessObject">Serie object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref SerieBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing Serie
        /// </summary>
        /// <param name="businessObject">Serie object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref SerieBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get Serie by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public SerieBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all Series
        /// </summary>
        /// <returns>list</returns>
        public List<SerieBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of Serie by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<SerieBdo> GetAllBy(SerieBdo.SerieFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
