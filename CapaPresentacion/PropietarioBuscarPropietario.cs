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
    public partial class PropietarioBuscarPropietario : Form
    {
        Propietario refPropietario;
        PropietarioModificarPropietario refProModificarPropietario;
        int dniAux;
        public PropietarioBuscarPropietario(Propietario propietario)
        {
            this.refPropietario = propietario;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void abrir()
        {
            this.Show();
            busca();
        }

       
        private void busca()
        {
            btnmodificar.Enabled = false;
            dgvPropietario.DataSource = logPropietario.Instancia.BuscarPropietario(dniAux);
            if (dgvPropietario.Rows.Count > 0)
            {
                btnmodificar.Enabled = true;
            }
        }

        private void btnmodificar_Click_1(object sender, EventArgs e)
        {
            if (refProModificarPropietario == null)
            {
                refProModificarPropietario = new PropietarioModificarPropietario(this);
            }
            this.Hide();


            DataGridViewRow filaActual = dgvPropietario.CurrentRow;

            refProModificarPropietario.abrir(filaActual);
            this.Hide();
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            refPropietario.abrir();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dniAux = Convert.ToInt32(txtDni.Text.Trim());
            busca();
        }
    }
}
