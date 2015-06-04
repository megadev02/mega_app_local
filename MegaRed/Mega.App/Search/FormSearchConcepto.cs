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
using DevExpress.XtraGrid.Columns;
using Mega.App.Views;
using Mega.Bdo;
using Mega.Logic;
namespace Mega.App.Search
{
    public partial class FormSearchConcepto : FormSearchTextBox
    {
       
        private IConceptoView _conceptoView;

        public FormSearchConcepto()
        {
            InitializeComponent();
        }

        public FormSearchConcepto(IConceptoView conceptoView)
        {
            InitializeComponent();
            _conceptoView = conceptoView;
            _KeyType = KeyType.String;
        }

        protected override void InitializeAppeareance()
        {
            var gcol_ConceptoId = gvSearch.Columns.AddField(ConceptoBdo.ConceptoFields.ConceptoId.ToString());
            gcol_ConceptoId.Caption = "ConceptoId";
            gcol_ConceptoId.Visible = true;

            var gcol_Nombre = gvSearch.Columns.AddField(ConceptoBdo.ConceptoFields.Nombre.ToString());
            gcol_Nombre.Caption = "Nombre";
            gcol_Nombre.Visible = true;

            var gcol_CodigoCuenta = gvSearch.Columns.AddField(ConceptoBdo.ConceptoFields.CodigoCuenta.ToString());
            gcol_CodigoCuenta.Caption = "CodigoCuenta";
            gcol_CodigoCuenta.Visible = true;
            
            gvSearch.BestFitColumns();
        }

        protected override void InitializeSearchField()
        {
            cbSearchField.Properties.Items.Add(ConceptoBdo.ConceptoFields.ConceptoId.ToString());
            cbSearchField.Properties.Items.Add(ConceptoBdo.ConceptoFields.Nombre.ToString());
            cbSearchField.Properties.Items.Add(ConceptoBdo.ConceptoFields.CodigoCuenta.ToString());

            cbSearchField.SelectedText = ConceptoBdo.ConceptoFields.Nombre.ToString();
        }

        protected override void InitializeData()
        {
            var dtSearch = from m in new ConceptoLogic().GetAll()
                where
                    /*_conceptoView.ConceptoId.Length == 0 ||
                     _conceptoView.ConceptoId.Contains(_conceptoView.ConceptoId))
                    &&*/
                    (_conceptoView.Nombre.Trim().Length == 0 ||
                     _conceptoView.Nombre.Contains(_conceptoView.Nombre))
                select m;

            InitializeData(ConceptoBdo.ConceptoFields.ConceptoId.ToString(), ConceptoBdo.ConceptoFields.Nombre.ToString(), Utilities.ToDataTable(dtSearch.ToList()));
        }
    }
}
