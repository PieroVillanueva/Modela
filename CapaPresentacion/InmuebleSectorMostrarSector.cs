using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class InmuebleSectorMostrarSector : Form
    {

        InmuebleSector inmuebleSector;
        InmuebleSectorMostrarSectorModificarSector modificarSector;


        public InmuebleSectorMostrarSector(InmuebleSector inmuebleSector)
        {
            this.inmuebleSector = inmuebleSector;
            InitializeComponent();
            ListarSector();
        }

        private void ListarSector()
        {

            dgv1.DataSource = logSector.Instancia.ListarSector();
        }

        public void abrir()
        {

            ListarSector();
            this.Show();
        }

        private void InmuebleSectorMostrarSector_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


  

        private void b1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (modificarSector == null)
            {

                modificarSector = new InmuebleSectorMostrarSectorModificarSector(this);

            }
            modificarSector.Show();

        }

        private void b2_Click(object sender, EventArgs e)
        {
            this.Hide();
            inmuebleSector.Show();
        }
    }
}