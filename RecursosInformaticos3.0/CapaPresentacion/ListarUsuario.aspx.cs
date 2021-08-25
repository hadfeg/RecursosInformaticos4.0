using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogicaNegocio;
using System.Web.Services;
using System.Web.Script.Serialization;

namespace CapaPresentacion
{
    public partial class ListarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> Lista = null;
            try
            {
                Lista = UsuarioLN.getInstance().ListarUsuarios();
            }
            catch (Exception ex)
            {
                Lista = new List<Usuario>();
            }
            return Lista;
        }

        [WebMethod]
        public static bool ActualizarDatosUsuario(String id, String direccion)
        {
            Usuario objUsuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(id),
                Direccion = direccion
            };

            bool ok = UsuarioLN.getInstance().Actualizar(objPaciente);
            return ok;
        }

        [WebMethod]
        public static bool EliminarDatosPaciente(String id)
        {
            Int32 idPaciente = Convert.ToInt32(id);

            bool ok = PacienteLN.getInstance().Eliminar(idPaciente);

            return ok;

        }     
        
    }
}