using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            string pattern = @"(?<=[\w]{0})[\w-\._\+%]*(?=[\w]{0}@)";
            string result = Regex.Replace(str, pattern, i => new string('*', i.Length));
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
