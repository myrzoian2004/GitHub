using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            Console.WriteLine(n1 + "\n" + n2);
            for (int i = 0; i < 38; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.WriteLine(n3);
            }
            Console.ReadLine();
        }
    }
}
