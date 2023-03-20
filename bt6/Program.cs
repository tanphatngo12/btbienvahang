using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ngay: ");
            int ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());
            int ngayhomqua = ngay-1;
            int ngaymai = ngay+1;
            Console.WriteLine("<----------------------------------->");
            Console.WriteLine("Ngay hom qua la {0}/{1}/{2}", ngayhomqua, thang, nam);
            Console.WriteLine("Ngay hom nay la {0}/{1}/{2}", ngay, thang, nam);
            Console.WriteLine("Ngay mai la {0}/{1}/{2}", ngaymai, thang, nam);
            Console.WriteLine("<----------------------------------->");
            Console.ReadLine();
        }
    }
}
