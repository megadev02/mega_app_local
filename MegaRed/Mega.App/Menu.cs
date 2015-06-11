using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bijcorp.Base;
using DevExpress.XtraNavBar;
using DevExpress.XtraTreeList;
using Mega.App.Views;
using Mega.Bdo;
using Mega.Logic;

namespace Mega.App
{
    public partial class Menu : MenuBase
    {
        readonly UsuarioLogic _usuarioLogic = new UsuarioLogic();
        readonly PersonaLogic _personaLogic = new PersonaLogic();
        readonly TransferenciaLogic _transferenciaLogic = new TransferenciaLogic();
        readonly OficinaLogic _oficinaLogic = new OficinaLogic();
        private string _message = null;

        public Menu()
        {            
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Text = "Mega-" + CUtil.MiBase;

            var users = _usuarioLogic.GetAll().Select(usuario => new User()
            {
                Id = usuario.UsuarioId,
                Name=usuario.UsuarioId,
                Pwd = usuario.Contrasenia
            }).ToList();

            if (InitializeLogin(users))
            {
                InitializeModules();
                SocketConexion.Conectar();
            }

            SocketConexion.OnMsgPersona += SocketConexion_OnMsgPersona;
            SocketConexion.OnMsgTransferencia += SocketConexion_OnMsgTransferencia;
            SocketConexion.OnMsgOficina += SocketConexion_OnMsgOficina;
        }

        void SocketConexion_OnMsgOficina(CMsgOficina msg)
        {
            var oficina = msg.Oficina;
            if (!_oficinaLogic.Update(ref oficina, ref _message))
                _oficinaLogic.Insert(ref oficina, ref _message);
        }

        void SocketConexion_OnMsgTransferencia(CMsgTransferencia msg)
        {
            //- creando transferencia
            var transferencia = msg.Transferencia;
            var solicitante = msg.Solicitante;
            var beneficiario = msg.Beneficiario;

            if (!_personaLogic.Update(ref solicitante, ref _message))
                _personaLogic.Insert(ref solicitante, ref _message);

            if (!_personaLogic.Update(ref beneficiario, ref _message))
                _personaLogic.Insert(ref beneficiario, ref _message);

            //if (!_transferenciaLogic.Update(ref transferencia, ref _message))
            _transferenciaLogic.Insert(ref transferencia, ref _message);
        }

        void SocketConexion_OnMsgPersona(CMsgPersona msg)
        {
            var persona = msg.Persona;
            if (!_personaLogic.Update(ref persona, ref _message))
                _personaLogic.Insert(ref persona, ref _message);
        }

        #region Métodos con el menú

        public override void InitializeDicModules()
        {
            Modules.DicModules.Add(1, new Action(() => OpenMdi(new OficinaView())));
            Modules.DicModules.Add(2, new Action(() => OpenMdi(new ConceptoView())));
            Modules.DicModules.Add(3, new Action(() => OpenMdi(new MonedaView())));
            Modules.DicModules.Add(4, new Action(() => OpenMdi(new TipoDocumentoIdentidadView())));
            Modules.DicModules.Add(5, new Action(() => OpenMdi(new PersonaView())));
            Modules.DicModules.Add(6, new Action(() => OpenMdi(new DenominacionMonedaView())));
            Modules.DicModules.Add(7, new Action(() => OpenMdi(new EntidadFinancieraView())));
            Modules.DicModules.Add(8, new Action(() => OpenMdi(new BancoView())));
            Modules.DicModules.Add(9, new Action(() => OpenMdi(new ComprobanteView())));
            Modules.DicModules.Add(10, new Action(() => OpenMdi(new SerieView())));
            Modules.DicModules.Add(11, new Action(() => OpenMdi(new TransferenciaView())));
            Modules.DicModules.Add(12, new Action(() => OpenMdi(new MovimientoFondosView(MovimientoFondosView.TypeViewFondos.Ingreso))));
            Modules.DicModules.Add(13, new Action(() => OpenMdi(new MovimientoFondosView(MovimientoFondosView.TypeViewFondos.Egreso))));
        }

        public override void InitializeTreeMenu()
        {
            var linkMantenimiento = new LinkGroup() { Id = 1, Name = "Mantenimientos" };
            var linkProceso = new LinkGroup() { Id = 2, Name = "Proceso" };
            var linkReportes = new LinkGroup() { Id = 3, Name = "Reportes" };

            LinkGroups.Add(linkMantenimiento);
            LinkGroups.Add(linkProceso);
            LinkGroups.Add(linkReportes);

            LinkModules = new List<LinkModule>()
            {
                new LinkModule() {Id = 1, ParentId = 0, Name = "Mantenimiento para Oficinas", Group = linkMantenimiento },
                new LinkModule() {Id = 2, ParentId = 1, Name = "Oficina", View = Modules.DicModules[1], Group = linkMantenimiento },  
                new LinkModule() {Id = 3, ParentId = 1, Name = "Concepto", View = Modules.DicModules[2], Group = linkMantenimiento },       
                new LinkModule() {Id = 4, ParentId = 1, Name = "Moneda", View = Modules.DicModules[3], Group = linkMantenimiento }, 
                new LinkModule() {Id = 5, ParentId = 1, Name = "Tipo Documento Identidad", View = Modules.DicModules[4], Group = linkMantenimiento },
                new LinkModule() {Id = 6, ParentId = 1, Name = "Persona", View = Modules.DicModules[5], Group = linkMantenimiento },
                new LinkModule() {Id = 7, ParentId = 1, Name = "Denominacion Moneda", View = Modules.DicModules[6], Group = linkMantenimiento },
                new LinkModule() {Id = 8, ParentId = 1, Name = "Entidad Financiera", View = Modules.DicModules[7], Group = linkMantenimiento },
                new LinkModule() {Id = 9, ParentId = 1, Name = "Banco", View = Modules.DicModules[8], Group = linkMantenimiento },
                new LinkModule() {Id = 10, ParentId = 1, Name = "Comprobante", View = Modules.DicModules[9], Group = linkMantenimiento },
                new LinkModule() {Id = 11, ParentId = 1, Name = "Serie", View = Modules.DicModules[10], Group = linkMantenimiento },
                new LinkModule() {Id = 12, ParentId = 0, Name = "Procesos para Transferencias", Group = linkProceso },
                new LinkModule() {Id = 13, ParentId = 12, Name = "Transferencia", View = Modules.DicModules[11], Group = linkProceso},
                new LinkModule() {Id = 14, ParentId = 12, Name = "Ingreso de fondos", View = Modules.DicModules[12], Group = linkProceso},
                new LinkModule() {Id = 15, ParentId = 12, Name = "Egreso de fondos", View = Modules.DicModules[13], Group = linkProceso}
            };
        }

        #endregion

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            SocketConexion.Desconectar();
        }

    }
}
