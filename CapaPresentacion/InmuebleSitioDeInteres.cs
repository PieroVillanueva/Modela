using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class InmuebleSitioDeInteres : Form
    {
        InmuebleSitioDeInteresRegistrarSitioDeInteres registrarSitioDeInteres;
        InmuebleSitioDeInteresMostrarSitioDeInteres buscarSitioDeInteres;
        MainPrincipal refPrincipal;
        public InmuebleSitioDeInteres(MainPrincipal refPrincipal)
        {
            this.refPrincipal= refPrincipal;
            InitializeComponent();
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            if (registrarSitioDeInteres == null)
            {
                registrarSitioDeInteres = new InmuebleSitioDeInteresRegistrarSitioDeInteres(this);

            }
            this.Hide();
            registrarSitioDeInteres.Show();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (buscarSitioDeInteres == null)
            {
                buscarSitioDeInteres = new InmuebleSitioDeInteresMostrarSitioDeInteres(this);

            }
            this.Hide();
            buscarSitioDeInteres.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            refPrincipal.Show();
        }
    }
}
