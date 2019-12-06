using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaAccesoDatos;
using System.Data;

namespace CapaLogicaNegocio
{

    public class UsuarioLN
    {
        #region "PATRON SINGLETON"
        private static UsuarioLN lnUsuario = null;
        private UsuarioLN() { }
        public static UsuarioLN getInstance()
        {
            if (lnUsuario == null)
            {
                lnUsuario = new UsuarioLN();
            }
            return lnUsuario;
        }
        #endregion

        public Usuario AccesoSistema(String user, String pass){

            try
            {
                return UsuarioDAO.getInstance().AccesoSistema(user, pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RegistrarUsuario(Usuario objUsuario)
        {
            try
            {
                return UsuarioDAO.getInstance().RegistrarUsuario(objUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataSet ListarPerfil()
        {
            try
            {
                return UsuarioDAO.getInstance().ListarPerfil();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Usuario> ListarUsuarios()
        {
            try
            {
                return UsuarioDAO.getInstance().ListarUsuarios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
