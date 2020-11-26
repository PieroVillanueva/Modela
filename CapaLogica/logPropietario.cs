using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logPropietario
    {
        private static readonly logPropietario _instancia = new logPropietario();
        public static logPropietario Instancia
        {
            get { return logPropietario._instancia; }
        }

        public void InsertarPropietario(entPropietario Pro)
        {
            try
            {
                datPropietario.Instancia.InsertarPropietario(Pro);
                MessageBox.Show("Insercion Completada");
            }
            catch (Exception e)
            {
                throw e;

            }

        }
        public List<entPropietario> ListarPropietario()
        {
            return datPropietario.Instancia.ListarPropietario();
        }
        public List<entPropietario> BuscarPropietario(int dni)
        {
            return datPropietario.Instancia.BuscarPropietario(dni);
        }
        public void EditarPropietario(entPropietario Pro)
        {
            try
            {
                datPropietario.Instancia.EditarPropietario(Pro);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
     
    }
}
