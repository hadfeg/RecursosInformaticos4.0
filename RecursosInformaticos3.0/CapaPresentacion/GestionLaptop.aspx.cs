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
    public partial class GestionarLaptop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Laptop objLaptop = new Laptop();
            objLaptop = this.GetEntity();
            bool response = LaptopLN.getInstance().RegistrarLaptop(objLaptop);

            if (response == true)
            {
                Response.Write("<script>alert('REGISTRO CORRECTO.')</script>");
            }
            else
            {
                Response.Write("<script>alert('REGISTRO INCORRECTO.')</script>");
            }
        }

        private Laptop GetEntity() {

            //int NivelAcceso = Convert.ToInt32(rbNivelAcceso.SelectedValue);
            Laptop objLaptop = new Laptop();

            objLaptop.Serie = txtSerie.Text;
            objLaptop.Marca = txtMarca.Text;
            objLaptop.Modelo = txtModelo.Text;
            objLaptop.Ram = txtRam.Text;
            objLaptop.NombreLaptop = txtNombreEquipo.Text;
            objLaptop.Procesador = txtProcesador.Text;
            objLaptop.MAC = txtMac.Text;
            objLaptop.IDTeamviewer = Convert.ToInt32(txtTeamViewerID.Text);
            objLaptop.FechaCompra = Convert.ToDateTime(txtFechaCompra.Text);
            objLaptop.FechaEntrega = Convert.ToDateTime(txtFechaEntrega.Text);
            objLaptop.FechaUltimaMantencion = Convert.ToDateTime(txtFechaMantencion.Text);
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
            return objLaptop;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {



        }

    }

}