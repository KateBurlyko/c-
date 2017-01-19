using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polinom
{
    class Roots
    {
        public void roots(double number1, double number2, double number3)
        {
            checkDiscriminant cd = new checkDiscriminant();
            if (cd.diskrim(number1, number2, number3) < 0)
            {
                Console.WriteLine("not ruts");
                Console.ReadKey();
            }
            else if (cd.diskrim(number1, number2, number3) == 0)
            {
                Console.WriteLine("root1 is " + ((-1 * number2) / (2 * number1)) + "root2 is" + (number2 / (2 * number1)));
                Console.ReadKey();
            }
            else if (cd.diskrim(number1, number2, number3) > 0)
            {
                Console.WriteLine("root1 is " + ((-1 * number2 + Math.Sqrt(cd.diskrim(number1, number2, number3))) / (2 * number1)) +
                    "root2 is" + ((-1 * number2) - Math.Sqrt(cd.diskrim(number1, number2, number3)) / (2 * number1)));
                Console.ReadKey();
            }

        }
    }
}
