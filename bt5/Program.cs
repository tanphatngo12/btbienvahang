using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace bt5
{
    struct ThongTinNhanVien
    {
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public float hesoLuong { get; set; }
        public int luong { get; set; }
        public int sonam { get; set; }
        public int phucap { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ThongTinNhanVien nv1 = new ThongTinNhanVien();
            nv1.hoTen = "Nguyen Van A";
            nv1.gioiTinh = "Nam";
            nv1.ngaySinh = new DateTime(1997, 12, 12);
            nv1.hesoLuong = 2.6f;
            nv1.luong = 7000000;
            nv1.sonam = 3;
            nv1.phucap = 400000;
            ThongTinNhanVien nv2 = new ThongTinNhanVien();
            nv2.hoTen = "Nguyen Thi B";
            nv2.gioiTinh = "Nu";
            nv2.ngaySinh = new DateTime(1990, 5, 2);
            nv2.hesoLuong = 3.2f;
            nv2.luong = 7000000;
            nv2.sonam = 6;
            nv2.phucap = 400000;
            if (nv1.sonam > 5)
            {
                int nv1pc = nv1.luong / 2;
                Console.WriteLine("Thong Tin Nhan Vien 1: {0} {1} {2} {3} {4} {5} {6}", nv1.hoTen, nv1.gioiTinh, nv1.ngaySinh, nv1.hesoLuong, nv1.luong, nv1.sonam, nv1pc);
            }
            else
            {
                Console.WriteLine("Thong Tin Nhan Vien 1: {0} {1} {2} {3} {4} {5} {6}", nv1.hoTen, nv1.gioiTinh, nv1.ngaySinh, nv1.hesoLuong, nv1.luong, nv1.sonam, nv1.phucap);
            }
            if (nv2.sonam > 5)
            {
                int nv2pc = nv2.luong / 2;
                Console.WriteLine("Thong Tin Nhan Vien 2: {0} {1} {2} {3} {4} {5} {6}", nv2.hoTen, nv2.gioiTinh, nv2.ngaySinh, nv2.hesoLuong, nv2.luong, nv2.sonam, nv2pc);
            }
            else
            {
                Console.WriteLine("Thong Tin Nhan Vien 2: {0} {1} {2} {3} {4} {5} {6}", nv2.hoTen, nv2.gioiTinh, nv2.ngaySinh, nv2.hesoLuong, nv2.luong, nv2.sonam, nv2.phucap);
            }
            Console.ReadLine();
        }
    }
}
