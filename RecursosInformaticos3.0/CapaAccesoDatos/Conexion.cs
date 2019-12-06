using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    class Conexion
    {
        #region "PATRON SINGLETON"
        private static Conexion conexion = null;
        private Conexion() { }
        public static Conexion getInstance()
        {
            if (conexion == null)
            {
                conexion = new Conexion();
            }
            return conexion;
        }
        #endregion
        public SqlConnection ConexionBD()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source= 192.168.6.170; Initial Catalog=BD-RECURSOSTI; User ID=sa; Password=3192yahima; MultipleActiveResultSets = True";
            //conexion.ConnectionString = @"Data Source= DESKTOP-AN7T78K; Initial Catalog=BD-RECURSOSTI; User ID=sa; Password=chirino123; MultipleActiveResultSets = True";            
            return conexion;
        }

    }
}
