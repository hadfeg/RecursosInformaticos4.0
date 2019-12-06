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
    public partial class GestionUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e) {

            Usuario objUsuario = new Usuario();
            objUsuario = GetEntity();           
            bool rut_valido = validarRut(objUsuario);

            if (rut_valido) {

                bool response = UsuarioLN.getInstance().RegistrarUsuario(objUsuario);

                if (response == true)
                {
                    Response.Write("<script>alert('REGISTRO CORRECTO.')</script>");
                }
                else
                {
                    Response.Write("<script>alert('REGISTRO INCORRECTO.')</script>");
                }
            }else{

                    Response.Write("<script>alert('Rut inválido, por favor intente nuevamente !!!')</script>");

            }
            
        }

        private bool validarRut(Usuario objUser)
        {
            bool validacion = false;
            String rut;
            try
            {
                rut = objUser.Rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;


        }

        private Usuario GetEntity()
        {
            //int NivelAcceso = Convert.ToInt32(rbNivelAcceso.SelectedValue);
            Usuario objUsuario = new Usuario();
            objUsuario.User = txtUsuario.Text;
            objUsuario.Name = txtNombre.Text;
            objUsuario.LastName = txtApellido.Text;
            objUsuario.Rut = txtRut.Text;
            objUsuario.Mail = txtEmail.Text;
            //objUsuario.Rol = Convert.ToInt32(ddlPerfil.SelectedValue);
            //objUsuario.Estado = Convert.ToInt32(ddlEstado.SelectedValue);
            objUsuario.Pass = txtContrasena.Text;

            /**
            if (NivelAcceso == 1)
            {
                objUsuario.Cliente = "TODOS";
                objUsuario.Contrato = "TODOS";
            }
            if (NivelAcceso == 2)
            {
                objUsuario.Cliente = ddlAcceso.SelectedItem.Text;
                objUsuario.Contrato = "0";
            }
            if (NivelAcceso == 3)
            {
                objUsuario.Cliente = "0";
                objUsuario.Contrato = ddlAcceso.SelectedItem.Text;
            }**/
            return objUsuario;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}