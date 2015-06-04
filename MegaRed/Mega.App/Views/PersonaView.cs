using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bijcorp.Base;
using Mega.App.Presenters;
using Mega.App.Views.Interface;

namespace Mega.App.Views
{
    public partial class PersonaView : FormBase,IPersonaView
    {
       
        private PersonaPresenter _personaPresenter;
        public PersonaView()
        {
             InitializeComponent();
        }
        public string CodigoPersona
        {
            get { return tbCodigoPersona.Text; }
            set { tbCodigoPersona.Text = value; }
        }
        public int  TipoPersona
        {
            get { return Convert.ToInt32(cbTipoPersona.EditValue); }
            set { cbTipoPersona.EditValue = Convert.ToInt32(value); }
        }
        public string RazonSocial
        {
            get { return tbRazonSocial.Text; }
            set { tbRazonSocial.Text = value; }
        }

        public int TipoDocumentoId
        {
            get { return Convert.ToInt32(cbTipoDocumentoIdPersona.EditValue); }
            set { cbTipoDocumentoIdPersona.EditValue = Convert.ToInt32(value); }

        }


        public string NumeroDocumento
        {
            get { return tbNumeroDocumento.Text; }
            set { tbNumeroDocumento.Text = value; }
        }
        public string PrimerNombre
        {
            get { return tbPrimerNombre.Text; }
            set { tbPrimerNombre.Text = value; }
        }
        public string SegundoNombre
        {
            get { return tbSegundoNombres.Text; }
            set { tbSegundoNombres.Text = value; }
        }
        public string ApellidoPaterno
        {
            get { return tbApellidoPaterno.Text; }
            set { tbApellidoPaterno.Text = value; }
        }
        public string ApellidoMaterno
        {
            get { return tbApellidoMaterno.Text; }
            set { tbApellidoMaterno.Text = value; }
        }
        public string CodigoUbigeo
        {
            get; set;
        }
        public string DireccionDomicilio
        {
            get { return tbDireccion.Text; }
            set { tbDireccion.Text = value; }
        }
        public string Telefono
        {
            get { return tbTelefono.Text; }
            set { tbTelefono.Text = value; }
        }
        public string Celular
        {
            get { return tbCelular.Text; }
            set { tbCelular.Text = value; }
        }
        public string Email
        {
            get { return tbEmail.Text; }
            set { tbEmail.Text = value; }
        }
        public string Web
        {
            get { return tbWeb.Text; }
            set { tbWeb.Text = value; }
        }
        public bool? Estado
        {
            get { return Convert.ToBoolean(cbEstado.EditValue); }
            set { cbEstado.SelectedIndex = value == true ? 1 : 0; }
        }

        

        private void FormPersonaView_Load(object sender, EventArgs e)
        {
            //enlazando presenter con view
            cbTipoDocumentoIdPersona.Bind();
           
            _personaPresenter = new PersonaPresenter(this, NavigationMainMenu);
        }        
        private void cbTipoPersona_Leave(object sender, EventArgs e)
        {
            if (cbTipoPersona.SelectedIndex == 1)
            {
                tcPersona.SelectedTabPage = xtraTabPage1;
            }
            else
                tcPersona.SelectedTabPage = xtraTabPage2;
        }
       
    }
}
