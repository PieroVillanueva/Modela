using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datBanco
    {
        public static readonly datBanco _instancia = new datBanco();
        public static datBanco Instancia
        {
            get { return datBanco._instancia; }
        }

        public List<entBanco> ListarBanco()
        {
            SqlCommand cmd = null;
            List<entBanco> lista = new List<entBanco>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListaBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure; 
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entBanco Banco = new entBanco();
                    Banco.idBanco = Convert.ToInt32(dr["idBanco"]);
                    Banco.nombre = dr["nombre"].ToString();
                    lista.Add(Banco);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close();  }
            return lista;
        }

        public Boolean RegistrarBanco(entBanco Banco)
        {
            SqlCommand cmd = null;
            Boolean registra = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("insertarBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", Banco.nombre);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if(i>0)
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

        public void ModificarBanco(entBanco Banco)
        {

            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("modificarBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idBanco", Banco.idBanco);
                cmd.Parameters.AddWithValue("@nombre", Banco.nombre);
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
