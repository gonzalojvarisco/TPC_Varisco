using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario1
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Pass { get; set; }
        public PerfilUsuario Perfil { get; set; }
    }
}
