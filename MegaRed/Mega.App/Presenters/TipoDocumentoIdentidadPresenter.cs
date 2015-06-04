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
    public class TipoDocumentoIdentidadPresenter:GenericPresenter
    {
        #region
        private TipoDocumentoIdentidadLogic _tipoDocumentoIdentidadLogic = null;
        private TipoDocumentoIdentidadBdo _tipoDocumentoIdentidadBdo = null;
        private ITipoDocumentoIdentidadView _tipoDocumentoIdentidadView = null;
        private string _message;
        private FormSearchTipoDocumentoIdentidad _formSearchTipoDocumentoIdentidad = null;        

        #endregion

        public TipoDocumentoIdentidadPresenter(IGenericView genericView, INavigationMainMenu navigationMainMenu) : base(genericView, navigationMainMenu)
        {
            _tipoDocumentoIdentidadLogic = new TipoDocumentoIdentidadLogic();
            _tipoDocumentoIdentidadView = genericView as ITipoDocumentoIdentidadView;
            _formSearchTipoDocumentoIdentidad = new FormSearchTipoDocumentoIdentidad(_tipoDocumentoIdentidadView);
        }   

        protected override void Add()
        {
            _tipoDocumentoIdentidadBdo = new TipoDocumentoIdentidadBdo()
            {
                Abreviatura=_tipoDocumentoIdentidadView.Abreviatura,
                Denominacion = _tipoDocumentoIdentidadView.Denominacion              
            };

            _tipoDocumentoIdentidadLogic.Insert(ref _tipoDocumentoIdentidadBdo, ref _message);
            MessageBox.Show(_message);
        }

        protected override bool AllRightAdd()
        {
            if (_tipoDocumentoIdentidadView.Abreviatura.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Abreviatura'  no puede ser vacio");
                return false;
            }  
            if (_tipoDocumentoIdentidadView.Denominacion.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Denominacion'  no puede ser vacio");
                return false;
            }
            
            return true;
        }

        protected override void Update()
        {
            //_TipoDocumentoIdentidadBdo.TipoDocumentoIdentidadId = _TipoDocumentoIdentidadView.TipoDocumentoIdentidadId;
            _tipoDocumentoIdentidadBdo.Abreviatura = _tipoDocumentoIdentidadView.Abreviatura;            
            _tipoDocumentoIdentidadBdo.Denominacion = _tipoDocumentoIdentidadView.Denominacion;
            MessageBox.Show(_message);
        }

        protected override bool AllRightUpdate()
        {
            return AllRightAdd();
        }

        protected override void Clear()
        {
            _tipoDocumentoIdentidadView.Abreviatura = ""; 
            _tipoDocumentoIdentidadView.Denominacion = "";           
        }
        
        protected override DialogResult Search()
        {
            if (_formSearchTipoDocumentoIdentidad.ShowDialog() == DialogResult.OK)
            {                
                var TipoDocumentoIdentidadId= _formSearchTipoDocumentoIdentidad.FieldIdValue ?? "";
                
                _tipoDocumentoIdentidadBdo = _tipoDocumentoIdentidadLogic.GetById(Convert.ToInt32(TipoDocumentoIdentidadId.ToString()));
                _tipoDocumentoIdentidadView.Abreviatura = _tipoDocumentoIdentidadBdo.Abreviatura;
                _tipoDocumentoIdentidadView.Denominacion = _tipoDocumentoIdentidadBdo.Denominacion;

                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }
    }
}
