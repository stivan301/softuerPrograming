using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Prodict product = new Prodict(1, "Test product", 100.01m, 100, new DateTime(2019, 06, 30));
            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine("Single product object");
            Console.WriteLine(json);
            Console.WriteLine(new string('-',50));
        }
    }
}
