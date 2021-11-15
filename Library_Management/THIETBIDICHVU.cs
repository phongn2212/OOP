using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class THIETBIDICHVU
    {
        public string idThietBi { get; set; }
        public string tenThietBi { get; set; }
        public int giaTien { get; set; }

        public THIETBIDICHVU (THIETBIDICHVU dv)
        {
            this.idThietBi = dv.idThietBi;
            this.tenThietBi = dv.tenThietBi;
            this.giaTien = dv.giaTien;
        }

        public THIETBIDICHVU(string idThietBi, string tenThietBi, int giaTien)
        {
            this.idThietBi = idThietBi;
            this.tenThietBi = tenThietBi;
            this.giaTien = giaTien;
        }
    }
}
