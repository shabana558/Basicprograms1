using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Biggest
    {
        public static void biggest()
        {
            int a = 40;
            int b = 25;
            int c = 7;

            Console.WriteLine("The numbers are  a = {0}, b = {1}, c = {2}", a, b, c);
            if ((a > b) && (a > c))
                Console.WriteLine("a = {0} is the biggest number", a);

            else if (b > c)
                Console.WriteLine("b = {0} is the biggest number", b);

            else
                Console.WriteLine("c = {0} is the biggest number", c);
            Console.ReadLine();
        }
    }
}
