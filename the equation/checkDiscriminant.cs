using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace polinom
{
    class checkDiscriminant
    {
        public double diskrim(double firstNumber, double secondNumber, double thirdNumber)
        {
            double diskrim = secondNumber * secondNumber - 4 * firstNumber * thirdNumber;
            //       Console.Write("input number ");
            //    Console.WriteLine(diskrim);
            return diskrim;
        }
    }
}
