using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.WriteLine("Nhap duong kinh: ");
            int dk = int.Parse(Console.ReadLine());
            int bk = dk / 2;
            double dt = (double)(dk * dk) / 4 * pi;
            double cv = (double)dk * pi;
            Console.WriteLine("Ban kinh: " + bk);
            Console.WriteLine("Dien tich:" + dt);
            Console.WriteLine("Chu vi:" + cv);
            Console.ReadLine();
        }
    }
}
