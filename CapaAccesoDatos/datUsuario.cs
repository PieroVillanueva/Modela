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
    public class datUsuario
    {
        //patron de Diseño Singleton
        private static readonly datUsuario _instancia = new datUsuario();
        public static datUsuario Instancia
        {
            get { return datUsuario._instancia; }
        }


        //Insertar

        public Boolean InsertaUsuario(entUsuario Usu)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@contraseña", Usu.contrasena);
                cmd.Parameters.AddWithValue("@dni", Usu.dni);
                cmd.Parameters.AddWithValue("@nombre", Usu.nombre);
                cmd.Parameters.AddWithValue("@apellidoP", Usu.apellidoP);
                cmd.Parameters.AddWithValue("@apellidoM", Usu.apellidoM);
                cmd.Parameters.AddWithValue("@edad", Usu.edad);
                cmd.Parameters.AddWithValue("@sexo", Usu.sexo);
                cmd.Parameters.AddWithValue("@cargo", Usu.cargo);
                cmd.Parameters.AddWithValue("@telefono", Usu.telefono);
                cmd.Parameters.AddWithValue("@correo", Usu.correo);
                cmd.Parameters.AddWithValue("@habilitar", Usu.habilitar);
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
        //Editar
        public  void editarUsuario(entUsuario Usu)
        {
            SqlCommand cmd = null;
   
            try
            {
                
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_editarUsuario", cn);
                cmd.Parameters.AddWithValue("@idUsuario", Usu.idUsuario);
                cmd.Parameters.AddWithValue("@contrasena", Usu.contrasena);
                //cmd.Parameters.AddWithValue("@dni", Usu.dni);
                cmd.Parameters.AddWithValue("@nombre", Usu.nombre);
                cmd.Parameters.AddWithValue("@apellidoP", Usu.apellidoP);
                cmd.Parameters.AddWithValue("@apellidoM", Usu.apellidoM);
                cmd.Parameters.AddWithValue("@edad", Usu.edad);
                //cmd.Parameters.AddWithValue("@sexo", Usu.sexo);
                cmd.Parameters.AddWithValue("@cargo", Usu.cargo);
                cmd.Parameters.AddWithValue("@telefono", Usu.telefono);
                cmd.Parameters.AddWithValue("@correo", Usu.correo);
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
        }


        //Eliminar
        public Boolean DeshabilitaUsuario(int idUsuario)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_deshabilitarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
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
        public List<entUsuario> BuscarUsuario(int idUsuario)
        {
            SqlCommand cmd = null;
            List<entUsuario> lista = new List<entUsuario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_buscarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUsuario Usu = new entUsuario();
                    Usu.idUsuario = Convert.ToInt32(dr["idUsuario"]);
                    Usu.contrasena = dr["contrasena"].ToString();
                    Usu.dni = Convert.ToInt32(dr["dni"]);
                    Usu.nombre = dr["nombre"].ToString();
                    Usu.apellidoP = dr["apellidoP"].ToString();
                    Usu.apellidoM = dr["apellidoM"].ToString();
                    Usu.edad = Convert.ToInt32(dr["edad"]);
                    Usu.sexo = Convert.ToChar(dr["sexo"]);
                    Usu.cargo = dr["cargo"].ToString();
                    Usu.telefono = Convert.ToInt32(dr["telefono"]);
                    Usu.correo = dr["correo"].ToString();

                    Usu.habilitar = Convert.ToBoolean(dr["habilitar"]);


                    lista.Add(Usu);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }


    }
}

