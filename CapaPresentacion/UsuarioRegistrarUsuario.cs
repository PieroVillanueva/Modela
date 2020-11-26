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
    public partial class UsuarioRegistrarUsuario : Form
    {
        Usuario refUsuario;
        public UsuarioRegistrarUsuario(Usuario refUsuario)
        {
            this.refUsuario = refUsuario;
            InitializeComponent();
        }


        public void abrir()
        {
            this.Show();
        }
        public void cerrar()
        {
            this.Hide();
        }
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entUsuario usuario = new entUsuario();
                usuario.contrasena = txtContraseña.Text.Trim();
                usuario.dni = int.Parse(txtDni.Text.Trim());
                usuario.nombre = txtNombre.Text.Trim();
                usuario.apellidoP = txtApellidoP.Text.Trim();
                usuario.apellidoM = txtApellidoM.Text.Trim();
                usuario.edad = int.Parse(txtEdad.Text.Trim());
                if (cbSexo.SelectedItem.ToString() == "FEMENINO")
                {
                    usuario.sexo = 'F';
                }
                else if (cbSexo.SelectedItem.ToString() == "MASCULINO")
                {
                    usuario.sexo = 'M';
                }
                usuario.cargo = txtCargo.Text.Trim();
                usuario.telefono = int.Parse(txtTelefono.Text.Trim());
                usuario.correo = txtCorreo.Text.Trim();
                usuario.habilitar = true;

                logUsuario.Instancia.InsertaUsuario(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            cerrar();
            refUsuario.Show();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            refUsuario.Show();
            this.Hide();
        }
    }
}

