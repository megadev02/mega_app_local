using System;
using Mega.App.Presenters;
using Mega.App.Views.Interface;

namespace Mega.App.Views
{
    public partial class EntidadFinancieraView : Bijcorp.Base.FormBase,IEntidadFinancieraView
    {
        public EntidadFinancieraView()
        {
            InitializeComponent();
        }

        public string CodEntidad
        {
            get { return tbCodEntidad.Text; }
            set { tbCodEntidad.Text = value; }
        }       

        public string Nombre
        {
            get { return tbEntidadFinanciera.Text; }
            set { tbEntidadFinanciera.Text = value; }
        }

        public EntidadFinancieraPresenter EntidadFinancieraPresenter { get; set; }


        private void EntidadFinancieraView_Load(object sender, EventArgs e)
        {
            EntidadFinancieraPresenter = new EntidadFinancieraPresenter(this, NavigationMainMenu);
        }
    }
}
