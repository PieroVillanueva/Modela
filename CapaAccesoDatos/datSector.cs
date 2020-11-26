using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datSector
    {

        private static readonly datSector _instancia = new datSector();
        public static datSector Instancia { get { return datSector._instancia; } }

        public int RegistrarSector(entSector obj)
        {

            int i = 0;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_registrarSector", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", obj.nombre);
                cmd.Parameters.AddWithValue("@idCiudad1", obj.id_Ciudad1);
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

        public List<entSector> ListarSector()
        {
            SqlCommand cmd = null;
            List<entSector> list = new List<entSector>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_listarSector", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    entSector sec = new entSector();
                    sec.idSec = Convert.ToInt32(dr["idSec"]);
                    sec.nombre = dr["nombre"].ToString();
                    sec.id_Ciudad1 = Convert.ToInt32(dr["id_Ciudad1"]);
                    list.Add(sec);

                }

            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally { cmd.Connection.Close(); }
            return list;
        }

        public void ModificarSector(entSector sec)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_modificarSector", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSec", sec.idSec);
                cmd.Parameters.AddWithValue("@nombre", sec.nombre);
                //cmd.Parameters.AddWithValue("@id_Ciudad1", sec.id_Ciudad1);
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
