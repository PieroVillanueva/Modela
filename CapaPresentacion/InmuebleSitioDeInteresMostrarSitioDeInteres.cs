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
    public partial class InmuebleSitioDeInteresMostrarSitioDeInteres : Form
    {
        InmuebleSitioDeInteres inmu;
        InmuebleSitioDeInteresMostrarSitioDeInteresModificarDatos modi;

        public InmuebleSitioDeInteresMostrarSitioDeInteres(InmuebleSitioDeInteres inmu)
        {
            this.inmu = inmu;
            InitializeComponent();
            buscarSitin();
        }



        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //buscarSitin();
        }


        public void ListarSitin()
        {
            dgv_Busqueda.DataSource = logSitioInteres.Instancia.ListarSitin();
            //dgv_Busqueda.Rows[dgv_Busqueda.Rows.Count - 1].Selected = true;
        }

        public void buscarSitin()
        {
            dgv_Busqueda.DataSource = logSitioInteres.Instancia.ListarSitin();
            //dgv_Busqueda.Rows[dgv_Busqueda.Rows.Count - 1].Selected = true;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA ELIMINAR ESTE SITIO DE INTERÉS? ", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int idSit;
                DataGridViewRow SitioActual = dgv_Busqueda.CurrentRow;
                idSit = int.Parse(SitioActual.Cells[0].Value.ToString());
                logSitioInteres.Instancia.EliminaSitin(idSit);
                ListarSitin();
            }
        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            inmu.Show();
        }

        private void dgv_Busqueda_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (modi == null)
            {
                modi = new InmuebleSitioDeInteresMostrarSitioDeInteresModificarDatos(this);

            }

            if (dgv_Busqueda.Rows.Count > 0)
            {
                DataGridViewRow SitioActual = dgv_Busqueda.Rows[e.RowIndex];
                modi.txt_id.Text = SitioActual.Cells[0].Value.ToString();
                modi.txt_nombre.Text = SitioActual.Cells[1].Value.ToString();
                modi.txt_direccion.Text = SitioActual.Cells[2].Value.ToString();
                //  modi.Show();
                modi.Show();
            }

        }



        /*public void buscarSitin()
        {
            int m = Convert.ToInt32(txt_ID.Text);
            dgv_Busqueda.DataSource = logSitioInteres.Instancia.BuscarSitin(m);
            dgv_Busqueda.Rows[dgv_Busqueda.Rows.Count - 1].Selected = true;
        }*/
    }
}