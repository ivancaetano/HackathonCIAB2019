using System;
using System.Collections.Generic;

namespace UniLoginBack.Models
{
    public partial class Duntb001Familia
    {
        public Duntb001Familia()
        {
            Duntb004Pessoa = new HashSet<Duntb004Pessoa>();
        }

        public long CoFamilia { get; set; }
        public long CoPrefeitura { get; set; }
        public DateTime DtCadastramento { get; set; }
        public DateTime DtAlteracao { get; set; }
        public byte CoEstadoCadastro { get; set; }
        public byte CoCadastroValido { get; set; }
        public byte CoCondicaoCadastro { get; set; }
        public decimal? VrRendaMedia { get; set; }
        public bool? IcTrabalhoInfantil { get; set; }
        public string NoLocalidade { get; set; }
        public short? CoTipoLogradouro { get; set; }
        public string NoTituloLogradouro { get; set; }
        public string NoLogradouro { get; set; }
        public string NuLogradouro { get; set; }
        public string DeComplemento { get; set; }
        public string DeComplementoAdicional { get; set; }
        public string NuCep { get; set; }
        public string CoCpfEntrevistador { get; set; }
        public DateTime? DtLimiteAtualizacao { get; set; }
        public byte CoAlteracaoV7 { get; set; }
        public DateTime DtAtualizacao { get; set; }
        public bool? IcIndigena { get; set; }
        public bool? IcQuilombola { get; set; }
        public byte? QtPessoas { get; set; }
        public byte? QtFamilias { get; set; }
        public string NuDdd1 { get; set; }
        public string NuTelefone1 { get; set; }
        public string NuDdd2 { get; set; }
        public string NuTelefone2 { get; set; }
        public string EdEmail { get; set; }

        public ICollection<Duntb004Pessoa> Duntb004Pessoa { get; set; }
    }
}
