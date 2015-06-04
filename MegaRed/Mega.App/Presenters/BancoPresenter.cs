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
    public class BancoPresenter:GenericPresenter
    {
          #region
        private BancoLogic _bancoLogic = null;
        private BancoBdo _bancoBdo = null;
        private IBancoView _bancoView = null;
        private string _message;
        private FormSearchBanco _formSearchBanco = null;        

        #endregion

        public BancoPresenter(IGenericView genericView, INavigationMainMenu navigationMainMenu) : base(genericView, navigationMainMenu)
        {
            _bancoLogic = new BancoLogic();
            _bancoView = genericView as IBancoView;
            _formSearchBanco = new FormSearchBanco(_bancoView);
        }   

        protected override void Add()
        {
            _bancoBdo = new BancoBdo()
            {
                EntidadId =  _bancoView.EntidadId,
                Direccion = _bancoView.Direccion,
                CodigoUbigeo = _bancoView.CodigoUbigeo,
                Telefono1 = _bancoView.Telefono1,
                Telefono2 = _bancoView.Telefono2,
                Telefono3 = _bancoView.Telefono3,
                Estado =  _bancoView.Estado
            };

            _bancoLogic.Insert(ref _bancoBdo, ref _message);

            MessageBox.Show(_message);
        }

        protected override bool AllRightAdd()
        {
            if (_bancoView.Direccion.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Dirección'  no puede ser vacio");
                return false;
            }
           
            
            return true;
        }

        protected override void Update()
        {
            //_BancoBdo.BancoId = _BancoView.BancoId;
            _bancoBdo.EntidadId = _bancoView.EntidadId;
            _bancoBdo.Direccion = _bancoView.Direccion;
            _bancoBdo.CodigoUbigeo = _bancoView.CodigoUbigeo;
            _bancoBdo.Telefono1 = _bancoView.Telefono1;
            _bancoBdo.Telefono2 = _bancoView.Telefono2;
            _bancoBdo.Telefono3 = _bancoView.Telefono3;
            _bancoBdo.Estado = _bancoView.Estado;                  
            _bancoLogic.Update(ref _bancoBdo, ref _message);

            MessageBox.Show(_message);
        }

        protected override bool AllRightUpdate()
        {
            return AllRightAdd();
        }

        protected override void Clear()
        {
            _bancoView.EntidadId = 1;
            _bancoView.Direccion = "";
            _bancoView.CodigoUbigeo = "";
            _bancoView.Telefono1 = "";
            _bancoView.Telefono2= "";
            _bancoView.Telefono3 = "";
          
            _bancoView.Estado = Comun.Types.EstadoBanco.Habilitado.ToBoolean();
        }
        
        protected override DialogResult Search()
        {
            if (_formSearchBanco.ShowDialog() == DialogResult.OK)
            {                
                var bancoId= _formSearchBanco.FieldIdValue ?? "";
                
                _bancoBdo = _bancoLogic.GetById(Convert.ToInt32(bancoId.ToString()));
                _bancoView.EntidadId = _bancoBdo.EntidadId;
                _bancoView.Direccion = _bancoBdo.Direccion;
                _bancoView.CodigoUbigeo = _bancoBdo.CodigoUbigeo;
                _bancoView.Telefono1= _bancoBdo.Telefono1;
                _bancoView.Telefono2 = _bancoBdo.Telefono2;
                _bancoView.Telefono3 = _bancoBdo.Telefono3;                   
                _bancoView.Estado = _bancoBdo.Estado;

                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }
    }
}
