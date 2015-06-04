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
    class ComprobantePresenter:GenericPresenter
    {
          #region
        private ComprobanteLogic _comprobanteLogic = null;
        private ComprobanteBdo _comprobanteBdo = null;
        private IComprobanteView _comprobanteView = null;
        private string _message;
        private FormSearchComprobante _formSearchComprobante = null;        

        #endregion

        public ComprobantePresenter(IGenericView genericView, INavigationMainMenu navigationMainMenu) : base(genericView, navigationMainMenu)
        {
            _comprobanteLogic = new ComprobanteLogic();
            _comprobanteView = genericView as IComprobanteView;
            _formSearchComprobante = new FormSearchComprobante(_comprobanteView);
        }   

        protected override void Add()
        {
            _comprobanteBdo = new ComprobanteBdo()
            {
                CodComprobante =  _comprobanteView.CodComprobante,
                NombreComprobante = _comprobanteView.NombreComprobante,
                CreditoFiscal = _comprobanteView.CreditoFiscal,
               
            };

            _comprobanteLogic.Insert(ref _comprobanteBdo, ref _message);

            MessageBox.Show(_message);
        }

        protected override bool AllRightAdd()
        {
            if (_comprobanteView.CodComprobante.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Codigo Comprobante'  no puede ser vacio");
                return false;
            }

            if (_comprobanteView.NombreComprobante.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'nombre comprobante'  no puede ser vacio");
                return false;
            }
            return true;
        }

        protected override void Update()
        {
            //_ComprobanteBdo.ComprobanteId = _ComprobanteView.ComprobanteId;
            _comprobanteBdo.CodComprobante = _comprobanteView.CodComprobante;
            _comprobanteBdo.NombreComprobante = _comprobanteView.NombreComprobante;
            _comprobanteBdo.CreditoFiscal = _comprobanteView.CreditoFiscal;
           

            MessageBox.Show(_message);
        }

        protected override bool AllRightUpdate()
        {
            return AllRightAdd();
        }

        protected override void Clear()
        {
            _comprobanteView.CodComprobante ="";
            _comprobanteView.NombreComprobante = "";                              
            _comprobanteView.CreditoFiscal = Comun.Types.CreditoFiscal.Si.ToBoolean();
        }
        
        protected override DialogResult Search()
        {
            if (_formSearchComprobante.ShowDialog() == DialogResult.OK)
            {                
                var CodComprobante= _formSearchComprobante.FieldIdValue ?? "";
                
                _comprobanteBdo = _comprobanteLogic.GetById(CodComprobante.ToString());
                _comprobanteView.CodComprobante = _comprobanteBdo.CodComprobante;
                _comprobanteView.NombreComprobante = _comprobanteBdo.NombreComprobante;
                _comprobanteView.CreditoFiscal = _comprobanteBdo.CreditoFiscal;
               
                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }
    }
}
