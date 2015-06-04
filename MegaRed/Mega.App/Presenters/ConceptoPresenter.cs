using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bijcorp.Base;
using Mega.App.Search;
using Mega.App.Views;
using Mega.Bdo;
using Mega.Logic;
using Mega.App;
namespace Mega.App.Presenters
{
    public class ConceptoPresenter : GenericPresenter
    {
         #region atributos

        private ConceptoLogic _conceptoLogic = null;
        private ConceptoBdo _conceptoBdo = null;
        private IConceptoView _conceptoView = null;
        private string _message;
        private FormSearchConcepto _formSearchConcepto = null;        

        #endregion

        public ConceptoPresenter(IGenericView genericView, INavigationMainMenu navigationMainMenu) : base(genericView, navigationMainMenu)
        {
            _conceptoLogic = new ConceptoLogic();
            _conceptoView = genericView as IConceptoView;
            _formSearchConcepto = new FormSearchConcepto(_conceptoView);
            
        }   

        protected override void Add()
        {
            _conceptoBdo = new ConceptoBdo()
            {
                Nombre = _conceptoView.Nombre,
                CodigoCuenta = _conceptoView.CodigoCuenta,
             
            };

            _conceptoLogic.Insert(ref _conceptoBdo, ref _message);

            MessageBox.Show(_message);
        }

        protected override bool AllRightAdd()
        {
            if (_conceptoView.Nombre.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Nombre'  no puede ser vacio");
                return false;
            } else
            if (_conceptoView.CodigoCuenta.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Codigo Cuenta ' no puede ser vacio");
                return false;
            }
           
            return true;
        }

        protected override void Update()
        {
            _conceptoBdo.Nombre = _conceptoView.Nombre;
            _conceptoBdo.CodigoCuenta = _conceptoView.CodigoCuenta;
           
            _conceptoLogic.Update(ref _conceptoBdo, ref _message);

            MessageBox.Show(_message);
        }

        protected override bool AllRightUpdate()
        {
            return AllRightAdd();
        }

        protected override void Clear()
        {
            _conceptoView.Nombre = "";
            
        }

       


        protected override DialogResult Search()
        {
            if (_formSearchConcepto.ShowDialog() == DialogResult.OK)
            {                
                var conceptoId= _formSearchConcepto.FieldIdValue ?? "";
                
                _conceptoBdo = _conceptoLogic.GetById(Convert.ToInt32(conceptoId.ToString()));
              //  _conceptoView.ConceptoId = _conceptoBdo.ConceptoId;
                _conceptoView.Nombre = _conceptoBdo.Nombre;
                _conceptoView.CodigoCuenta = _conceptoBdo.CodigoCuenta;
               

                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }
    }
}
