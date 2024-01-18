using System;

namespace C_Sharp_Programs
{
     class Break_and_Continue
    {
        static void Main(string[] args)
        {
           for(int i = 0; i <= 10; i++)
            {
                if (i == 6)
                {
                    break;    // the break statement break the loop when i = 6
                }
                Console.Write(i+" ");
            }
            Console.WriteLine();
           for(int j = 0; j <= 10; j++)
            {
                if (j == 6)
                {
                    continue;   // the continue statement skip when i = 6
                }
                Console.Write(j+" ");
            }


            Console.Read();
        }
    }
}
