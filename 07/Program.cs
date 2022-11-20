using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            str = new Regex("<upcase>(.*?)</upcase>").Replace(str, ("$1".ToUpper()));
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
