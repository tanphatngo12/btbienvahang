using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ho ten: ");
            string hoten = Console.ReadLine();
            Console.WriteLine("Nhap lop: ");
            string lop = Console.ReadLine();
            Console.WriteLine("Nhap diem trung binh HK1");
            float dtbhk1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem trung binh HK2");
            float dtbhk2 = float.Parse(Console.ReadLine());
            float dtbcanam = (float)(dtbhk1 + dtbhk2 * 2) / 3;
            Console.WriteLine("Diem trung binh ca nam cua {0} la {1}",hoten, dtbcanam);
            Console.ReadLine();
        }
    }
}
