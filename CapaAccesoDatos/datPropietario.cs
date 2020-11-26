using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
namespace CapaAccesoDatos
{
   public class datPropietario
    {
        //patron de Diseño Singleton
        private static readonly datPropietario _instancia = new datPropietario();
        public static datPropietario Instancia
        {
            get { return datPropietario._instancia; }
        }
        
        public List<entPropietario> ListarPropietario()
        {
            SqlCommand cmd = null;
            List<entPropietario> lista = new List<entPropietario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_listarPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPropietario Pro = new entPropietario();
                    Pro.idPropietario = Convert.ToInt32(dr["idPropietario"]);
                    Pro.dni = Convert.ToInt32(dr["dni"]);
                    Pro.nombre = dr["nombre"].ToString();
                    Pro.apellidoP = dr["apellidoP"].ToString();
                    Pro.apellidoM = dr["apellidoM"].ToString();
                    Pro.edad = Convert.ToInt32(dr["edad"]);
                    Pro.sexo = Convert.ToChar(dr["sexo"]);
                    Pro.telefono = Convert.ToInt32(dr["telefono"]);
                    Pro.direccion = dr["direccion"].ToString();
                    Pro.correo = dr["correo"].ToString();
                    lista.Add(Pro);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean InsertarPropietario(entPropietario Pro)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_registrarPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", Pro.dni);
                cmd.Parameters.AddWithValue("@nombre", Pro.nombre);
                cmd.Parameters.AddWithValue("@apellidoP", Pro.apellidoP);
                cmd.Parameters.AddWithValue("@apellidoM", Pro.apellidoM);
                cmd.Parameters.AddWithValue("@edad", Pro.edad);
                cmd.Parameters.AddWithValue("@sexo", Pro.sexo);
                cmd.Parameters.AddWithValue("@telefono", Pro.telefono);
                cmd.Parameters.AddWithValue("@direccion", Pro.direccion);
                cmd.Parameters.AddWithValue("@correo", Pro.correo);             
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        public List<entPropietario> BuscarPropietario(int dni)
        {
            SqlCommand cmd = null;
            List<entPropietario> lista = new List<entPropietario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_buscarPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPropietario Pro = new entPropietario();
                    Pro.idPropietario = Convert.ToInt32(dr["idPropietario"]); 
                    Pro.dni = Convert.ToInt32(dr["dni"]);
                    Pro.nombre = dr["nombre"].ToString();
                    Pro.apellidoP = dr["apellidoP"].ToString();
                    Pro.apellidoM = dr["apellidoM"].ToString();
                    Pro.edad = Convert.ToInt32(dr["edad"]);
                    Pro.sexo = Convert.ToChar(dr["sexo"]);
                    Pro.telefono = Convert.ToInt32(dr["telefono"]);
                    Pro.direccion = dr["direccion"].ToString();
                    Pro.correo = dr["correo"].ToString();
                    lista.Add(Pro);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public void EditarPropietario(entPropietario Pro)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_editarPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", Pro.dni);
                cmd.Parameters.AddWithValue("@nombre", Pro.nombre);
                cmd.Parameters.AddWithValue("@apellidoP", Pro.apellidoP);
                cmd.Parameters.AddWithValue("@apellidoM", Pro.apellidoM);
                cmd.Parameters.AddWithValue("@edad", Pro.edad);
                cmd.Parameters.AddWithValue("@telefono", Pro.telefono);
                cmd.Parameters.AddWithValue("@direccion", Pro.direccion);
                cmd.Parameters.AddWithValue("@correo", Pro.correo);
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }

        }
      

    }


}

