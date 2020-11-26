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
    public partial class ClienteBuscarClienteModificarDatos : Form
    {
        ClienteBuscarCliente refCBuscarCliente;
        int auxDni;
        public ClienteBuscarClienteModificarDatos()
        {
            InitializeComponent();
        }
        public void abrir(DataGridViewRow filaActual, ClienteBuscarCliente refCBuscarCliente)
        {
            this.refCBuscarCliente = refCBuscarCliente;
            auxDni = int.Parse(filaActual.Cells[0].Value.ToString());
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtApellidoP.Text= filaActual.Cells[2].Value.ToString();
            txtApellidoMa.Text = filaActual.Cells[3].Value.ToString();
            txtEdad.Text = filaActual.Cells[4].Value.ToString();
            txtTelefono.Text=filaActual.Cells[6].Value.ToString();
            txtCorreo.Text= filaActual.Cells[7].Value.ToString();
            this.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try{
                entCliente Cli = new entCliente();
                Cli.dniCliente = auxDni;
                Cli.nombre = txtNombre.Text.Trim();
                Cli.apellidoP = txtApellidoP.Text.Trim();
                Cli.apellidoM = txtApellidoMa.Text.Trim();
                Cli.edad = int.Parse(txtEdad.Text.Trim());
                Cli.telefono = int.Parse(txtTelefono.Text.Trim());
                Cli.correo = txtCorreo.Text.Trim();

                logCliente.Instancia.EditaCliente(Cli);
                this.Hide();
                refCBuscarCliente.abrir();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            refCBuscarCliente.Show();
        }
    }
}
