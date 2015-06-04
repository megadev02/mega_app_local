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
    public class DenominacionMonedaPresenter:GenericPresenter
    {
          #region
        private DenominacionMonedaLogic _denominacionMonedaLogic = null;
        private DenominacionMonedaBdo _denominacionMonedaBdo = null;
        private IDenominacionMonedaView _denominacionMonedaView = null;
        private string _message;
        private FormSearchDenominacionMoneda _formSearchDenominacionMoneda = null;        

        #endregion

        public DenominacionMonedaPresenter(IGenericView genericView, INavigationMainMenu navigationMainMenu) : base(genericView, navigationMainMenu)
        {
            _denominacionMonedaLogic = new DenominacionMonedaLogic();
            _denominacionMonedaView = genericView as IDenominacionMonedaView;
            _formSearchDenominacionMoneda = new FormSearchDenominacionMoneda(_denominacionMonedaView);
        }   

        protected override void Add()
        {
            _denominacionMonedaBdo = new DenominacionMonedaBdo()
            {
                Denominacion = _denominacionMonedaView.Denominacion,
                Valor = _denominacionMonedaView.Valor,
                MonedaId = _denominacionMonedaView.MonedaId,
              
            };

            _denominacionMonedaLogic.Insert(ref _denominacionMonedaBdo, ref _message);

            MessageBox.Show(_message);
        }

        protected override bool AllRightAdd()
        {
            if (_denominacionMonedaView.Denominacion.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Denominacion'  no puede ser vacio");
                return false;
            }
            if (_denominacionMonedaView.Valor == 0)
            {
                MessageBox.Show("El campo 'Valor ' no puede ser cero o menor");
                return false;
            }                                   
            return true;
        }

        protected override void Update()
        {
            //_DenominacionMonedaBdo.DenominacionMonedaId = _DenominacionMonedaView.DenominacionMonedaId;
            _denominacionMonedaBdo.Denominacion = _denominacionMonedaView.Denominacion;
            _denominacionMonedaBdo.Valor = _denominacionMonedaView.Valor;
            _denominacionMonedaBdo.MonedaId = _denominacionMonedaView.MonedaId;
            _denominacionMonedaLogic.Update(ref _denominacionMonedaBdo, ref _message);

            MessageBox.Show(_message);
        }

        protected override bool AllRightUpdate()
        {
            return AllRightAdd();
        }

        protected override void Clear()
        {
            _denominacionMonedaView.Denominacion = "";
            _denominacionMonedaView.Valor = 0;
            _denominacionMonedaView.MonedaId = 1;
            }
        
        protected override DialogResult Search()
        {
            if (_formSearchDenominacionMoneda.ShowDialog() == DialogResult.OK)
            {                
                var DenominacionMonedaId= _formSearchDenominacionMoneda.FieldIdValue ?? "";
                
                _denominacionMonedaBdo = _denominacionMonedaLogic.GetById(Convert.ToInt32(DenominacionMonedaId.ToString()));
                _denominacionMonedaView.Denominacion = _denominacionMonedaBdo.Denominacion;
                _denominacionMonedaView.Valor = _denominacionMonedaBdo.Valor;
                _denominacionMonedaView.MonedaId = _denominacionMonedaBdo.MonedaId;
        
                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }
    }
}
