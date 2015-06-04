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
using Mega.App.Controls;
using Mega.App.Presenters;

namespace Mega.App.Views
{
    public partial class ConceptoView : FormBase,IConceptoView
    {
        private ConceptoPresenter _conceptoPresenter;
        public ConceptoView()
        {
            InitializeComponent();
        }
       
        public string Nombre
        {
            get { return tbNombre.Text; }
            set { tbNombre.Text = value; }
        }

        public string CodigoCuenta
        {
            get { return cbPlanContable.EditValue.ToString(); }
            set { cbPlanContable.EditValue = Convert.ToString(value); }
        }

        private void ConceptoView_Load(object sender, EventArgs e)
        {
            cbPlanContable.Bind();
            _conceptoPresenter = new ConceptoPresenter(this, NavigationMainMenu);
        }
       
    }
}
