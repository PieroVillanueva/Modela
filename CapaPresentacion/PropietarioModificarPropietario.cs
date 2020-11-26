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
    public partial class PropietarioModificarPropietario : Form
    {
        PropietarioBuscarPropietario refBuscarPropietario;
        int auxDni;
        public PropietarioModificarPropietario(PropietarioBuscarPropietario mostrar)
        {
            this.refBuscarPropietario = mostrar;
            InitializeComponent();
        }

        private void txtpaterno_TextChanged(object sender, EventArgs e)
        {

        }
        public void abrir(DataGridViewRow filaActual)
        {
            auxDni = int.Parse(filaActual.Cells[1].Value.ToString());
            txtnombre.Text = filaActual.Cells[2].Value.ToString();
            txtpaterno.Text = filaActual.Cells[3].Value.ToString();
            txtmaterno.Text = filaActual.Cells[4].Value.ToString();
            txtedad.Text = filaActual.Cells[5].Value.ToString();

            txttelefono.Text = filaActual.Cells[7].Value.ToString();
            txtdireccion.Text = filaActual.Cells[8].Value.ToString();
            txtcorreo.Text = filaActual.Cells[9].Value.ToString();

            this.Show();
        }



        private void btnaceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entPropietario propie = new entPropietario();
                propie.dni = auxDni;
                propie.nombre = txtnombre.Text.Trim();
                propie.apellidoP = txtpaterno.Text.Trim();
                propie.apellidoM = txtmaterno.Text.Trim();
                propie.edad = int.Parse(txtedad.Text.Trim());
                propie.telefono = int.Parse(txttelefono.Text.Trim());
                propie.direccion = txtdireccion.Text.Trim();
                propie.correo = txtcorreo.Text.Trim();

                logPropietario.Instancia.EditarPropietario(propie);
                this.Hide();
                refBuscarPropietario.abrir();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            refBuscarPropietario.abrir();
        }
    }
}
