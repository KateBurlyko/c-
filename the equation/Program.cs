using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polinom
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            double thirdNumber;

            Input inp = new Input();

            try
            {
                firstNumber = inp.input();
                secondNumber = inp.input();
                thirdNumber = inp.input();
                Roots r = new Roots();
                r.roots(firstNumber, secondNumber, thirdNumber);

            }
            catch (FormatException)
            {
                Console.WriteLine("not a number");
                Console.ReadLine(); 
            }
        }
    }
}
