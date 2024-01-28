using System;

namespace C_Sharp_Programs
{  
    class addition
    {
        public static int add(int a, int b) //Same name two arguments
        {
            return a + b;
        }
        public static int add(int a,int b, int c)  // Same name three arguments
        {
            return a + b + c;
        }
        public static float add(float a, float b, float c) // Same name same arguments but different return type
        {
            return a + b + c;
        }
    }
    class MethodOverloding
        {
            static void Main(string[] args)
            {
           
             Console.WriteLine(addition.add(1, 2));
             Console.WriteLine(addition.add(2, 3, 4));
            Console.WriteLine(addition.add(2.4f, 3.5f, 4.55f));

            Console.Read();   // for hold the screen
            }

        }
    }
