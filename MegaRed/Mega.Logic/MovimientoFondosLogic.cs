using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class MovimientoFondosLogic
    {

        #region data Members

        MovimientoFondosDao _dataObject = null;

        #endregion

        #region Constructor

        public MovimientoFondosLogic()
        {
            _dataObject = new MovimientoFondosDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new MovimientoFondos
        /// </summary>
        /// <param name="businessObject">MovimientoFondos object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref MovimientoFondosBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing MovimientoFondos
        /// </summary>
        /// <param name="businessObject">MovimientoFondos object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref MovimientoFondosBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get MovimientoFondos by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public MovimientoFondosBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all MovimientoFondoss
        /// </summary>
        /// <returns>list</returns>
        public List<MovimientoFondosBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of MovimientoFondos by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<MovimientoFondosBdo> GetAllBy(MovimientoFondosBdo.MovimientoFondosFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
