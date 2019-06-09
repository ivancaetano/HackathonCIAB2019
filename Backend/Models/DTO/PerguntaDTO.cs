using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniLoginBack.Models.DTO
{
    public class PerguntaDTO
    {
        public string noTipo { get; set; }
        public string deEnunciado { get; set; }
        public string deResposta { get; set; }
        public List<OpcaoDTO> lsOpcoes { get; set; }
        public bool icValido { get; set; }
        public PerguntaDTO()
        {
            lsOpcoes = new List<OpcaoDTO>();
        }
    }
}
