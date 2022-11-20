using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            var result =new string(charArray);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
