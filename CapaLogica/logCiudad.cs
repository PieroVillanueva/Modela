using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logCiudad
    {
        private static readonly logCiudad _instancia = new logCiudad();
        public static logCiudad Instancia { get { return logCiudad._instancia; } }

        public int RegistrarCiudad(entCiudad obj)
        {
            try
            {
                int i = datCiudad.Instancia.RegistrarCiudad(obj);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<entCiudad> ListarCiudad()
        {
            return datCiudad.Instancia.ListarCiudad();
        }

        public void ModificarCiudad(entCiudad ciu)
        {
            try
            {

                datCiudad.Instancia.ModificarCiudad(ciu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean ValidarCiudad(String nombre) 
        {
            return datCiudad.Instancia.ValidarCiudad(nombre);
        }





    }
}
