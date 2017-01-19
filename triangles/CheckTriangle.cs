using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProgram
{
    class CheckTriangle
    {
        public void check(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide == 0 || secondSide == 0 || thirdSide == 0)
            {
                Console.Write("triangle does not exist");
                Console.ReadKey();
                return;
            }
            if (firstSide == secondSide && secondSide == thirdSide)
            {
                Console.Write("triangle is ravnostoronn");
                Console.ReadKey();
            }
            else if (firstSide == secondSide || secondSide == thirdSide || firstSide == thirdSide)
            {
                Console.Write("triangle is ravnobed");
                Console.ReadKey();
            }
            else
            {
                Console.Write("triangle is usually");
                Console.ReadKey();
            }
        }
    }
}
