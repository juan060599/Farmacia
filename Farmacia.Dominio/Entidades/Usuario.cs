using System;
using System.Collections.Generic;
using System.Text;

namespace Farmacia.Dominio
{
    class Usuario
    {
        public int Id { get; set; }

        public string Email { get; set; }
        public string Senha { get; set; }
        public int Nome { get; set; }
        public int SobreNome { get; set; }
    }
}
