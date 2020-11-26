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
    public partial class PropietarioRegistrarPropietario : Form
    {
        Propietario refPropietario;
        public PropietarioRegistrarPropietario(Propietario propietario)
        {
            this.refPropietario = propietario;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            entPropietario propi = new entPropietario();
            propi.dni = int.Parse(txtDni.Text.Trim());
            propi.nombre = txtNombre.Text.Trim();

            if (cmbSexo.SelectedItem.ToString() == "FEMENINO")
            {
                propi.sexo = 'F';
            }
            else if (cmbSexo.SelectedItem.ToString() == "MASCULINO")
            {
                propi.sexo = 'M';
            }
            propi.apellidoP = txtPaterno.Text.Trim();
            propi.apellidoM = txtMaterno.Text.Trim();
            propi.edad = int.Parse(txtEdad.Text.Trim());
            propi.telefono = int.Parse(txtTelefono.Text.Trim());
            propi.correo = txtCorreo.Text.Trim();
            propi.direccion = txtDireccion.Text.Trim();



            logPropietario.Instancia.InsertarPropietario(propi);

            this.Hide();
            refPropietario.abrir();


        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            refPropietario.Show();
        }
    }
}