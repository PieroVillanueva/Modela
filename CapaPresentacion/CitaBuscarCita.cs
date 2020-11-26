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
    public partial class CitaBuscarCita : Form
    {
        Cita cita;
        public CitaBuscarCita(Cita cita)
        {
            this.cita = cita;
            InitializeComponent();
            ListarCita();
            dateTimeCita.Visible = false;
            textBoxCitaIdIngreso.Visible = false;
            textBoxCitaInmuebleIngreso.Visible = false;
            textBoxDniIngreso.Visible = false;
            textBoxEstadoCita.Visible = false;
            label8.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        public void ListarCita()
        {
            dgvCita.DataSource = logCita.Instancia.ListarCita();
            //dgvCita.Rows[dgvCita.Rows.Count - 1].Selected = true;
        }

       


        private void button2_Click_1(object sender, EventArgs e)
        {
            dateTimeCita.Visible = true;
            textBoxCitaIdIngreso.Visible = true;
            textBoxCitaInmuebleIngreso.Visible = true;
            textBoxDniIngreso.Visible = true;
            textBoxEstadoCita.Visible = true;
            label8.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            entCita c = new entCita();
            c.idCita = int.Parse(textBoxCitaIdIngreso.Text.Trim());
            c.fecha = DateTime.Parse(dateTimeCita.Text.Trim());
            c.estado = textBoxEstadoCita.Text.Trim();
            c.dni_Cliente3 = int.Parse(textBoxDniIngreso.Text.Trim());
            c.id_Inmmueble8 = int.Parse(textBoxCitaInmuebleIngreso.Text.Trim());

            logCita.Instancia.ModificaCita(c);
            ListarCita();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            cita.Show();
        }
    }
}
