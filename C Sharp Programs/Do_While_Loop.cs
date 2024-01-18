using System;

namespace C_Sharp_Programs
{
     class Do_While_Loop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....Simple Do While Loop Example....\n");
            Console.WriteLine("Enter A Number to print a table");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            do
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
                i++;
            } while (i <= 10);

            Console.WriteLine("\n....Simple Nested Do While Loop Example....\n");
            int k = 1;
            do {
                int j = 1;
                do
                {
                    Console.WriteLine(k + " " + j);
                    j++;

                } while (j<=3);
                k++;
            } while (k<=3);


            Console.Read();
        }
    }
}
