using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str=Console.ReadLine();
            var uri = new Uri(str);
            Console.WriteLine(uri.Scheme);
            Console.WriteLine(uri.Host);
            Console.WriteLine(uri.LocalPath);
            Console.ReadLine();
        }
    }
}
