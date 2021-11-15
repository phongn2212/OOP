using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Remove '*' in links
/// Link word theo doi cac mo hinh quan he da xong
/// https://docs.google.com*****/document/d/1o0aLr9lId_d-3c38bLvENN2rfCJo_ggA6UTrBrxJf4c/edit
/// link bai goc
/// http://dulieu.tailieuhoctap.vn*****/books/luan-van-de-tai/luan-van-de-tai-cd-dh/file_goc_784431.pdf
/// </summary>

namespace Library_Management
{
    class Program
    {
        // khai bao danh sach cac thuc the
        public static List<TIENTE> dsTienTe = new List<TIENTE>();
        public static List<KHACHHANG> dsKH = new List<KHACHHANG>();
        public static List<QUOCGIA> dsQG = new List<QUOCGIA>();

        public static void TaoDSQuocGia()
        {
            dsQG.Add(new QUOCGIA("QG01","Nhat Ban"));
            dsQG.Add(new QUOCGIA("QG02", "Viet Nam"));
            dsQG.Add(new QUOCGIA("QG03", "Phap"));
            dsQG.Add(new QUOCGIA("QG04", "Campuchia"));
            dsQG.Add(new QUOCGIA("QG05", "Bo Dao Nha"));
            dsQG.Add(new QUOCGIA("QG06", "A rap xe ut"));

        }

        public static void TaoDSTienTe()
        {
            // 5 loai tien te ( 0 -> 4 )
            dsTienTe.Add(new TIENTE("TT01", "Dollar", 22, "15-11-2020"));
            dsTienTe.Add(new TIENTE("TT02", "Euro", 25, "13-11-2018"));
            dsTienTe.Add(new TIENTE("TT03", "Ruppee", 15, "25-1-2021"));
            dsTienTe.Add(new TIENTE("TT04", "Nhan Dan Te", 5, "19-7-2019"));
            dsTienTe.Add(new TIENTE("TT05", "Bang Anh", 19, "17-4-2020"));
            
        }

        public static void TaoDSKhachHang()
        {
            // tao thong tin khach hang
            dsKH.Add(new KHACHHANG("KH01", "Quoc Phong", "56789", "22-01-2002", "Nam", "HCM", 03486725, new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH02", "Tuan Kiet", "12345", "24-08-2003", "Nam", "London", 03497264, new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH03", "Amee", "34867", "25-08-2002", "Nu", "Ha Noi", 02487913, new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH04", "Ngoc Trinh", "56789", "22-05-2000", "Nu", "Long An", 034826751, new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH05", "Gia Bao", "34821", "27-07-1999", "Nam", "Cu Chi", 09123487, new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH06", "Quoc Phong", "31846", "2-04-2001", "Nam", "Truong Sa", 08348367, new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH07", "Bich Phuong", "27915", "15-11-1986", "Nam", "Hoang Sa", 01784528, new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH08", "Quoc Phong", "91872", "9-12-1995", "Nam", "Tay Bac", 06172308, new List<TIENTE>(), new List<QUOCGIA>()));

            // them cac loai tien te ma khach hang su dung
            dsKH[0].tienTeSuDung.Add(dsTienTe[0]);
            dsKH[0].tienTeSuDung.Add(dsTienTe[4]);

            dsKH[1].tienTeSuDung.Add(dsTienTe[2]);

            dsKH[2].tienTeSuDung.Add(dsTienTe[1]);

            dsKH[3].tienTeSuDung.Add(dsTienTe[0]);
            dsKH[3].tienTeSuDung.Add(dsTienTe[3]);

            dsKH[4].tienTeSuDung.Add(dsTienTe[4]);
            dsKH[4].tienTeSuDung.Add(dsTienTe[3]);

            dsKH[5].tienTeSuDung.Add(dsTienTe[3]);

            dsKH[6].tienTeSuDung.Add(dsTienTe[1]);
            dsKH[6].tienTeSuDung.Add(dsTienTe[3]);

            dsKH[7].tienTeSuDung.Add(dsTienTe[0]);
            dsKH[7].tienTeSuDung.Add(dsTienTe[2]);

            // them Quoc Tich 

            dsKH[0].dsQuocTich.Add(dsQG[0]);
            dsKH[0].dsQuocTich.Add(dsQG[2]);

            dsKH[1].dsQuocTich.Add(dsQG[1]);

            dsKH[2].dsQuocTich.Add(dsQG[4]);
            dsKH[2].dsQuocTich.Add(dsQG[0]);

            dsKH[3].dsQuocTich.Add(dsQG[5]);

            dsKH[4].dsQuocTich.Add(dsQG[2]);
            dsKH[4].dsQuocTich.Add(dsQG[4]);

            dsKH[5].dsQuocTich.Add(dsQG[0]);

            dsKH[6].dsQuocTich.Add(dsQG[3]);
            dsKH[6].dsQuocTich.Add(dsQG[5]);

            dsKH[7].dsQuocTich.Add(dsQG[4]);

        }

        public static void Linq01()
        {
            // lambda
            var dsnhom = dsTienTe.Select(nt => nt);
            foreach (var nhom in dsKH)
            {
                Console.WriteLine("{0} {1} ",nhom.hoTen,nhom.thanhPho);
                Console.WriteLine("Tien te su dung: ");

                foreach (var tt in nhom.tienTeSuDung)
                    Console.WriteLine("{0} {1}", tt.idTienTe, tt.tenTienTe);

                Console.WriteLine("Quoc tich: ");
                foreach (var tt in nhom.dsQuocTich)
                    Console.WriteLine("{0} {1}", tt.idQG, tt.tenNuoc);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            TaoDSQuocGia();
            TaoDSTienTe();
            TaoDSKhachHang();
            Linq01();

            Console.ReadKey();

        }
    }
}
