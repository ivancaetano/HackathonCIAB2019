using System;
using System.Collections.Generic;

namespace UniLoginBack.Models
{
    public partial class Unitb003Client
    {
        public Unitb003Client()
        {
            Unitb002LogUsuario = new HashSet<Unitb002LogUsuario>();
        }

        public int CoClient { get; set; }
        public string NoClient { get; set; }
        public string EdRedirectUrl { get; set; }

        public ICollection<Unitb002LogUsuario> Unitb002LogUsuario { get; set; }
    }
}
