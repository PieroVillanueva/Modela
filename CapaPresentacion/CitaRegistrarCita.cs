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
    public partial class CitaRegistrarCita : Form
    {
        Cita cita;
        public CitaRegistrarCita(Cita cita)
        {
            this.cita = cita;
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        

        private void fechaCita_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdInmueble_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                entCita agregar = new entCita();
                agregar.fecha = DateTime.Parse(dateTimeFechaCita.Text.Trim());
                agregar.estado = textBoxEstadoCita.Text.Trim();
                agregar.id_Inmmueble8 = int.Parse(textBoxIdInmueble.Text.Trim());
                agregar.dni_Cliente3 = int.Parse(textBoxIdCliente.Text.Trim());
                logCita.Instancia.RegistrarCita(agregar);
            }
            catch
            {

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            cita.Show();
        }
    }
}
