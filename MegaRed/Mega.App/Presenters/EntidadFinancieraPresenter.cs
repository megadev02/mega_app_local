using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bijcorp.Base;
using Mega.App.Search;
using Mega.App.Views.Interface;
using Mega.Bdo;
using Mega.Logic;

namespace Mega.App.Presenters
{
    public class EntidadFinancieraPresenter:GenericPresenter
    {
        #region
        private EntidadFinancieraLogic _entidadFinancieraLogic = null;
        private EntidadFinancieraBdo _entidadFinancieraBdo = null;
        private IEntidadFinancieraView _entidadFinancieraView = null;
        private string _message;
        private FormSearchEntidadFinanciera _formSearchEntidadFinanciera = null;        

        #endregion

        public EntidadFinancieraPresenter(IGenericView genericView, INavigationMainMenu navigationMainMenu) : base(genericView, navigationMainMenu)
        {
            _entidadFinancieraLogic = new EntidadFinancieraLogic();
            _entidadFinancieraView = genericView as IEntidadFinancieraView;
            _formSearchEntidadFinanciera = new FormSearchEntidadFinanciera(_entidadFinancieraView);
        }   

        protected override void Add()
        {
            _entidadFinancieraBdo = new EntidadFinancieraBdo()
            {
                CodEntidad= _entidadFinancieraView.CodEntidad,
                Nombre = _entidadFinancieraView.Nombre              
            };

            _entidadFinancieraLogic.Insert(ref _entidadFinancieraBdo, ref _message);
            MessageBox.Show(_message);
        }

        protected override bool AllRightAdd()
        {
            if (_entidadFinancieraView.CodEntidad.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'cod. entidad'  no puede ser vacio");
                return false;
            }  
            if (_entidadFinancieraView.Nombre.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'entidad financiera'  no puede ser vacio");
                return false;
            }
            
            return true;
        }

        protected override void Update()
        {
            //_EntidadFinancieraBdo.EntidadFinancieraId = _EntidadFinancieraView.EntidadFinancieraId;
            _entidadFinancieraBdo.CodEntidad = _entidadFinancieraView.CodEntidad;            
            _entidadFinancieraBdo.Nombre = _entidadFinancieraView.Nombre;
            MessageBox.Show(_message);
        }

        protected override bool AllRightUpdate()
        {
            return AllRightAdd();
        }

        protected override void Clear()
        {
            _entidadFinancieraView.CodEntidad = ""; 
            _entidadFinancieraView.Nombre = "";           
        }
        
        protected override DialogResult Search()
        {
            if (_formSearchEntidadFinanciera.ShowDialog() == DialogResult.OK)
            {                
                var EntidadFinancieraId= _formSearchEntidadFinanciera.FieldIdValue ?? "";
                
                _entidadFinancieraBdo = _entidadFinancieraLogic.GetById(Convert.ToInt32(EntidadFinancieraId.ToString()));
                _entidadFinancieraView.CodEntidad = _entidadFinancieraBdo.CodEntidad;
                _entidadFinancieraView.Nombre = _entidadFinancieraBdo.Nombre;

                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }
    }
}
