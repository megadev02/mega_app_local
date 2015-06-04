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
   public  class PersonaPresenter:GenericPresenter
    {
       #region atributos

        private PersonaLogic _personaLogic = null;
        private PersonaBdo _personaBdo = null;
        private IPersonaView _personaView = null;
        private string _message;
        private FormSearchPersona _formSearchPersona = null;        

        #endregion

        public PersonaPresenter(IGenericView genericView, INavigationMainMenu navigationMainMenu) : base(genericView, navigationMainMenu)
        {
            _personaLogic = new PersonaLogic();
            _personaView = genericView as IPersonaView;
            _formSearchPersona = new FormSearchPersona(_personaView);
        }   

        protected override void Add()
        {
            _personaBdo = new PersonaBdo()
            {
                CodigoPersona = _personaView.CodigoPersona,
                TipoPersona = _personaView.TipoPersona,
                RazonSocial = _personaView.RazonSocial,
                TipoDocumentoId = _personaView.TipoDocumentoId,
                NumeroDocumento = _personaView.NumeroDocumento,
                PrimerNombre = _personaView.PrimerNombre,
                SegundoNombre = _personaView.SegundoNombre,
                ApellidoPaterno = _personaView.ApellidoPaterno,
                ApellidoMaterno = _personaView.ApellidoMaterno,
                CodigoUbigeo = "",
                DireccionDomicilio = _personaView.DireccionDomicilio,
                Telefono = _personaView.Telefono,
                Celular = _personaView.Celular,
                Email = _personaView.Email,              
                Web = _personaView.Web,           
                Estado = _personaView.Estado             
            };

            _personaLogic.Insert(ref _personaBdo, ref _message);

            MessageBox.Show(_message);
        }

        protected override bool AllRightAdd()
        {
            if (_personaView.CodigoPersona.Trim().Length == 0)
            {
                MessageBox.Show("El campo 'código' de Persona no puede ser vacio");
                return false;
            }           
            return true;
        }

        protected override void Update()
        {
            _personaBdo.CodigoPersona = _personaView.CodigoPersona;
            _personaBdo.TipoPersona = _personaView.TipoPersona;
            _personaBdo.RazonSocial = _personaView.RazonSocial;
            _personaBdo.TipoDocumentoId = _personaView.TipoDocumentoId;
            _personaBdo.PrimerNombre = _personaView.PrimerNombre;
            _personaBdo.SegundoNombre = _personaView.SegundoNombre;
            _personaBdo.ApellidoPaterno = _personaView.ApellidoPaterno;
            _personaBdo.ApellidoMaterno = _personaView.ApellidoMaterno;
            _personaBdo.CodigoUbigeo = _personaView.CodigoUbigeo;
            _personaBdo.DireccionDomicilio = _personaView.DireccionDomicilio;
            _personaBdo.Telefono = _personaView.Telefono;
            _personaBdo.Celular = _personaView.Celular;
            _personaBdo.Email = _personaView.Email;
            _personaBdo.Web = _personaView.Web;
            _personaBdo.Estado = _personaView.Estado;
           
            _personaLogic.Update(ref _personaBdo, ref _message);

            MessageBox.Show(_message);
        }

        protected override bool AllRightUpdate()
        {
            return AllRightAdd();
        }

        protected override void Clear()
        {
            _personaView.CodigoPersona = "";
            _personaView.TipoPersona = Comun.Types.TipoPersona.Natural.ToInt(); ; 
            _personaView.RazonSocial = "";
            //_personaView.TipoDocumentoId = ;
            _personaView.NumeroDocumento = "";
            _personaView.PrimerNombre = "";
            _personaView.SegundoNombre = "";
            _personaView.ApellidoPaterno = "";
            _personaView.ApellidoMaterno = "";
            _personaView.CodigoUbigeo = "";
            _personaView.DireccionDomicilio = "";
            _personaView.Telefono = "";
            _personaView.Celular = "";
            _personaView.Email = "";
            _personaView.Web = "";
            _personaView.Estado = Comun.Types.EstadoPersona.Habilitado.ToBoolean();
        }

        protected override DialogResult Search()
        {
            if (_formSearchPersona.ShowDialog() == DialogResult.OK)
            {                
                var codigoPersona = _formSearchPersona.FieldIdValue ?? "";
                
                _personaBdo = _personaLogic.GetById(codigoPersona.ToString());
                _personaView.CodigoPersona = _personaBdo.CodigoPersona;
                _personaView.TipoPersona = _personaBdo.TipoPersona;
                _personaView.RazonSocial = _personaBdo.RazonSocial;
                _personaView.TipoDocumentoId = _personaBdo.TipoDocumentoId;
                _personaView.NumeroDocumento = _personaBdo.NumeroDocumento;
                _personaView.PrimerNombre = _personaBdo.PrimerNombre;
                _personaView.SegundoNombre = _personaBdo.SegundoNombre;
                _personaView.ApellidoPaterno = _personaBdo.ApellidoPaterno;
                _personaView.ApellidoMaterno = _personaBdo.ApellidoMaterno;
                _personaView.CodigoUbigeo = _personaBdo.CodigoUbigeo;
                _personaView.DireccionDomicilio = _personaBdo.DireccionDomicilio;
                _personaView.Telefono = _personaBdo.Telefono;
                _personaView.Celular = _personaBdo.Celular;
                _personaView.Email = _personaBdo.Email;
                _personaView.Web = _personaBdo.Web;
                _personaView.Estado = _personaBdo.Estado;


                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }
    }
}
