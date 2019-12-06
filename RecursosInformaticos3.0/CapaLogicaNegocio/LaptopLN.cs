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
    public class LaptopLN
    {
        #region "PATRON SINGLETON"
        private static LaptopLN objLaptop = null;
        private LaptopLN() { }
        public static LaptopLN getInstance()
        {
            if (objLaptop == null)
            {
                objLaptop = new LaptopLN();
            }
            return objLaptop;
        }
        #endregion
        public bool RegistrarLaptop(Laptop objLaptop)
        {
            try
            {
                return LaptopDAO.getInstance().RegistrarLaptop(objLaptop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
