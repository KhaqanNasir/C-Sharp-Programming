using System;

namespace C_Sharp_Programs
{
     class GotoStatement
    {
        static void Main(string[] args)
        {   
            again:
            Console.WriteLine("Enter your age");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 18)
            {
                Console.WriteLine("Eligible for vote");
            }
            else
            {
                Console.WriteLine("Not Eligible for vote");
                goto again;
            }


            Console.Read();
        }
    }
}
