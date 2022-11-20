using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keyword=Console.ReadLine();
            string[] arr = Console.ReadLine().Split('.');
            string answer ="";
            foreach (string sentence in arr)
            {
                string[] words = sentence.Split(new char[] { ' ', ',' });
                if (words.Contains(keyword))
                {
                    answer += sentence;
                }
            }
            Console.WriteLine(answer);
            Console.ReadLine();
            /*Welcome to SoftUni! You will learn programming, algorithms, problem solving and software technologies. You need to allocate for study 20-30 hours weekly. Good luck! I am fan of Motorhead. To be or not to be - that is the question. TO DO OR NOT?*/
        }
    }
}
