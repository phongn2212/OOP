using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class TIENTE
    {
        public string idTienTe { get; set; } // primary key
        public string tenTienTe { get; set; }
        public int doiSangVND { get; set; }
        public string ngayCapNhat { get; set; }

        public TIENTE (TIENTE tt)
        {
            this.idTienTe = tt.idTienTe;
            this.tenTienTe = tt.tenTienTe;
            this.doiSangVND = tt.doiSangVND;
            this.ngayCapNhat = tt.ngayCapNhat;
        }

        public TIENTE (string idTienTe, string tenTienTe, int doiSangVND, string ngayCapNhat)
        {
            this.idTienTe = idTienTe;
            this.tenTienTe = tenTienTe;
            this.doiSangVND = doiSangVND;
            this.ngayCapNhat = ngayCapNhat;
        }


    }
}
