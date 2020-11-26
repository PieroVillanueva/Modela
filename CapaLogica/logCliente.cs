using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logCliente
    {
        private static readonly logCliente _instancia = new logCliente();
        public static logCliente Instancia
        {
            get { return logCliente._instancia; }
        }

        public void InsertaCliente(entCliente Cli)
        {
            try
            {
                datCliente.Instancia.InsertarCliente(Cli);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
        public List<entCliente> BuscarCliente(int dni)
        {
            return datCliente.Instancia.BuscarCliente(dni);
        }
        public void EditaCliente(entCliente Cli)
        {
            try
            {
                datCliente.Instancia.EditarCliente(Cli);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
        public void DeshabilitaCliente(int dniCliente)
        {
            try
            {
                datCliente.Instancia.DeshabilitarCliente(dniCliente);
            }
            catch (Exception e)
            {
                throw e;

            }

        }

    }
}
