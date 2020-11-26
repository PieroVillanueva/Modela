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
    public class datCiudad
    {
        private static readonly datCiudad _instancia = new datCiudad();
        public static datCiudad Instancia { get { return datCiudad._instancia; } }

        public int RegistrarCiudad(entCiudad obj)
        {

            int i = 0;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_registrarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", obj.nombre);
                cn.Open();


                i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                cmd.Connection.Close();

            }
            return i;

        }

        public List<entCiudad> ListarCiudad()
        {
            SqlCommand cmd = null;
            List<entCiudad> list = new List<entCiudad>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_listarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    entCiudad ciu = new entCiudad();
                    ciu.idCiudad = Convert.ToInt32(dr["idCiudad"]);
                    ciu.nombre = dr["nombre"].ToString();
                    list.Add(ciu);

                }

            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally { cmd.Connection.Close(); }
            return list;
        }


        public void ModificarCiudad(entCiudad ciu)
        {

            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_modificarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCiudad", ciu.idCiudad);
                cmd.Parameters.AddWithValue("@nombre", ciu.nombre);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cmd.Connection.Close(); }

        }

        public Boolean ValidarCiudad(string nombre)
        {
            SqlCommand cmd = null;
            Boolean validar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_validarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre",nombre);
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




    }
}
