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
    public partial class FormSearchEntidadFinanciera : Bijcorp.Base.FormSearchTextBox
    {
        public FormSearchEntidadFinanciera()
        {
            InitializeComponent();
        }
         private IEntidadFinancieraView _entidadFinancieraView;

       

        public FormSearchEntidadFinanciera(IEntidadFinancieraView entidadFinancieraView)
        {
            InitializeComponent();
            _entidadFinancieraView = entidadFinancieraView;
            _KeyType = KeyType.Int;
        }

        protected override void InitializeAppeareance()
        {
            var gcol_EntidadFinancieraId = gvSearch.Columns.AddField(EntidadFinancieraBdo.EntidadFinancieraFields.EntidadId.ToString());
            gcol_EntidadFinancieraId.Caption = "EntidadId";
            gcol_EntidadFinancieraId.Visible = true;

            var gcol_CodEntidad = gvSearch.Columns.AddField(EntidadFinancieraBdo.EntidadFinancieraFields.CodEntidad.ToString());
            gcol_CodEntidad.Caption = "CodEntidad";
            gcol_CodEntidad.Visible = true;

            var gcol_EntidadFinaciera = gvSearch.Columns.AddField(EntidadFinancieraBdo.EntidadFinancieraFields.Nombre.ToString());
            gcol_EntidadFinaciera.Caption = "EntidadFinanciera";
            gcol_EntidadFinaciera.Visible = true;
            
            gvSearch.BestFitColumns();
        }

        protected override void InitializeSearchField()
        {
            cbSearchField.Properties.Items.Add(EntidadFinancieraBdo.EntidadFinancieraFields.EntidadId.ToString());
            cbSearchField.Properties.Items.Add(EntidadFinancieraBdo.EntidadFinancieraFields.CodEntidad.ToString());
            cbSearchField.Properties.Items.Add(EntidadFinancieraBdo.EntidadFinancieraFields.Nombre.ToString());

            cbSearchField.SelectedText = EntidadFinancieraBdo.EntidadFinancieraFields.Nombre.ToString();
        }

        protected override void InitializeData()
        {
            var dtSearch = from m in new EntidadFinancieraLogic().GetAll()
                where
                  
                    (_entidadFinancieraView.CodEntidad.Trim().Length == 0 ||
                     _entidadFinancieraView.CodEntidad.Contains(_entidadFinancieraView.CodEntidad))
                select m;

            InitializeData(EntidadFinancieraBdo.EntidadFinancieraFields.EntidadId.ToString(), EntidadFinancieraBdo.EntidadFinancieraFields.Nombre.ToString(), Utilities.ToDataTable(dtSearch.ToList()));
        }
    }
}
