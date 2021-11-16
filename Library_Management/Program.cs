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
        public static List<BOOKING> dsBooking = new List<BOOKING>();
        public static List<NHANVIEN> dsNhanVien = new List<NHANVIEN>();
        public static List<THUEPHONG> dsHopDong = new List<THUEPHONG>();
        public static List<THANHTOANPHONG> dsHoaDon = new List<THANHTOANPHONG>();

        public static void TaoDSQuocGia()
        {
            dsQG.Add(new QUOCGIA("QG01","Nhat Ban"));
            dsQG.Add(new QUOCGIA("QG02", "Viet Nam"));
            dsQG.Add(new QUOCGIA("QG03", "Phap"));
            dsQG.Add(new QUOCGIA("QG04", "Campuchia"));
            dsQG.Add(new QUOCGIA("QG05", "Bo Dao Nha"));
            dsQG.Add(new QUOCGIA("QG06", "A rap xe ut"));

        }

        public static void TaoDSBooking()
        {
            dsBooking.Add(new BOOKING("BK01",dsKH[0] ,"11/15/2021", "11/15/2021", 100, dsNhanVien[0]));
            dsBooking.Add(new BOOKING("BK02",dsKH[1], "10/20/2021", "11/15/2021", 150, dsNhanVien[0]));
            dsBooking.Add(new BOOKING("BK03",dsKH[2], "10/19/2021", "11/14/2021", 70, dsNhanVien[1]));
            dsBooking.Add(new BOOKING("BK04",dsKH[3], "10/18/2021", "11/13/2021", 80 , dsNhanVien[1]));
            dsBooking.Add(new BOOKING("BK05",dsKH[4], "10/17/2021", "11/12/2021", 90, dsNhanVien[2]));

            dsNhanVien[0].dsBooking.Add(dsBooking[0]);
            dsNhanVien[0].dsBooking.Add(dsBooking[1]);
            dsNhanVien[1].dsBooking.Add(dsBooking[2]);
            dsNhanVien[1].dsBooking.Add(dsBooking[3]);
            dsNhanVien[2].dsBooking.Add(dsBooking[4]);
            



        }

        public static  void TaoDSHopDong()
        {
            dsHopDong.Add(new THUEPHONG("HD01", "NV01", "A100", "11/15/2021", "11/22/2021"));
            dsHopDong.Add(new THUEPHONG("HD02", "NV01", "A101", "11/15/2021", "11/17/2021"));
            dsHopDong.Add(new THUEPHONG("HD03", "NV02", "A102", "11/14/2021", "11/16/2021"));
            dsHopDong.Add(new THUEPHONG("HD04", "NV02", "A103", "11/13/2021", "11/15/2021"));
            dsHopDong.Add(new THUEPHONG("HD05", "NV03", "A104", "11/12/2021", "11/14/2021"));

            dsNhanVien[0].dsHopDong.Add(dsHopDong[0]);
            dsNhanVien[0].dsHopDong.Add(dsHopDong[1]);
            dsNhanVien[1].dsHopDong.Add(dsHopDong[2]);
            dsNhanVien[1].dsHopDong.Add(dsHopDong[3]);
            dsNhanVien[2].dsHopDong.Add(dsHopDong[4]);

        }

        public static void TaoDSHoaDon()
        {
            dsHoaDon.Add(new THANHTOANPHONG("TT01", "HD01", "11/15/2021", 800, 40));
            dsHoaDon.Add(new THANHTOANPHONG("TT02", "HD02", "11/15/2021", 200, 50));
            dsHoaDon.Add(new THANHTOANPHONG("TT03", "HD03", "11/14/2021", 210, 50));
            dsHoaDon.Add(new THANHTOANPHONG("TT04", "HD04", "11/14/2021", 220, 60));
            dsHoaDon.Add(new THANHTOANPHONG("TT05", "HD05", "11/11/2021", 230, 60));

            dsNhanVien[0].dsHoaDon.Add(dsHoaDon[0]);
            dsNhanVien[0].dsHoaDon.Add(dsHoaDon[1]);
            dsNhanVien[1].dsHoaDon.Add(dsHoaDon[2]);
            dsNhanVien[1].dsHoaDon.Add(dsHoaDon[3]);
            dsNhanVien[2].dsHoaDon.Add(dsHoaDon[4]);
        }


        public static void TaoDSNhanVien()
        {
            dsNhanVien.Add(new NHANVIEN("NV01", "Chan Hung", "01/01/2002", "Nam", "Thu Duc", "0818180226", "Tiep Tan", 200, "chanhung@123", new List<BOOKING>(), new List<THUEPHONG>(), new List<THANHTOANPHONG>()));
            dsNhanVien.Add(new NHANVIEN("NV02", "Nhat Anh", "02/01/2002", "Nam", "Thu Duc", "0818180225", "Tiep Tan", 210, "nhatanh@123", new List<BOOKING>(), new List<THUEPHONG>(), new List<THANHTOANPHONG>()));
            dsNhanVien.Add(new NHANVIEN("NV03", "Van Hien", "03/01/2002", "Nam", "Dak Lak", "0818180224", "Tiep Tan", 220, "vanhien@123", new List<BOOKING>(), new List<THUEPHONG>(), new List<THANHTOANPHONG>()));
            dsNhanVien.Add(new NHANVIEN("NV04", "Thanh Dien", "04/01/2002", "Nam", "Sa Dec", "0818180223", "Tiep Tan", 230, "thanhdien@123", new List<BOOKING>(), new List<THUEPHONG>(), new List<THANHTOANPHONG>()));
            dsNhanVien.Add(new NHANVIEN("NV05", "Chan Hung", "05/01/2002", "Nam", "HCM", "0818180222", "Tiep Tan", 240, "sieutran@123", new List<BOOKING>(), new List<THUEPHONG>(), new List<THANHTOANPHONG>()));

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
            dsKH.Add(new KHACHHANG("KH01", "Quoc Phong", "56789", "01/22/2002", "Nam", "HCM", "03486725", new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH02", "Tuan Kiet", "12345", "08/24/2003", "Nam", "London", "03497264", new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH03", "Amee", "34867", "08/25/2002", "Nu", "Ha Noi", "02487913", new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH04", "Ngoc Trinh", "56788", "05/22/2000", "Nu", "Long An", "034826751", new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH05", "Gia Bao", "34821", "07/23/1999", "Nam", "Cu Chi", "09123487", new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH06", "Quoc Phong", "31846", "04/02/2001", "Nam", "Truong Sa", "08348367", new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH07", "Bich Phuong", "27915", "11/15/1986", "Nam", "Hoang Sa", "01784528", new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH08", "Quoc Phong", "91872", "12/09/1995", "Nam", "Tay Bac", "06172308", new List<TIENTE>(), new List<QUOCGIA>()));
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

        //Lay ra danh sach booking theo tung nhan vien
        public static void Linq02()
        {
            var bookingGroups =
                from b in dsBooking
                group b by b.nv.idNV into newBooking
                select new { NhanVien = newBooking.Key, Bookings = newBooking };
           
            foreach(var g in bookingGroups)
            {
                Console.WriteLine("Nhung booking thuc hien boi: {0} ", g.NhanVien);
                foreach(var b in g.Bookings)
                {
                    Console.WriteLine("Ma Booking: {0} \t Ho ten khach hang: {1} \t Thanh Pho: {2}",b.idBooking, b.kh.hoTen, b.kh.thanhPho);
                }
                Console.WriteLine("\n");
            }
        }

        //Chon ra danh sach ca hop dong o khong qua 2 ngay
        public static void Linq03()
        {
            var hopDongs =
                from h in dsHopDong
                where Convert.ToDateTime(h.ngayDangKyTra).Day - Convert.ToDateTime(h.ngayThue).Day <= 2
                select h;

            Console.WriteLine("\nNhung hop dong co thoi gian thue khong qua 2 ngay");
            
            foreach(var h in hopDongs)
            {
                Console.WriteLine("Hop Dong: {0} - Nhan Vien: {1} - Ma Phong: {2} - Ngay thue {3} - Ngay Tra {4}",
                    h.idHopDongTP, h.idNhanVien, h.maPhong, h.ngayThue, h.ngayDangKyTra);            }

        }

        //In ra tong so tien duoc tips cua moi nhan vien
        public static void Linq04()
        {
            var tipsHopDong =
              from hoadon in dsHoaDon
              from hopdong in dsHopDong
              where hoadon.idHopDongTP == hopdong.idHopDongTP
              select new { idNhanVien = hopdong.idNhanVien, idHopDongTP = hopdong.idHopDongTP, tienDichVu = hoadon.tienDichVu };
            var tipsNhanVien =
                 from nhanvien in dsNhanVien
                 from hopdong in tipsHopDong
                 where hopdong.idNhanVien == nhanvien.idNV
                 select new { idNV = nhanvien.idNV, tienDichVu = hopdong.tienDichVu };
           var groupingNhanVien =
                from nv in tipsNhanVien
                group nv by nv.idNV into newNV
                select new { NhanVien = newNV.Key, TongTips = newNV.Sum(nv => nv.tienDichVu) };

            Console.WriteLine("\nTong so tien duoc tips cua moi nhan vien");

                foreach(var g in groupingNhanVien)
                { 
                Console.WriteLine("Nhan Vien {0} - Tong tips: {1}", g.NhanVien, g.TongTips);
                }



        }

        static void Main(string[] args)
        {
            //Tạo các danh sách
            TaoDSQuocGia();
            TaoDSTienTe();
            TaoDSNhanVien();
            TaoDSKhachHang();
            TaoDSBooking();
            TaoDSHopDong();
            TaoDSHoaDon();
          


            Linq01();



            Linq02();
            Linq03();
            Linq04();


            Console.ReadKey();

        }
    }
}
