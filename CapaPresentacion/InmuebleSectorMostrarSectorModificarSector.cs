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
    public partial class InmuebleSectorMostrarSectorModificarSector : Form
    {
        InmuebleSectorMostrarSector mostrarSector;
        public InmuebleSectorMostrarSectorModificarSector(InmuebleSectorMostrarSector mostrarSector)
        {
            this.mostrarSector = mostrarSector;
            InitializeComponent();
            ListarSector();
            b3.Enabled = false;
            t1.Enabled = false;
            t2.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




      
        private void ListarSector()
        {

            dgv1.DataSource = logSector.Instancia.ListarSector();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void b1_Click(object sender, EventArgs e)
        {
            b3.Enabled = true;
            t1.Enabled = true;
            t2.Enabled = true;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mostrarSector.abrir();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            ListarSector();
            if (string.IsNullOrEmpty(t1.Text.Trim()))
            {

                MessageBox.Show("Ingrese Sector a modificar, por favor");
                return;
            }
            else if (string.IsNullOrEmpty(t2.Text.Trim()))
            {

                MessageBox.Show("Ingrese un Id de Sector, por favor");
                return;

            }
            entSector aux = new entSector();
            aux.nombre = t1.Text.Trim();
            aux.idSec = Convert.ToInt32(t2.Text.Trim());
            logSector.Instancia.ModificarSector(aux);
            ListarSector();

        }
    }
}
