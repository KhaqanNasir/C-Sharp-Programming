using System;

namespace C_Sharp_Programs
{
     class For_Loop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....Simple For Loop Example....\n");
            Console.WriteLine("Enter A Number to print a table");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num+" x "+i+" = "+num*i);
            }

            Console.WriteLine("\n....Simple Nested For Loop Example....\n");
            for(int i = 1; i <= 3; i++)
            {
                for(int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }


            Console.Read();
        }
    }
}
