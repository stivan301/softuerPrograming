using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            Diskriminanta d = new Diskriminanta();
           double disk= d.D(a, b, c);
            double x1 = (-b - Math.Sqrt(disk)) / 2 * a;
            double x2= (-b + Math.Sqrt(disk)) / 2 * a;
            Console.WriteLine($"x1={x1:f2} x2={x2:f2}");
        }

    }
}
