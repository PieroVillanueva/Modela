using CapaEntidad;
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

namespace CapaPresentacion
{
    public partial class UsuarioMostrarDatosDeUsuarioModificarDatos : Form
    {
        UsuarioMostrarDatosDeUsuario refCMostrarUsuario;
        int auxidUsuario;
        public UsuarioMostrarDatosDeUsuarioModificarDatos()
        {
            InitializeComponent();
        }
        public void abrir(DataGridViewRow filaActual, UsuarioMostrarDatosDeUsuario refCMostrarUsuario)
        {
            this.refCMostrarUsuario = refCMostrarUsuario;
            auxidUsuario = int.Parse(filaActual.Cells[0].Value.ToString());
            txtContraseña.Text = filaActual.Cells[1].Value.ToString();
            //txtDni.Text = filaActual.Cells[2].Value.ToString();
            txtNombre.Text = filaActual.Cells[3].Value.ToString();
            txtAPaterno.Text = filaActual.Cells[4].Value.ToString();
            txtAMaterno.Text = filaActual.Cells[5].Value.ToString();
            txtEdad.Text = filaActual.Cells[6].Value.ToString();
            //cbSexo.Text = filaActual.Cells[7].Value.ToString();
            txtCargo.Text = filaActual.Cells[8].Value.ToString();
            txtTelefono.Text = filaActual.Cells[9].Value.ToString();
            txtCorreo.Text = filaActual.Cells[10].Value.ToString();

            this.Show();
        }

    

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entUsuario Usu = new entUsuario();
                Usu.idUsuario = auxidUsuario;
                Usu.contrasena = txtContraseña.Text.Trim();
                //Usu.dni = int.Parse(txtDni.Text.Trim());
                Usu.nombre = txtNombre.Text.Trim();
                Usu.apellidoP = txtAPaterno.Text.Trim();
                Usu.apellidoM = txtAMaterno.Text.Trim();
                Usu.edad = int.Parse(txtEdad.Text.Trim());
                //if (cbSexo.SelectedItem.ToString() == "FEMENINO")
                //{
                //Usu.sexo = 'F';
                // }
                // else if (cbSexo.SelectedItem.ToString() == "MASCULINO")
                //  {
                //     Usu.sexo = 'M';
                // }
                Usu.telefono = int.Parse(txtTelefono.Text.Trim());
                Usu.correo = txtCorreo.Text.Trim();
                Usu.habilitar = true;
                logUsuario.Instancia.EditarUsuario(Usu);
                this.Hide();
                refCMostrarUsuario.abrir();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            refCMostrarUsuario.Show();

            this.Hide();
        }
    }
}
