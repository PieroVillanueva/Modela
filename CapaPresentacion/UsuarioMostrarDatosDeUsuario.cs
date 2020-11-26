using CapaLogica;
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

namespace CapaPresentacion
{
    public partial class UsuarioMostrarDatosDeUsuario : Form
    {
        UsuarioMostrarDatosDeUsuarioModificarDatos UsuarioModificarDatos;
        Usuario refUsuario;
        int idUsuarioAux;

        public UsuarioMostrarDatosDeUsuario(Usuario refUsuario)
        {
            this.refUsuario = refUsuario;
            InitializeComponent();
            inicio();
        }



        private void inicio()
        {
            btnInhabilitar.Enabled = false;
            btnModificarUsuario.Enabled = false;
        }
        public void abrir()
        {
            mostrar();
            this.Show();

        }
        public void abrir2()
        {
            this.Show();
        }
       
        private void mostrar()
        {
            inicio();
            dgvUsuario.DataSource = logUsuario.Instancia.BuscarUsuario(idUsuarioAux);
            if (dgvUsuario.Rows.Count > 0)
            {
                btnInhabilitar.Enabled = true;
                btnModificarUsuario.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            idUsuarioAux = Convert.ToInt32(txtId.Text.Trim());
            mostrar();
        }

        private void btnModificarUsuario_Click_1(object sender, EventArgs e)
        {
            if (UsuarioModificarDatos == null)
            {
                UsuarioModificarDatos = new UsuarioMostrarDatosDeUsuarioModificarDatos();

            }
            DataGridViewRow filaActual = dgvUsuario.CurrentRow;
            UsuarioModificarDatos.abrir(filaActual, this);
            this.Hide();

        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            logUsuario.Instancia.DeshabilitarUsuario(idUsuarioAux);
            MessageBox.Show("Usuario Inhabilitado");
            mostrar();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            refUsuario.Show();
            this.Hide();
        }
    }
}