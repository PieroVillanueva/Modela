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
    public class datCliente
    {
        //patron de Diseño Singleton
        private static readonly datCliente _instancia = new datCliente();
        public static datCliente Instancia
        {
            get { return datCliente._instancia; }
        }

        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_listarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.dniCliente = Convert.ToInt32(dr["dniCliente"]);
                    Cli.nombre = dr["nombre"].ToString();
                    Cli.apellidoP = dr["apellidoP"].ToString();
                    Cli.apellidoM = dr["apellidoM"].ToString();
                    Cli.edad = Convert.ToInt32(dr["edad"]);
                    Cli.sexo = Convert.ToChar(dr["sexo"]);
                    Cli.telefono = Convert.ToInt32(dr["telefono"]);
                    Cli.correo = dr["correo"].ToString();
                    Cli.habilitado = Convert.ToBoolean(dr["habilitado"]);
                    
                    lista.Add(Cli);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean InsertarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_registrarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniCliente", Cli.dniCliente);
                cmd.Parameters.AddWithValue("@nombre", Cli.nombre);
                cmd.Parameters.AddWithValue("@apellidoP", Cli.apellidoP);
                cmd.Parameters.AddWithValue("@apellidoM", Cli.apellidoM);
                cmd.Parameters.AddWithValue("@edad", Cli.edad);
                cmd.Parameters.AddWithValue("@sexo", Cli.sexo);
                cmd.Parameters.AddWithValue("@telefono", Cli.telefono);
                cmd.Parameters.AddWithValue("@correo", Cli.correo);
                cmd.Parameters.AddWithValue("@habilitado", Cli.habilitado);
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
        public List<entCliente> BuscarCliente(int dni)
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_buscarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dniCliente",dni);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.dniCliente = Convert.ToInt32(dr["dniCliente"]);
                    Cli.nombre = dr["nombre"].ToString();
                    Cli.apellidoP = dr["apellidoP"].ToString();
                    Cli.apellidoM = dr["apellidoM"].ToString();
                    Cli.edad = Convert.ToInt32(dr["edad"]);
                    Cli.sexo = Convert.ToChar(dr["sexo"]);
                    Cli.telefono = Convert.ToInt32(dr["telefono"]);
                    Cli.correo = dr["correo"].ToString();
                    Cli.habilitado = Convert.ToBoolean(dr["habilitado"]);

                    lista.Add(Cli);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public void EditarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_editarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dniCliente", Cli.dniCliente);
                cmd.Parameters.AddWithValue("@nombre", Cli.nombre);
                cmd.Parameters.AddWithValue("@apellidoP", Cli.apellidoP);
                cmd.Parameters.AddWithValue("@apellidoM", Cli.apellidoM);
                cmd.Parameters.AddWithValue("@edad", Cli.edad);
                cmd.Parameters.AddWithValue("@telefono", Cli.telefono);
                cmd.Parameters.AddWithValue("@correo", Cli.correo);             
                cn.Open();
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
           
        }
        public void DeshabilitarCliente(int dniCliente)
        {
            SqlCommand cmd = null;
            
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_deshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dniCliente", dniCliente);
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
