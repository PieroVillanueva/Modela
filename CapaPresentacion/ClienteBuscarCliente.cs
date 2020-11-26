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
    public partial class ClienteBuscarCliente : Form
    {
        ClienteBuscarClienteModificarDatos clienteModificarDatos;
        Cliente refCliente;
        int dniAux;
        public ClienteBuscarCliente(Cliente refCliente)
        {
            this.refCliente = refCliente;
            InitializeComponent();
            inicio();
        }
        private void inicio()
        {
            btnInhabilitar.Enabled = false;
            btnModificarCliente.Enabled = false;
        }
        public void abrir()
        {
            busca();
            this.Show();
            
        }
        public void abrir2()
        {
            this.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dniAux = Convert.ToInt32(txtDni.Text.Trim());
            busca();
        }
        private void busca()
        {
            inicio();
            dgvCliente.DataSource = logCliente.Instancia.BuscarCliente(dniAux);
            if (dgvCliente.Rows.Count > 0)
            {
                btnInhabilitar.Enabled = true;
                btnModificarCliente.Enabled = true;
            }
        }
        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
           
           
            logCliente.Instancia.DeshabilitaCliente(dniAux);
            MessageBox.Show("Cliente Inhabilitado");
            busca();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (clienteModificarDatos == null)
            {
                clienteModificarDatos = new ClienteBuscarClienteModificarDatos();

            }
            
            DataGridViewRow filaActual = dgvCliente.CurrentRow;
           
            clienteModificarDatos.abrir(filaActual,this);
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            refCliente.abrir();
        }
    }
}
