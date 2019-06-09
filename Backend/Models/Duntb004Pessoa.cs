using System;
using System.Collections.Generic;

namespace UniLoginBack.Models
{
    public partial class Duntb004Pessoa
    {
        public Duntb004Pessoa()
        {
            Igetb005Folha = new HashSet<Igetb005Folha>();
        }

        public long CoPessoa { get; set; }
        public long CoFamilia { get; set; }
        public DateTime? DtCadastramento { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public byte CoEstadoCadastro { get; set; }
        public bool? IcTrabalhoInfantil { get; set; }
        public byte NuOrdem { get; set; }
        public string NoPessoa { get; set; }
        public string CoNis { get; set; }
        public bool? IcSexo { get; set; }
        public DateTime? DtNascimento { get; set; }
        public byte? CoParentesco { get; set; }
        public byte? CoRaca { get; set; }
        public string CoIbgeNascimento { get; set; }
        public string CoNisOriginal { get; set; }
        public string NoMae { get; set; }
        public string NoPai { get; set; }
        public byte? CoCertidaoRegistrada { get; set; }
        public short? CoPaisOrigem { get; set; }

        public Duntb001Familia CoFamiliaNavigation { get; set; }
        public Isotb001Nis CoPessoaNavigation { get; set; }
        public ICollection<Igetb005Folha> Igetb005Folha { get; set; }
    }
}
