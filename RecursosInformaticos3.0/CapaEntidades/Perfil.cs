using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Perfil
    {
        public int IdPerfil { get; set; }
        public String Descripcion { get; set; }
        public bool Estado { get; set; }

        public Perfil()
        {
        }

        public Perfil(int ID, String Descripcion, bool Estado)
        {
            this.IdPerfil = IdPerfil;
            this.Descripcion = Descripcion;
            this.Estado = Estado;
        }
    }
}
