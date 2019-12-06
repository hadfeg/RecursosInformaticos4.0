using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["UserSessionId"] = null;
        }

        protected void Login_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool Autenticado = false;
            Autenticado = LoginCorrecto(Login1.UserName, Login1.Password);
            e.Authenticated = Autenticado;
            if (Autenticado)
            {
                Response.Redirect("PanelGeneral.aspx");
            }
            else
            {
                Response.Write("<script>alert('Usuarios Incorrecto')</script>");
            }
        }
        private bool LoginCorrecto(string Usuario, string Contrasena)
        {
             Usuario objUsuario = UsuarioLN.getInstance().AccesoSistema(Login1.UserName, Login1.Password);
             if (objUsuario != null)
             {
                 return true;
                // Response.Write("<script>alert('Usuarios Correcto')</script>");
             }
             else
             {
                 return false;
                // Response.Write("<script>alert('Usuarios Incorrecto')</script>");
             } 
           
        }        
    }
}