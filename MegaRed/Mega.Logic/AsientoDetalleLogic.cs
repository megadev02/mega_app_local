using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class AsientoDetalleLogic
    {

        #region data Members

        AsientoDetalleDao _dataObject = null;

        #endregion

        #region Constructor

        public AsientoDetalleLogic()
        {
            _dataObject = new AsientoDetalleDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new AsientoDetalle
        /// </summary>
        /// <param name="businessObject">AsientoDetalle object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref AsientoDetalleBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing AsientoDetalle
        /// </summary>
        /// <param name="businessObject">AsientoDetalle object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref AsientoDetalleBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get AsientoDetalle by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public AsientoDetalleBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all AsientoDetalles
        /// </summary>
        /// <returns>list</returns>
        public List<AsientoDetalleBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of AsientoDetalle by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<AsientoDetalleBdo> GetAllBy(AsientoDetalleBdo.AsientoDetalleFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
