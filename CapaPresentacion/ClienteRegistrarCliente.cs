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
    public partial class ClienteRegistrarCliente : Form
    {
        Cliente refClie;
        public ClienteRegistrarCliente(Cliente refClie)
        {
            this.refClie = refClie;
            InitializeComponent();
        }
        public void abrir()
        {
            
            this.Show();
        }
        public void cerrar()
        {
            //limpiar
            this.Hide();
            refClie.abrir();

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           

            try
            {
                entCliente cliente = new entCliente();
                cliente.dniCliente = int.Parse(txtDni.Text.Trim());
                cliente.nombre = txtNombre.Text.Trim();
                cliente.apellidoP = txtApellidoPaterno.Text.Trim();
                cliente.apellidoM = txtApellidoMaterno.Text.Trim();
                cliente.edad = int.Parse(txtEdad.Text.Trim());
                if (cmbSexo.SelectedItem.ToString()=="FEMENINO")
                {
                    cliente.sexo = 'F';
                }
                else if (cmbSexo.SelectedItem.ToString() == "MASCULINO")
                {
                    cliente.sexo = 'M';
                }
                cliente.telefono = int.Parse(txtTelefono.Text.Trim());
                cliente.correo = txtCorreo.Text.Trim();
                cliente.habilitado = true;

                logCliente.Instancia.InsertaCliente(cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            cerrar();
            refClie.abrir();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
