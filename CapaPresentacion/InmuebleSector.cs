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
    public partial class InmuebleSector : Form
    {
        InmuebleSectorMostrarSector mostrarSector;
        InmuebleSectorRegistrarSector registrarSector;
        MainPrincipal refPrincipal;
        public InmuebleSector(MainPrincipal refPrincipal)
        {
            this.refPrincipal = refPrincipal;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void b2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (mostrarSector == null)
            {
                mostrarSector = new InmuebleSectorMostrarSector(this);

            }
            mostrarSector.abrir();

        }

        private void b1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (registrarSector == null)
            {

                registrarSector = new InmuebleSectorRegistrarSector(this);

            }
            registrarSector.Show();

        }

        private void b3_Click(object sender, EventArgs e)
        {
            refPrincipal.Show();
            this.Hide();
        }
    }
}
