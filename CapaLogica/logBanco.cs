using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;
using System.Data;

namespace CapaLogica
{
   public class logBanco
    {
        private static readonly logBanco instancia = new logBanco();
        public static logBanco Instancia
        {
            get { return logBanco.instancia; }
        }
        public List<entBanco> ListarBanco()
        {
            return datBanco.Instancia.ListarBanco();
        }

        public void RegistrarBanco(entBanco Banco)
        {
            try
            {
                datBanco.Instancia.RegistrarBanco(Banco);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public void ModificarBanco(entBanco Banco)
        {
            try
            {
                datBanco.Instancia.ModificarBanco(Banco);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
