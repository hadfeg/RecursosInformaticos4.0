using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class UsuarioDAO
    {
        #region "PATRON SINGLETON"
        private static UsuarioDAO daoUsuario = null;
        private UsuarioDAO() { }
        public static UsuarioDAO getInstance()
        {
            if (daoUsuario == null)
            {
                daoUsuario = new UsuarioDAO();
            }
            return daoUsuario;
        }
        #endregion
        public Usuario AccesoSistema(String user, String pass)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            Usuario objUsuario = null;
            SqlDataReader dr = null;
            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spAccesoSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser", user);
                cmd.Parameters.AddWithValue("@prmPass", pass);
                conexion.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objUsuario = new Usuario();
                    
                    objUsuario.User = dr["Usuario"].ToString();
                    objUsuario.Pass = dr["Contrasena"].ToString();
                }
            }
            catch (Exception ex)
            {
                objUsuario = null;
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return objUsuario;
        }
        public bool RegistrarUsuario(Usuario objUsuario)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spRegistrarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser", objUsuario.User);
                cmd.Parameters.AddWithValue("@prmPass", objUsuario.Pass);
                cmd.Parameters.AddWithValue("@prmName", objUsuario.Name);
                cmd.Parameters.AddWithValue("@prmLastName", objUsuario.LastName);
                cmd.Parameters.AddWithValue("@prmRol", objUsuario.Rol);
                cmd.Parameters.AddWithValue("@prmEmail", objUsuario.Mail);
                cmd.Parameters.AddWithValue("@prmState", objUsuario.Estado);
                cmd.Parameters.AddWithValue("@prmRut", objUsuario.Rut);
                con.Open();

                int filas = cmd.ExecuteNonQuery();
                if (filas > 0) response = true;

            }
            catch (Exception ex)
            {
                response = false;
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return response;
        }

        public DataSet ListarPerfil()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            DataSet ds = null;
            SqlDataAdapter da = null;
            string sql = "SELECT * FROM Perfil";
            try
            {
                con = Conexion.getInstance().ConexionBD();
                con.Open();
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> Lista = new List<Usuario>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spListarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // Crear objetos de tipo Usuario
                    Usuario objUsuario = new Usuario();
                    objUsuario.Rut = dr["Rut"].ToString();
                    objUsuario.Name = dr["Nombre"].ToString();
                    objUsuario.LastName = dr["Apellido"].ToString();
                    objUsuario.Mail = dr["Email"].ToString();
                    objUsuario.Rol = Convert.ToInt32(dr["Rol"].ToString());
                    objUsuario.Pass = dr["Contraseña"].ToString();
                    objUsuario.User = dr["Usuario"].ToString();
                    //objPerfil.Descripcion= dr["Descripcion"].ToString();

                    // añadir a la lista de objetos
                    Lista.Add(objUsuario);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return Lista;
        }

    }

}
