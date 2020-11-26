using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logCita
    {
        private static readonly logCita instancia = new logCita();
        public static logCita Instancia
        {
            get { return logCita.instancia; }
        }

        public List<entCita> ListarCita()
        {
            return datCita.Instancia.ListarCita();
        }

        public void RegistrarCita(entCita Cita)
        {
            try
            {
                datCita.Instancia.RegistrarCita(Cita);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ModificaCita(entCita Cita)
        {
            try
            {
                datCita.Instancia.ModificarCita(Cita);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
    }
}
