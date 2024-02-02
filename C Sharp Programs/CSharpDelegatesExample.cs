using System;
delegate int calculator(int n);
namespace A
{
    
 
    class CSharpDelegatesExample
        {
        static int num = 100;
       public static int add(int n)
        {
            num = num + n;
            return num;
        }

        static int mul(int n)
        {
            num = num * n;

            return num;
        }
        static int getNum()
        {
            return num;
        }
        
        static void Main(string[] args)
        {
            calculator c1 = new calculator(add);
            c1(23);
            Console.WriteLine(getNum());

            calculator c2 = new calculator(mul);
            c2(5);
            Console.WriteLine(getNum());

            Console.Read();   // for hold the screen
            }
           

        }

    }