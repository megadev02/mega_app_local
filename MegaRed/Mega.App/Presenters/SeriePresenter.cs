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
    public class SeriePresenter:GenericPresenter

    {
        #region atributos
        private SerieLogic _serieLogic = null;
        private SerieBdo _serieBdo = null;
        private ISerieView _serieView = null;
        private string _message;
        private FormSearchSerie _formSearchSerie = null;        

        #endregion

        public SeriePresenter(IGenericView genericView, INavigationMainMenu navigationMainMenu) : base(genericView, navigationMainMenu)
        {
            _serieLogic = new SerieLogic();
            _serieView = genericView as ISerieView;
            _formSearchSerie = new FormSearchSerie(_serieView);
        }   

        protected override void Add()
        {
            _serieBdo = new SerieBdo()
            {
                
                CodComprobante = _serieView.CodComprobante,
                NumeroSerie = _serieView.NumeroSerie,
                NumeroDigitos = _serieView.NumeroDigitos,
                CodigoOficina = _serieView.CodigoOficina,
                CierreSerie = _serieView.CierreSerie
                
            };

            _serieLogic.Insert(ref _serieBdo, ref _message);

            MessageBox.Show(_message);
        }

        protected override bool AllRightAdd()
        {
            if (_serieView.NumeroSerie <= 0)
            {
                MessageBox.Show("El campo 'Numero Serie'  no puede menor igual a cero");
                return false;
            }
           if (_serieView.NumeroDigitos <= 0)
            {
                MessageBox.Show("El campo 'Numero Digitos'  no puede menor igual a cero");
                return false;
            }
            
            return true;
        }

        protected override void Update()
        {
            //_SerieBdo.SerieId = _SerieView.SerieId;
            _serieBdo.CodComprobante = _serieView.CodComprobante;
            _serieBdo.NumeroSerie = _serieView.NumeroSerie;
            _serieBdo.NumeroDigitos = _serieView.NumeroDigitos;
            _serieBdo.CodigoOficina = _serieView.CodigoOficina;
            _serieBdo.CierreSerie = _serieView.CierreSerie;
                  
            _serieLogic.Update(ref _serieBdo, ref _message);

            MessageBox.Show(_message);
        }

        protected override bool AllRightUpdate()
        {
            return AllRightAdd();
        }

        protected override void Clear()
        {
           
            _serieView.NumeroSerie = 0;
            _serieView.NumeroDigitos = 0;
            _serieView.CierreSerie = Comun.Types.CierreSerie.Habilitado.ToBoolean();
        }

        protected override DialogResult Search()
        {
            if (_formSearchSerie.ShowDialog() == DialogResult.OK)
            {
                var serieId = _formSearchSerie.FieldIdValue ?? "";

                _serieBdo = _serieLogic.GetById(Convert.ToInt32(serieId.ToString()));
                _serieView.CodComprobante = _serieBdo.CodComprobante;
                _serieView.NumeroSerie = _serieBdo.NumeroSerie;
                _serieView.NumeroDigitos = _serieBdo.NumeroDigitos;
                _serieView.CodigoOficina = _serieBdo.CodigoOficina;
                _serieView.CierreSerie = _serieBdo.CierreSerie;


                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }
    }
}
