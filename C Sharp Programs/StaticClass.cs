using System;

namespace C_Sharp_Programs { 
static class StaticClass   // static class
{
        static float piValue = 3.14f;    // static data member
        static int cube(int n)   // static member function
        {
            return n * n * n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("PiValue is " + StaticClass.piValue);
            Console.WriteLine("Cube of 3 is "+StaticClass.cube(3));

            Console.WriteLine("PiValue is " + StaticClass.piValue);
            Console.WriteLine("Cube of 5 is " + StaticClass.cube(5));



            Console.Read();   // for hold the screen
        }

    }
}