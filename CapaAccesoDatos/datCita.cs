using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datCita
    {
        private static readonly datCita _instancia = new datCita();
        public static datCita Instancia
        {
            get { return datCita._instancia; }
        }

        public List<entCita> ListarCita()
        {
            SqlCommand cmd = null;
            List<entCita> lista = new List<entCita>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarCita", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCita Cita = new entCita();
                    Cita.idCita = Convert.ToInt32(dr["idCita"]);
                    Cita.dni_Cliente3 = Convert.ToInt32(dr["dni_Cliente3"]);
                    Cita.fecha = Convert.ToDateTime(dr["fecha"]);
                    Cita.id_Inmmueble8 = Convert.ToInt32(dr["id_Inmueble8"]);
                    Cita.estado = dr["estado"].ToString();
                    lista.Add(Cita);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;

        }

        public Boolean RegistrarCita(entCita Cita)
        {
            SqlCommand cmd = null;
            Boolean registra = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("RegistrarCita", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni_Cliente3", Cita.dni_Cliente3);
                cmd.Parameters.AddWithValue("@fecha", Cita.fecha);
                cmd.Parameters.AddWithValue("@id_Inmueble8", Cita.id_Inmmueble8);
                cmd.Parameters.AddWithValue("@estado", Cita.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    registra = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
                return registra;
            
        }
        public void ModificarCita(entCita Cita)
        {

            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ModificarCita", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni_Cliente3", Cita.dni_Cliente3);
                cmd.Parameters.AddWithValue("@fecha", Cita.fecha);
                cmd.Parameters.AddWithValue("@id_Inmueble8", Cita.id_Inmmueble8);
                cmd.Parameters.AddWithValue("@estado", Cita.estado);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cmd.Connection.Close(); }

        }
    }
}
