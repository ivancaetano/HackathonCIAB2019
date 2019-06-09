using System;
using System.Collections.Generic;

namespace UniLoginBack.Models
{
    public partial class Unitb002LogUsuario
    {
        public long CoLog { get; set; }
        public DateTime DhAcesso { get; set; }
        public long CoPessoa { get; set; }
        public int CoClient { get; set; }
        public bool IcSucesso { get; set; }
        public string TxPerguntas { get; set; }
        public string TxRespostas { get; set; }

        public Unitb003Client CoClientNavigation { get; set; }
        public Unitb001Usuario CoPessoaNavigation { get; set; }
    }
}
