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
    public partial class InmuebleBancoRegistrarBanco : Form
    {
        InmuebleBanco banco1;
        public InmuebleBancoRegistrarBanco(InmuebleBanco banco1)
        {
            this.banco1 = banco1;
            InitializeComponent();
        }
        private void agregarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                entBanco agregar = new entBanco();
                agregar.nombre = textBoxNombre.Text.Trim();
                logBanco.Instancia.RegistrarBanco(agregar);
                this.Hide();
                banco1.Show();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            banco1.Show();
        }
    }
}


    
