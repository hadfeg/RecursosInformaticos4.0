using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Empresa
    {
        public int idEmpresa { get; set; }
        public String nombreEmpresa { get; set; }

        public Empresa() { }
        public Empresa(int idEmpresa, string nombreEmpresa)
        {
            this.idEmpresa = idEmpresa;
            this.nombreEmpresa = nombreEmpresa;
        }
    }
}
