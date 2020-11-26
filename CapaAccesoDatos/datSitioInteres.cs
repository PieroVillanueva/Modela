using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datSitioInteres
    {
        private static readonly datSitioInteres _instancia = new datSitioInteres();
        public static datSitioInteres Instancia { get { return datSitioInteres._instancia; } }

        public Boolean RegistrarSinteres(entSitioInteres obj)
        {
            SqlCommand cmd = null;
            Boolean registra = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_registrarSitin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", obj.nombre);
                cmd.Parameters.AddWithValue("@direccion", obj.direccion);
                cn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    registra = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return registra;

        }

        public List<entSitioInteres> ListarSinteres()
        {
            SqlCommand cmd = null;
            List<entSitioInteres> list = new List<entSitioInteres>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_listarSitin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    entSitioInteres sint = new entSitioInteres();
                    sint.idSitIn= Convert.ToInt32(dr["idSitIn"]);
                    sint.nombre = dr["nombre"].ToString();
                    sint.direccion = dr["direccion"].ToString();
                    list.Add(sint);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cmd.Connection.Close(); }
            return list;
        }


        public void ModificarSitin(entSitioInteres sin)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_modificarSitin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSitIn", sin.idSitIn);
                cmd.Parameters.AddWithValue("@nombre", sin.nombre);
                cmd.Parameters.AddWithValue("@direccion", sin.direccion);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cmd.Connection.Close(); }

        }

        public Boolean ValidarSinteres(string nombre)
        {
            SqlCommand cmd = null;
            Boolean validar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_validarSitin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    validar = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cmd.Connection.Close(); }
            return validar;
        }

        public List<entSitioInteres> BuscarSinteres(int id)
        {
            SqlCommand cmd = null;
            List<entSitioInteres> list = new List<entSitioInteres>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_buscarSitin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    entSitioInteres sint = new entSitioInteres();
                    sint.idSitIn = Convert.ToInt32(dr["idSitIn"]);
                    sint.nombre = dr["nombre"].ToString();
                    sint.direccion = dr["direccion"].ToString();
                    list.Add(sint);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cmd.Connection.Close(); }
            return list;
        }

        public Boolean EliminaSitin(int idSitin)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_eliminarSitin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSitIn", idSitin);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return elimina;
        }
    }
}
