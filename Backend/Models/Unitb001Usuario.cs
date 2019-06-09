using System;
using System.Collections.Generic;

namespace UniLoginBack.Models
{
    public partial class Unitb001Usuario
    {
        public Unitb001Usuario()
        {
            Unitb002LogUsuario = new HashSet<Unitb002LogUsuario>();
            Unitb005UsuarioBase = new HashSet<Unitb005UsuarioBase>();
            Unitb007UsuarioProduto = new HashSet<Unitb007UsuarioProduto>();
        }

        public long CoPessoa { get; set; }
        public string NoUsuario { get; set; }
        public string CoCpf { get; set; }
        public string TxSenha { get; set; }
        public string EdEmail { get; set; }
        public string ImUsuario { get; set; }
        public string NuTelefone { get; set; }

        public Isotb001Nis Isotb001Nis { get; set; }
        public ICollection<Unitb002LogUsuario> Unitb002LogUsuario { get; set; }
        public ICollection<Unitb005UsuarioBase> Unitb005UsuarioBase { get; set; }
        public ICollection<Unitb007UsuarioProduto> Unitb007UsuarioProduto { get; set; }
    }
}
