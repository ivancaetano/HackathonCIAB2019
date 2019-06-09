using System;
using System.Collections.Generic;

namespace UniLoginBack.Models
{
    public partial class Isotb001Nis
    {
        public string CoNis { get; set; }
        public string NoBeneficiario { get; set; }
        public DateTime? DtNascimento { get; set; }
        public string CoCpf { get; set; }
        public string CoCtps { get; set; }
        public string CoSerieCtps { get; set; }
        public string CoUfCtps { get; set; }
        public DateTime? DtEmissaoCtps { get; set; }
        public int? CoTipoVinculo { get; set; }
        public string NuCnpjCei { get; set; }
        public DateTime? DtAdmissao { get; set; }
        public long CoPessoa { get; set; }

        public Unitb001Usuario CoPessoaNavigation { get; set; }
        public Duntb004Pessoa Duntb004Pessoa { get; set; }
        public Raitb013DadosRais Raitb013DadosRais { get; set; }
    }
}
