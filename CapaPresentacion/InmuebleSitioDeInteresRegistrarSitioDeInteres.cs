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
    public partial class InmuebleSitioDeInteresRegistrarSitioDeInteres : Form
    {
        InmuebleSitioDeInteres inm;

        public InmuebleSitioDeInteresRegistrarSitioDeInteres(InmuebleSitioDeInteres inm)
        {
            this.inm = inm;
            InitializeComponent();
            listarSitin();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void listarSitin()
        {
            dgvMostrar.DataSource = logSitioInteres.Instancia.ListarSitin();
            //dgvMostrar.Rows[dgvMostrar.Rows.Count - 1].Selected = true;
        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            entSitioInteres registrar = new entSitioInteres();
            registrar.nombre = txt_nombre.Text.Trim();
            registrar.direccion = txt_Direccion.Text.Trim();
            logSitioInteres.Instancia.RegistrarSinteres(registrar);
            listarSitin();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            inm.Show();
        }
    }
}
