using System;



namespace myFirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {


            InputData inp = new InputData();
            double firstSide = 0;
            double secondSide = 0;
            double thirdSide = 0;

            try
            {
                firstSide = inp.sides();
                secondSide = inp.sides();
                thirdSide = inp.sides();
                CheckTriangle ct = new CheckTriangle();
                ct.check(firstSide, secondSide, thirdSide);
            }
            catch (FormatException)
            {
                Console.Write("your input not a number");
                Console.ReadKey();
            }





            /*
            string s = "Hello";
            string s1 = "World";
            int i = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(i*i);
            Console.Write(s);
            Console.ReadKey();
            */
        }
    }
}
