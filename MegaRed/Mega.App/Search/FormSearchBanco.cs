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
    public partial class FormSearchBanco : Bijcorp.Base.FormSearchTextBox
    {
        public FormSearchBanco()
        {
            InitializeComponent();
        }
         private IBancoView _bancoView;

        public FormSearchBanco(IBancoView bancoView)
        {
            InitializeComponent();
            _bancoView = bancoView;
            _KeyType = KeyType.Int;
        }

        protected override void InitializeAppeareance()
        {
            var gcol_BancoId = gvSearch.Columns.AddField(BancoBdo.BancoFields.BancoId.ToString());
            gcol_BancoId.Caption = "BancoId";
            gcol_BancoId.Visible = true;

            var gcol_EntidadId = gvSearch.Columns.AddField(BancoBdo.BancoFields.EntidadId.ToString());
            gcol_EntidadId.Caption = "EntidadId";
            gcol_EntidadId.Visible = true;

            var gcol_Direccion = gvSearch.Columns.AddField(BancoBdo.BancoFields.Direccion.ToString());
            gcol_Direccion.Caption = "Direccion";
            gcol_Direccion.Visible = true;

            var gcol_CodigoUbigeo = gvSearch.Columns.AddField(BancoBdo.BancoFields.CodigoUbigeo.ToString());
            gcol_CodigoUbigeo.Caption = "CodigoUbigeo";
            gcol_CodigoUbigeo.Visible = true;

          
            gvSearch.BestFitColumns();
        }

        protected override void InitializeSearchField()
        {
            cbSearchField.Properties.Items.Add(BancoBdo.BancoFields.BancoId.ToString());
            cbSearchField.Properties.Items.Add(BancoBdo.BancoFields.EntidadId.ToString());
            cbSearchField.Properties.Items.Add(BancoBdo.BancoFields.Direccion.ToString());
            cbSearchField.Properties.Items.Add(BancoBdo.BancoFields.CodigoUbigeo.ToString());
          
            cbSearchField.Properties.Items.Add(BancoBdo.BancoFields.Estado.ToString());

            cbSearchField.SelectedText = BancoBdo.BancoFields.EntidadId.ToString();
        }

        protected override void InitializeData()
        {
            var dtSearch = from m in new BancoLogic().GetAll()
                where
                    (_bancoView.Direccion.Trim().Length == 0 ||
                     _bancoView.Direccion.Contains(_bancoView.Direccion))
                select m;

            InitializeData(BancoBdo.BancoFields.BancoId.ToString(), BancoBdo.BancoFields.EntidadId.ToString(), Utilities.ToDataTable(dtSearch.ToList()));
        }
    }
}
