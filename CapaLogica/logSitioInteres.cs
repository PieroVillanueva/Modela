using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logSitioInteres
    {
        private static readonly logSitioInteres _instancia = new logSitioInteres();
        public static logSitioInteres Instancia { get { return logSitioInteres._instancia; } }

        public void RegistrarSinteres(entSitioInteres obj)
        {
            try
            {
              datSitioInteres.Instancia.RegistrarSinteres(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<entSitioInteres> ListarSitin()
        {
            return datSitioInteres.Instancia.ListarSinteres();
        }

        public void ModificarSinteres(entSitioInteres sin)
        {
            try
            {
                datSitioInteres.Instancia.ModificarSitin(sin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean ValidarSitin(String nombre)
        {
            return datSitioInteres.Instancia.ValidarSinteres(nombre);
        }

        public List<entSitioInteres> BuscarSitin(int id)
        {
            return datSitioInteres.Instancia.BuscarSinteres(id);
        }

        public void EliminaSitin(int idSitin)
        {
            try
            {
                datSitioInteres.Instancia.EliminaSitin(idSitin);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
    }
}
