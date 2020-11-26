using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class InmuebleSitioDeInteresMostrarSitioDeInteresEliminar : Form
    {
        InmuebleSitioDeInteres inm;
        public InmuebleSitioDeInteresMostrarSitioDeInteresEliminar(InmuebleSitioDeInteres inm)
        {
            this.inm = inm;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_si_Click_1(object sender, EventArgs e)
        {
            Form m = new InmuebleSitioDeInteresMostrarSitioDeInteres(inm);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}