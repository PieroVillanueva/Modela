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
    public partial class InmuebleBancoMostrarBanco : Form
    {
        InmuebleBanco banco;
        public InmuebleBancoMostrarBanco(InmuebleBanco banco)
        {
            this.banco = banco;
            InitializeComponent();
            ListarBanco();
            textBoxNombreBanco.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            textBoxIdBanco.Visible = false;

        }

        public void ListarBanco()
        {
            dgvBanco.DataSource = logBanco.Instancia.ListarBanco();
            //dgvBanco.Rows[dgvBanco.Rows.Count - 1].Selected = true;
        }

        public void Abrir()
        {
            ListarBanco();
            this.Show();
        }


        private void btnsave_Click_1(object sender, EventArgs e)
        {
            entBanco b = new entBanco();
            b.idBanco = int.Parse(textBoxIdBanco.Text);
            b.nombre = textBoxNombreBanco.Text.Trim();
            logBanco.Instancia.ModificarBanco(b);
            ListarBanco();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            banco.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            textBoxNombreBanco.Visible = true;
            label4.Visible = true;
            label2.Visible = true;
            textBoxIdBanco.Visible = true;
        }
    }
}

