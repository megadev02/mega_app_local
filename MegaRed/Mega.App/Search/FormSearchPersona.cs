using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bijcorp.Base;
using Mega.App.Views.Interface;
using Mega.Bdo;
using Mega.Logic;

namespace Mega.App.Search
{
    public partial class FormSearchPersona : Bijcorp.Base.FormSearchTextBox
    {
        public FormSearchPersona()
        {
            InitializeComponent();
        }
         private IPersonaView _personaView;

        
        public FormSearchPersona(IPersonaView personaView)
        {
            InitializeComponent();
            _personaView = personaView;
            _KeyType = KeyType.String;
        }

        protected override void InitializeAppeareance()
        {
            var gcol_CodigoPersona = gvSearch.Columns.AddField(PersonaBdo.PersonaFields.CodigoPersona.ToString());
            gcol_CodigoPersona.Caption = "CódigoPersona";
            gcol_CodigoPersona.Visible = true;

            var gcol_TipoPersona = gvSearch.Columns.AddField(PersonaBdo.PersonaFields.TipoPersona.ToString());
            gcol_TipoPersona.Caption = "TipoPersona";
            gcol_TipoPersona.Visible = true;

            var gcol_RazonSocial = gvSearch.Columns.AddField(PersonaBdo.PersonaFields.RazonSocial.ToString());
            gcol_RazonSocial.Caption = "RazonSocial";
            gcol_RazonSocial.Visible = true;

            var gcol_PrimerNombre = gvSearch.Columns.AddField(PersonaBdo.PersonaFields.PrimerNombre.ToString());
            gcol_PrimerNombre.Caption = "Nombre";
            gcol_PrimerNombre.Visible = true;

            var gcol_ApellidoPaterno = gvSearch.Columns.AddField(PersonaBdo.PersonaFields.ApellidoPaterno.ToString());
            gcol_ApellidoPaterno.Caption = "ApellidoPaterno";
            gcol_ApellidoPaterno.Visible = true;

            var gcol_ApellidoMaterno = gvSearch.Columns.AddField(PersonaBdo.PersonaFields.ApellidoMaterno.ToString());
            gcol_ApellidoMaterno.Caption = "ApellidoMaterno";
            gcol_ApellidoMaterno.Visible = true;
        
            var gcol_NumeroDocumento = gvSearch.Columns.AddField(PersonaBdo.PersonaFields.NumeroDocumento.ToString());
            gcol_NumeroDocumento.Caption = "NumeroDocumento";
            gcol_NumeroDocumento.Visible = true;

            gvSearch.BestFitColumns();
        }

        protected override void InitializeSearchField()
        {
            cbSearchField.Properties.Items.Add(PersonaBdo.PersonaFields.CodigoPersona.ToString());
            cbSearchField.Properties.Items.Add(PersonaBdo.PersonaFields.TipoPersona.ToString());
            cbSearchField.Properties.Items.Add(PersonaBdo.PersonaFields.RazonSocial.ToString());
            cbSearchField.Properties.Items.Add(PersonaBdo.PersonaFields.PrimerNombre.ToString());
            cbSearchField.Properties.Items.Add(PersonaBdo.PersonaFields.ApellidoPaterno.ToString());
            cbSearchField.Properties.Items.Add(PersonaBdo.PersonaFields.ApellidoMaterno.ToString());
            cbSearchField.Properties.Items.Add(PersonaBdo.PersonaFields.NumeroDocumento.ToString());

            cbSearchField.SelectedText = PersonaBdo.PersonaFields.PrimerNombre.ToString();
        }

        protected override void InitializeData()
        {
            var dtSearch = from m in new PersonaLogic().GetAll()
                where
                    (_personaView.CodigoPersona.Trim().Length == 0 ||
                     _personaView.CodigoPersona.Contains(_personaView.CodigoPersona))
                    &&
                    (_personaView.PrimerNombre.Trim().Length == 0 ||
                     _personaView.PrimerNombre.Contains(_personaView.PrimerNombre))
                select m;

            InitializeData(PersonaBdo.PersonaFields.CodigoPersona.ToString(), PersonaBdo.PersonaFields.PrimerNombre.ToString(), Utilities.ToDataTable(dtSearch.ToList()));
        }
    }
}
