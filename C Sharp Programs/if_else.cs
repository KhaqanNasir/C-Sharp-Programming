using System;

namespace C_Sharp_Programs
{
     class if_else
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...... if Condition ......\n");
            int num = 12;
            if(num % 2 == 0)
            {
                Console.WriteLine("It is even number ");
            }

            Console.WriteLine("....... If_Else .........\n");
            int num2 = 1;
            if(num2 % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

            Console.WriteLine(".......Nested If ........\n");
            int num3 = 12;
            if(num3 % 2 == 0)
            {
                if (num3 == 12)
                {
                    Console.WriteLine("Number is " + num3);
                }
            }

            Console.WriteLine("....... If _ Else _ If ........\n");
            int num4 = 1;
            if (num4 == 3)
            {
                Console.WriteLine("Number is " + num4);
            }
            else if (num4 == 2)
            {
                Console.WriteLine("Number is " + num4);
            }
            else
            {
                Console.WriteLine("Number is " + num4);
            }

            Console.Read();
        }
    }
}
