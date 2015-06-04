using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bijcorp.Base;
using Mega.App.Search;
using Mega.App.Views;
using Mega.App.Views.Interface;
using Mega.Bdo;
using Mega.Logic;
namespace Mega.App.Presenters
{
    public class MonedaPresenter:GenericPresenter
    {
         #region
        private MonedaLogic _monedaLogic = null;
        private MonedaBdo _monedaBdo = null;
        private IMonedaView _monedaView = null;
        private string _message;
        private FormSearchMoneda _formSearchMoneda = null;        

        #endregion

        public MonedaPresenter(IGenericView genericView, INavigationMainMenu navigationMainMenu) : base(genericView, navigationMainMenu)
        {
            _monedaLogic = new MonedaLogic();
            _monedaView = genericView as IMonedaView;
            _formSearchMoneda = new FormSearchMoneda(_monedaView);
        }   

        protected override void Add()
        {
            _monedaBdo = new MonedaBdo()
            {
                Nombre = _monedaView.Nombre,
                Simbolo = _monedaView.Simbolo,
                Abreviatura = _monedaView.Abreviatura,
                Referencia = _monedaView.Referencia,
                EsNacional = _monedaView.EsNacional,
                Estado = _monedaView.Estado
            };

            _monedaLogic.Insert(ref _monedaBdo, ref _message);

            MessageBox.Show(_message);
        }

        protected override bool AllRightAdd()
        {
            if (_monedaView.Nombre.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Nombre'  no puede ser vacio");
                return false;
            }
            if (_monedaView.Simbolo.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Símbolo ' no puede ser vacio");
                return false;
            }
            
            if (_monedaView.Referencia.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Referencia ' no puede ser vacio");
                return false;
            } 
            if (_monedaView.Abreviatura.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Abreviatura ' no puede ser vacio");
                return false;
            }
            
            return true;
        }

        protected override void Update()
        {
            //_monedaBdo.MonedaId = _monedaView.MonedaId;
            _monedaBdo.Nombre = _monedaView.Nombre;
            _monedaBdo.Simbolo = _monedaView.Simbolo;
            _monedaBdo.Abreviatura = _monedaView.Abreviatura;
            _monedaBdo.Referencia = _monedaView.Referencia;
            _monedaBdo.EsNacional = _monedaView.EsNacional;
            _monedaBdo.Estado = _monedaView.Estado;                                
            _monedaLogic.Update(ref _monedaBdo, ref _message);

            MessageBox.Show(_message);
        }

        protected override bool AllRightUpdate()
        {
            return AllRightAdd();
        }

        protected override void Clear()
        {
            _monedaView.Nombre = "";
            _monedaView.Simbolo = "";
            _monedaView.Abreviatura = "";
            _monedaView.Referencia = "";
            _monedaView.EsNacional =  Comun.Types.EsNacional.Si.ToBoolean();
            _monedaView.Estado = Comun.Types.EstadoMoneda.Habilitado.ToBoolean();
        }
        
        protected override DialogResult Search()
        {
            if (_formSearchMoneda.ShowDialog() == DialogResult.OK)
            {                
                var monedaId= _formSearchMoneda.FieldIdValue ?? "";
                
                _monedaBdo = _monedaLogic.GetById(Convert.ToInt32(monedaId.ToString()));
                _monedaView.Nombre = _monedaBdo.Nombre;
                _monedaView.Abreviatura = _monedaBdo.Abreviatura;
                _monedaView.Simbolo = _monedaBdo.Simbolo;
                _monedaView.Referencia= _monedaBdo.Referencia;              
                _monedaView.EsNacional = _monedaBdo.EsNacional;
                _monedaView.Estado = _monedaBdo.Estado;

                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }
    }
}
