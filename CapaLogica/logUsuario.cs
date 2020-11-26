using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logUsuario
    {

        private static readonly logUsuario _instancia = new logUsuario();
        public static logUsuario Instancia
        {
            get { return logUsuario._instancia; }
        }

        public void InsertaUsuario(entUsuario Usu)
        {
            try
            {
                datUsuario.Instancia.InsertaUsuario(Usu);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
       
        public List<entUsuario> BuscarUsuario(int idUsuario)
        {
            return datUsuario.Instancia.BuscarUsuario(idUsuario);
        }
        public void EditarUsuario(entUsuario Usu)
        {
            try
            {
                datUsuario.Instancia.editarUsuario(Usu);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
        public void DeshabilitarUsuario(int idUsuario)
        {
            try
            {
                datUsuario.Instancia.DeshabilitaUsuario(idUsuario);
            }
            catch (Exception e)
            {
                throw e;

            }

        }

    }
}
