using System;
using System.Collections.Generic;

namespace UniLoginBack.Models
{
    public partial class Unitb004Base
    {
        public Unitb004Base()
        {
            Unitb005UsuarioBase = new HashSet<Unitb005UsuarioBase>();
        }

        public int CoBase { get; set; }
        public string NoBase { get; set; }

        public ICollection<Unitb005UsuarioBase> Unitb005UsuarioBase { get; set; }
    }
}
