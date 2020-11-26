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
    public partial class MainPrincipal : Form
    {
        Cita refCita;
        CiudadIngresarCiudad refCiudad;
        InmuebleSector refInmuebleSector;
        Cliente refCliente;
        Usuario refUsuario;
        Propietario refPropietario;
        InmuebleSitioDeInteres refSitioDeInteres;
        InmuebleBanco refBanco;

        public MainPrincipal()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (refCita == null)
            {
                refCita = new Cita(this);
            }
            this.Hide();
            refCita.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (refBanco == null)
            {
                refBanco = new InmuebleBanco(this);
            }
            this.Hide();
            refBanco.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (refCliente == null)
            {
                refCliente = new Cliente(this);
            }
            this.Hide();
            refCliente.abrir();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (refUsuario == null)
            {
                refUsuario = new Usuario(this);
            }
            this.Hide();
            refUsuario.Show();
        }

        private void btnPropietario_Click(object sender, EventArgs e)
        {
            if (refPropietario == null)
            {
                refPropietario = new Propietario(this);
            }
            this.Hide();
            refPropietario.Show();
        }

        private void btnSector_Click(object sender, EventArgs e)
        {
            if (refInmuebleSector == null)
            {
                refInmuebleSector = new InmuebleSector(this);
            }
            this.Hide();
            refInmuebleSector.Show();
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            if (refCiudad == null)
            {
                refCiudad = new CiudadIngresarCiudad(this);
            }
            this.Hide();
            refCiudad.Show();
        }

        private void btnSitioDeInteres_Click(object sender, EventArgs e)
        {
            if (refSitioDeInteres == null)
            {
                refSitioDeInteres = new InmuebleSitioDeInteres(this);
            }
            this.Hide();
            refSitioDeInteres.Show();
        }
    }
}
