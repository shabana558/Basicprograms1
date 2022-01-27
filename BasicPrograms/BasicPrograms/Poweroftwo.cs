using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Poweroftwo
    {
        public Poweroftwo(string argument)
        {
            Console.WriteLine("Take command-line argument");
            double number = Convert.ToInt32(argument);          // converting string value to int
            Utility utility = new Utility();
            Console.Write("[ ");

            for (int i = 0; i <= number; i++)
            {
                double result = utility.Poweroftwo(i);
                Console.Write(result + " ");
            }

            Console.WriteLine("]");
        }
    }
}