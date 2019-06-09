using System;
using System.Collections.Generic;

namespace UniLoginBack.Models
{
    public partial class Unitb006Produto
    {
        public Unitb006Produto()
        {
            Unitb007UsuarioProduto = new HashSet<Unitb007UsuarioProduto>();
        }

        public int CoProduto { get; set; }
        public string NoProduto { get; set; }

        public ICollection<Unitb007UsuarioProduto> Unitb007UsuarioProduto { get; set; }
    }
}
