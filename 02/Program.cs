using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            if (str.Length > 20)
            {
                Console.WriteLine(str.Substring(0,20));
            }
            else
            {
                var n=20-str.Length;
                for (int i = 0; i < n; i++)
                {
                    str += "+";
                }
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
