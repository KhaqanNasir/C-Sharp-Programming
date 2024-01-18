using System;

namespace C_Sharp_Programs
{
     class While_Loop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....Simple While Loop Example....\n");
            Console.WriteLine("Enter A Number to print a table");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
                i++;
            }

            Console.WriteLine("\n....Simple Nested While Loop Example....\n");
            int k = 1;
            while (k <= 3)
            {
                int j = 1;
                while (j <= 3)
                {
                    Console.WriteLine(k + " " + j);
                    j++;
                }
                k++;
            }


            Console.Read();
        }
    }
}
