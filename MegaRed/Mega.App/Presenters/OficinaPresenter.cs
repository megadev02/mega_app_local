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
    public class OficinaPresenter : GenericPresenter
    {
        #region atributos

        private OficinaLogic _oficinaLogic = null;
        private OficinaBdo _oficinaBdo = null;
        private IOficinaView _oficinaView = null;
        private string _message;
        private FormSearchOficina _formSearchOficina = null;        

        #endregion

        public OficinaPresenter(IGenericView genericView, INavigationMainMenu navigationMainMenu) : base(genericView, navigationMainMenu)
        {
            _oficinaLogic = new OficinaLogic();
            _oficinaView = genericView as IOficinaView;
            _formSearchOficina = new FormSearchOficina(_oficinaView);
        }   

        protected override void Add()
        {
            _oficinaBdo = new OficinaBdo()
            {
                CodigoOficina = _oficinaView.CodigoOficina,
                NombreOficina = _oficinaView.NombreOficina,
                Direccion = _oficinaView.Direccion,
                TipoOficina = _oficinaView.TipoOficina,
                CodigoUbigeo = /*_oficinaView.CodigoUbigeo*/"",
                Estado = _oficinaView.Estado,
                Telefono = _oficinaView.Telefono
            };

            if (_oficinaLogic.Insert(ref _oficinaBdo, ref _message))
            {
                var msgOficina = new CMsgOficina { CodOfDestino = "ALL", Oficina = _oficinaBdo };
                SocketConexion.Enviar(msgOficina);
            }

            MessageBox.Show(_message);
        }

        protected override bool AllRightAdd()
        {
            if (_oficinaView.CodigoOficina.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'código' de oficina no puede ser vacio");
                return false;
            }
            if (_oficinaView.NombreOficina.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'Nombre oficina' no puede ser vacio");
                return false;
            }
            if (_oficinaView.Direccion.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'dirección' no puede ser vacio");
                return false;
            }
            if (_oficinaView.Telefono.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'teléfono' no puede ser vacio");
                return false;
            }
            return true;
        }

        protected override void Update()
        {
            _oficinaBdo.CodigoOficina = _oficinaView.CodigoOficina;
            _oficinaBdo.NombreOficina = _oficinaView.NombreOficina;
            _oficinaBdo.Direccion = _oficinaView.Direccion;
            _oficinaBdo.Telefono = _oficinaView.Telefono;
            _oficinaBdo.Estado = _oficinaView.Estado;
            _oficinaBdo.TipoOficina = _oficinaView.TipoOficina;

            _oficinaLogic.Update(ref _oficinaBdo, ref _message);

            MessageBox.Show(_message);
        }

        protected override bool AllRightUpdate()
        {
            return AllRightAdd();
        }

        protected override void Clear()
        {
            _oficinaView.CodigoOficina = "";
            _oficinaView.NombreOficina = "";
            _oficinaView.Direccion = "";
            _oficinaView.TipoOficina = Comun.Types.TipoOficina.Propio.ToInt();
            _oficinaView.Telefono = "";
            _oficinaView.Estado = Comun.Types.EstadoOficina.Habilitado.ToBoolean();
        }

        protected override DialogResult Search()
        {
            if (_formSearchOficina.ShowDialog() == DialogResult.OK)
            {                
                var codigoOficina = _formSearchOficina.FieldIdValue ?? "";
                
                _oficinaBdo = _oficinaLogic.GetById(codigoOficina.ToString());
                _oficinaView.CodigoOficina = _oficinaBdo.CodigoOficina;
                _oficinaView.NombreOficina = _oficinaBdo.NombreOficina;
                _oficinaView.Direccion = _oficinaBdo.Direccion;
                _oficinaView.Telefono = _oficinaBdo.Telefono;
                _oficinaView.TipoOficina = _oficinaBdo.TipoOficina;
                _oficinaView.Estado = _oficinaBdo.Estado;

                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }
    }
}
