using System;

namespace C_Sharp_Programs
{
     class RandomNumbers
    {
        
        public static void Main(string[] args)
        {

            Random random = new Random();
            int num = random.Next(1,10);    // generate random num 1 between 1 - 10
            Console.WriteLine(num);

            int num1 = random.Next(1, 100);   //  generate random num 1 between 1 - 100
            Console.WriteLine(num1);

            int num2 = random.Next(1, 100);      //  generate random num 1 between 1 - 100
            Console.WriteLine(num2);

            int num3 = random.Next(2, 100);       //  generate random num 1 between 2 - 100
            Console.WriteLine(num3);

            int num4 = random.Next(2, 10);         //  generate random num 1 between 2 - 10
            Console.WriteLine(num4);

            int num5 = random.Next(2, 10);          //  generate random num 1 between 2 - 10
            Console.WriteLine(num5);

            int num6 = random.Next(100, 1000);          //  generate random num 1 between 100 - 1000
            Console.WriteLine(num6);


            Console.Read();   // for hold the screen
        }
    }
}
