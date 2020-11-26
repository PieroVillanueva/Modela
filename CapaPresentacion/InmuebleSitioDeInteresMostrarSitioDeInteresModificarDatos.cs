using System;
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
    public partial class InmuebleSitioDeInteresMostrarSitioDeInteresModificarDatos : Form
    {
        InmuebleSitioDeInteresMostrarSitioDeInteres mostrar;
        // InmuebleSitioDeInteres inm;
        public InmuebleSitioDeInteresMostrarSitioDeInteresModificarDatos(InmuebleSitioDeInteresMostrarSitioDeInteres mostrar)
        {
            this.mostrar = mostrar;
            InitializeComponent();
        }

     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            entSitioInteres s = new entSitioInteres();
            s.idSitIn = int.Parse(txt_id.Text.Trim());
            s.nombre = txt_nombre.Text.Trim();
            s.direccion = txt_direccion.Text.Trim();
            logSitioInteres.Instancia.ModificarSinteres(s);
            this.Hide();
            mostrar.buscarSitin();
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
