using System;
using System.Collections.Generic;

namespace UniLoginBack.Models
{
    public partial class Unitb005UsuarioBase
    {
        public long CoPessoa { get; set; }
        public int CoBase { get; set; }

        public Unitb004Base CoBaseNavigation { get; set; }
        public Unitb001Usuario CoPessoaNavigation { get; set; }
    }
}
