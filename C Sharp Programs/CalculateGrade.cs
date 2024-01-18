using System;

namespace C_Sharp_Programs
{
     class CalculateGrade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Numbers");
            double num = Convert.ToDouble(Console.ReadLine());  
            if(num >= 90)
            {
                Console.WriteLine("A Grade");
            } else if(num >= 80)
            {
                Console.WriteLine("B Grade");
            } else if (num >= 70)
            {
                Console.WriteLine("C Grade");
            } else if(num >= 60)
            {
                Console.WriteLine("D Grade");
            } else if (num >= 50)
            {
                Console.WriteLine("E Grade");
            }
            else
            {
                Console.WriteLine("F Grade");
            }

            Console.Read();
        }
    }
}
