using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniLoginBack.Models.DTO
{
    public class ListaPerguntasDTO
    {
        public long coLog { get; set; }
        public List<PerguntaDTO> lsPerguntas { get; set; }
        public ListaPerguntasDTO()
        {
            lsPerguntas = new List<PerguntaDTO>();
        }
    }
}
