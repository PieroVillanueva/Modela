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
    public partial class Usuario : Form
    {
        UsuarioRegistrarUsuario refRegUsuario;
        UsuarioMostrarDatosDeUsuario refRegMotrarD;
        MainPrincipal refPrincipal;
        //UsuarioMostrarVentasDeUsuario refRegVentarD;
        public Usuario(MainPrincipal refPrincipal)
        {
            this.refPrincipal = refPrincipal;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (refRegUsuario == null)
            {
                refRegUsuario = new UsuarioRegistrarUsuario(this);

            }
            refRegUsuario.abrir();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (refRegMotrarD == null)
            {
                refRegMotrarD = new UsuarioMostrarDatosDeUsuario(this);

            }
            refRegMotrarD.abrir();
            this.Hide();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            refPrincipal.Show();
            this.Hide();
        }
    }
}
