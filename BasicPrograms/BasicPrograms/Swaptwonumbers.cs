using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Swaptwonumbers
    {
        public static void SwapingNumbers()
        {
            int firstNum, secondNum, temp = 0;
            Console.WriteLine("please enter first Number");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second Number");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before exchanging values: first={0},second={1}", firstNum, secondNum);
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            Console.WriteLine("After exchanging values:first={0},second={1}", firstNum, secondNum);
        }
    }
}
