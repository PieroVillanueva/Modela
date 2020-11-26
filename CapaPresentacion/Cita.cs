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
    public partial class Cita : Form
    {
        CitaRegistrarCita registrarCita;
        CitaBuscarCita buscarCita;
        MainPrincipal refPrincipal;
        public Cita(MainPrincipal refPrincipal)
        {
            this.refPrincipal = refPrincipal;
            InitializeComponent();
        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (registrarCita == null)
            {
                registrarCita = new CitaRegistrarCita(this);
            }
            this.Hide();
            registrarCita.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (buscarCita == null)
            {
                buscarCita = new CitaBuscarCita(this);
            }
            this.Hide();
            buscarCita.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            refPrincipal.Show();
            this.Hide();
        }
    }

}

