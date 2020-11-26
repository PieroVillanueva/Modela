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
    public partial class InmuebleSectorRegistrarSector : Form
    {
        InmuebleSector inmuebleSector;
        public InmuebleSectorRegistrarSector(InmuebleSector inmuebleSector)
        {
            this.inmuebleSector = inmuebleSector;
            InitializeComponent();
            ListarCiudad();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ListarCiudad()
        {
            cbx1.DataSource = logCiudad.Instancia.ListarCiudad();
            cbx1.DisplayMember = "nombre";
            cbx1.ValueMember = "idCiudad";

        }


        private void b1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(t1.Text.Trim()))
            {
                MessageBox.Show("Ingrese el nombre de un sector, por favor");
                return;

            }
            entSector ob = new entSector();

            ob.nombre = t1.Text.Trim();
            ob.id_Ciudad1 = Convert.ToInt32(cbx1.SelectedValue);

            int i = logSector.Instancia.RegistrarSector(ob);
            if (i > 0)
            {
                MessageBox.Show("Se registro el sector con exito");
            }
            else MessageBox.Show("No se pudo registrar");

        }

        private void b2_Click(object sender, EventArgs e)
        {
            this.Hide();
            inmuebleSector.Show();

        }
    }
}
