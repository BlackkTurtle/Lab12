using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strarray=Console.ReadLine().Split(' ');
            Console.WriteLine(String.Join(" ", strarray.Reverse()));
            Console.ReadLine();
        }
    }
}
