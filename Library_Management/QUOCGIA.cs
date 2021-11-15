using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class QUOCGIA
    {
        public string idQG { get; set; }
        public string tenNuoc { get; set; }

        public QUOCGIA (QUOCGIA qg)
        {
            this.idQG = qg.idQG;
            this.tenNuoc = qg.tenNuoc;
        }

        public QUOCGIA(string idQG, string tenNuoc)
        {
            this.idQG = idQG;
            this.tenNuoc = tenNuoc;
        }
    }
}
