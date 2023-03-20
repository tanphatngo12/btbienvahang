using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu dai: ");
            int cd = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            int cr = int.Parse(Console.ReadLine());
            int cv = (cd + cr) * 2;
            int dt = cd * cr;
            Console.WriteLine("Chu vi hinh chu nhat la: " + cv);
            Console.WriteLine("Dien tich hinh chu nhat la: " + dt);
            Console.ReadLine();
        }
    }
}
