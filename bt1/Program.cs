using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("so a la {0}, so b la {1}", a, b);
            float thuong = (float)a / b;
            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;
            Console.WriteLine("tong la: {0}", tong);
            Console.WriteLine("hieu la: {0}", hieu);
            Console.WriteLine("tich la: {0}", tich);
            Console.WriteLine("thuong la:{0} ", thuong);
            Console.ReadLine();
        }
    }
}
