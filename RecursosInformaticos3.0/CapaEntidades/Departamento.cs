using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Departamento
    {
        public int idDepartamento { get; set;}
        public String nombreDepartamento { get; set;}

        public Departamento() { }
        public Departamento(int idDepartamento, string nombreDepartamento)
        {
            this.idDepartamento = idDepartamento;
            this.nombreDepartamento = nombreDepartamento;
        }
    }
}
