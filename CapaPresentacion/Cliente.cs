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
    public partial class Cliente : Form
    {
        ClienteRegistrarCliente refRegCliente;
        ClienteBuscarCliente refBuscarCliente;
        MainPrincipal refPrincipal;
        public Cliente(MainPrincipal refPrincipal)
        {
            this.refPrincipal = refPrincipal;
            InitializeComponent();
            listarClientes();
        }
        private void listarClientes()
        {
            dgvClientes.DataSource = logCliente.Instancia.ListarCliente();
            if (dgvClientes.Rows.Count > 0)
            {
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Selected = true;
            }
        }
        public void abrir()
        {
            listarClientes(); 
            this.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (refRegCliente == null)
            {
                refRegCliente = new ClienteRegistrarCliente(this);

            }
            refRegCliente.abrir();
            this.Hide();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (refBuscarCliente == null)
            {
                refBuscarCliente = new ClienteBuscarCliente(this);
            }
            refBuscarCliente.abrir2();
            this.Hide();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            refPrincipal.Show();
        }
    }
}
