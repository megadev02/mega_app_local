using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mega.App.Views.Interface;

namespace Mega.App.Views
{
    public partial class ReciboIngresoEgresoView : Form, IReciboCajaView
    {
        public ReciboIngresoEgresoView()
        {
            InitializeComponent();
        }

        public int ReciboCajaId { get; set; }
        public string CodDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        public string Concepto { get; set; }
        public decimal Importe { get; set; }
        public int MovimientoFondoId { get; set; }
    }
}
