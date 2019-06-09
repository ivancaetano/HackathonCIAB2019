using System;
using System.Collections.Generic;

namespace UniLoginBack.Models
{
    public partial class Raitb013DadosRais
    {
        public long CoPessoa { get; set; }
        public byte? CoTipoVinculoRais { get; set; }
        public string CoCboRais { get; set; }
        public DateTime DtAdmissaoRais { get; set; }
        public byte? CoTipoAdmissao { get; set; }
        public DateTime? DtDesligamentoRais { get; set; }
        public byte? CoCausaDesligamento { get; set; }
        public byte? CoTipoSituacaoNis { get; set; }
        public byte? CoUtilizacaoApoio { get; set; }
        public decimal VrSalarioContratado { get; set; }
        public int? CoArquivoRais { get; set; }
        public string CoNisInf { get; set; }
        public string CoNis { get; set; }
        public string NoCidadao { get; set; }
        public DateTime DtNacimentoCidadao { get; set; }
        public string NuCtps { get; set; }
        public string NuSerieCtps { get; set; }
        public string CoCpf { get; set; }
        public byte CoTipoInscricao { get; set; }
        public string CoInscricaoEmpresa { get; set; }
        public string CoCeiVinculado { get; set; }
        public string CoTipoNaturezaJuridica { get; set; }
        public decimal? VrRemuneracaoJan { get; set; }
        public decimal? VrRemuneracaoFev { get; set; }
        public decimal? VrRemuneracaoMar { get; set; }
        public decimal? VrRemuneracaoAbr { get; set; }
        public decimal? VrRemuneracaoMai { get; set; }
        public decimal? VrRemuneracaoJun { get; set; }
        public decimal? VrRemuneracaoJul { get; set; }
        public decimal? VrRemuneracaoAgo { get; set; }
        public decimal? VrRemuneracaoSet { get; set; }
        public decimal? VrRemuneracaoOut { get; set; }
        public decimal? VrRemuneracaoNov { get; set; }
        public decimal? VrRemuneracaoDez { get; set; }

        public Isotb001Nis CoPessoaNavigation { get; set; }
    }
}
