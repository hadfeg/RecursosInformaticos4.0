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
    class EmpresaDAO
    {
        #region "PATRON SINGLETON"
        private static EmpresaDAO daoEmpresa = null;
        private EmpresaDAO() { }
        public static EmpresaDAO getInstance()
        {
            if (daoEmpresa == null)
            {
                daoEmpresa = new EmpresaDAO();
            }
            return daoEmpresa;
        }
        #endregion

        public bool RegistrarEmpresa(Empresa objEmpresa)
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
        
        public DataSet ConsultarEmpresa(String strSQL)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();
            try
            {
                con = Conexion.getInstance().ConexionBD();
                con.Open();
                cmd = new SqlCommand(strSQL, con);
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

    }
}
