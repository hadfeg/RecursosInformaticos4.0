using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    class DepartamentoDAO
    {
        #region "PATRON SINGLETON"
        private static DepartamentoDAO daoDepartamento = null;
        private DepartamentoDAO() { }
        public static DepartamentoDAO getInstance()
        {
            if (daoDepartamento == null)
            {
                daoDepartamento = new DepartamentoDAO();
            }
            return daoDepartamento;
        }
        #endregion

        public bool RegistrarDepartamento(Departamento objDepartamento)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spRegistrarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser", objDepartamento.User);
                cmd.Parameters.AddWithValue("@prmPass", objDepartamento.Pass);
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
    }
}
