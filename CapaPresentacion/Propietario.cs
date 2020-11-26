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
    public partial class Propietario : Form
    {
         PropietarioRegistrarPropietario registar;
         PropietarioBuscarPropietario mostrar;
        MainPrincipal refPrincipal;
        public Propietario(MainPrincipal refPrincipal)
        {
            this.refPrincipal = refPrincipal;
            InitializeComponent();
            listarPropietarios();
        }
        private void listarPropietarios()
        {
            dgvPropietario.DataSource = logPropietario.Instancia.ListarPropietario();
            //dgvCliente.Rows[dgvCliente.Rows.Count - 1].Selected = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void abrir()

        {
            this.Show();
            listarPropietarios();


        }
     

        private void btnregistrar_Click_1(object sender, EventArgs e)
        {
            if (registar == null)
            {
                registar = new PropietarioRegistrarPropietario(this);
            }
            this.Hide();
            registar.Show();
        }

        private void btnmostrar_Click_1(object sender, EventArgs e)
        {
            if (mostrar == null)
            {
                mostrar = new PropietarioBuscarPropietario(this);
            }
            this.Hide();
            mostrar.abrir();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            refPrincipal.Show();
            this.Hide();
        }
    }
}
