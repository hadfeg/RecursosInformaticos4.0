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
    public class LaptopDAO
    {
        #region "PATRON SINGLETON"
        private static LaptopDAO objLaptop = null;
        private LaptopDAO() { }
        public static LaptopDAO getInstance()
        {
            if (objLaptop == null)
            {
                objLaptop = new LaptopDAO();
            }
            return objLaptop;
        }
        #endregion

        public bool RegistrarLaptop(Laptop objLaptop)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spRegistrarLaptop", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmSerie", objLaptop.Serie);
                cmd.Parameters.AddWithValue("@prmMac", objLaptop.MAC);
                cmd.Parameters.AddWithValue("@prmMarca", objLaptop.Marca);
                cmd.Parameters.AddWithValue("@prmModelo", objLaptop.Modelo);
                cmd.Parameters.AddWithValue("@prmNombre", objLaptop.NombreLaptop);
                cmd.Parameters.AddWithValue("@prmFechaCompra", objLaptop.FechaCompra);
                cmd.Parameters.AddWithValue("@prmFechaEntrega", objLaptop.FechaEntrega);
                cmd.Parameters.AddWithValue("@prmFechaUltimaMantencion", objLaptop.FechaUltimaMantencion);
                cmd.Parameters.AddWithValue("@prmTeamViewerID", objLaptop.IDTeamviewer);
                cmd.Parameters.AddWithValue("@prmProcesador", objLaptop.Procesador);
                cmd.Parameters.AddWithValue("@prmTeamviewer", objLaptop.IDTeamviewer);
                cmd.Parameters.AddWithValue("@prmRam", objLaptop.Ram);
                cmd.Parameters.AddWithValue("@prmHDD", objLaptop.HDD);
                cmd.Parameters.AddWithValue("@prmComentario", objLaptop.Comentario);
                cmd.Parameters.AddWithValue("@prmEstado", objLaptop.Estado);
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
