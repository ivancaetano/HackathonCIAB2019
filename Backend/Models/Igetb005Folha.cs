using System;
using System.Collections.Generic;

namespace UniLoginBack.Models
{
    public partial class Igetb005Folha
    {
        public long CoPessoa { get; set; }
        public DateTime DtFolha { get; set; }
        public DateTime DtCompetencia { get; set; }
        public string CoProduto { get; set; }
        public string CoIbge { get; set; }
        public decimal VrDisponibilizado { get; set; }
        public int CoSituacao { get; set; }
        public int CoArquivo { get; set; }
        public bool IcInseridoPago { get; set; }
        public string NoResponsavelTitular { get; set; }
        public string CoAutenticacao { get; set; }
        public string NoBeneficiario { get; set; }
        public string CoIbgeMunicipioCadastramento { get; set; }
        public string CoIbgeMunicipioPagamento { get; set; }
        public string CoTipoPagamento { get; set; }

        public Duntb004Pessoa CoPessoaNavigation { get; set; }
    }
}
