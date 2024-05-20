using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandler
{
    internal class Esercizio1
    {
        public static bool WrongNumber = false;
        public double Calculate(double n1, double n2)
        {
            double output = -1;
            if (n2 != 0)
            {
                double result = n1 / n2;
                output = result;
            }
            else
            {
                if(output == -1)
                {
                    WrongNumber = true;
                }
                else
                {
                    WrongNumber = false;
                }
                //Console.WriteLine("Error: Can't devide by 0");
            }
            return output;
        }

    }
}
