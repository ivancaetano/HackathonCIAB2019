using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniLoginBack.Models.DTO
{
    class RespostaFaceDTO
    {
        public bool isIdentical { get; set; }
        public double confidence { get; set; }
    }
}
