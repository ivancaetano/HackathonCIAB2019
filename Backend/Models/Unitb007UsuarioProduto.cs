using System;
using System.Collections.Generic;

namespace UniLoginBack.Models
{
    public partial class Unitb007UsuarioProduto
    {
        public int CoProduto { get; set; }
        public long CoPessoa { get; set; }
        public DateTime DhCriacao { get; set; }
        public bool? IcAtendido { get; set; }

        public Unitb001Usuario CoPessoaNavigation { get; set; }
        public Unitb006Produto CoProdutoNavigation { get; set; }
    }
}
