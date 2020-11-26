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
    public partial class CiudadIngresarCiudad : Form
    {
        MainPrincipal refPrincipal;
        public CiudadIngresarCiudad(MainPrincipal refPrincipal)
        {
            this.refPrincipal = refPrincipal;
            InitializeComponent();
            ListarCiudad();
            b3.Enabled = false;
            t2.Enabled = false;
        }

        private void ListarCiudad()
        {

            dgv1.DataSource = logCiudad.Instancia.ListarCiudad();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(t1.Text.Trim()))
            {
                MessageBox.Show("Ingrese Nombre de Ciudad, por favor");
                return;

            }

            entCiudad ob = new entCiudad();
            ob.nombre = t1.Text.Trim();
            Boolean j = logCiudad.Instancia.ValidarCiudad(ob.nombre);
            if (!j)
            {
                int i = logCiudad.Instancia.RegistrarCiudad(ob);

                if (i > 0)
                {
                    MessageBox.Show("Se registro usuario con exito");

                }
                else MessageBox.Show("No se pudo registrar");
            }
            else MessageBox.Show("Ya existe una Ciudad con ese nombre");
            ListarCiudad();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            b3.Enabled = true;
            t2.Enabled = true;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            this.Hide();
            refPrincipal.Show();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            ListarCiudad();
            if (string.IsNullOrEmpty(t1.Text.Trim()))
            {

                MessageBox.Show("Ingrese una Ciudd a modificar, por favor");
                return;
            }
            else if (string.IsNullOrEmpty(t2.Text.Trim()))
            {

                MessageBox.Show("Ingrese un Id de Ciudad, por favor");
                return;

            }

            entCiudad aux = new entCiudad();
            aux.nombre = t1.Text.Trim();
            aux.idCiudad = Convert.ToInt32(t2.Text.Trim());
            Boolean j = logCiudad.Instancia.ValidarCiudad(aux.nombre);
            if (!j)
            {
                logCiudad.Instancia.ModificarCiudad(aux);
            }
            else MessageBox.Show("Ya existe una Ciudad con ese nombre");

            ListarCiudad();
        }
    }
}