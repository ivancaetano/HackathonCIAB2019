using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniLoginBack.Models.DTO
{
    class FaceDTO
    {
        public string faceId { get; set; }
        public string personId { get; set; }
        public string largePersonGroupId { get; set; }
        public FaceDTO()
        {
            personId = "070aca80-4067-4ebd-b1a9-e9bf9b8e838e";
            largePersonGroupId = "felipe1";
        }
    }
}
