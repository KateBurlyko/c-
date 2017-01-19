using System;


namespace myFirstProgram
{
    class InputData
    {
        public double sides()
        {
            double side=0;
        
                do
                {
                    Console.WriteLine("input sides");
                    side = Convert.ToDouble(Console.ReadLine());
                } while (side < 0);          
            return side;
        }
    }
}
