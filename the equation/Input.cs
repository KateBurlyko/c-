using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polinom
{
    class Input
    {
        public double input()
        {
            Console.WriteLine("input number");
            double numb = Convert.ToDouble(Console.ReadLine());
            return numb;
        }
    }
}
