using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logSector
    {
        private static readonly logSector _instancia = new logSector();
        public static logSector Instancia { get { return logSector._instancia; } }

        public int RegistrarSector(entSector obj)
        {
            try
            {
                int i = datSector.Instancia.RegistrarSector(obj);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<entSector> ListarSector()
        {
            return datSector.Instancia.ListarSector();
        }

        public void ModificarSector(entSector sec)
        {
            try
            {

                datSector.Instancia.ModificarSector(sec);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
