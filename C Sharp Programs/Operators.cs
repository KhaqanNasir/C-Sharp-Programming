
using System;

namespace C_Sharp_Programs
{
     class Operators
    {
        static void Main(string[] args)
        {
            Console.WriteLine("......Operators.......");

            int x = 5;
            int y = 7;

            Console.WriteLine(x + y); // + is the Arithmetic Operator to Add two numbers
            Console.WriteLine(x - y); // - is the Arithmetic Operator to Subtract two numbers
            Console.WriteLine(x * y); // * is the Arithmetic Operator to Multiply two numbers
            Console.WriteLine(x / y); // / is the Arithmetic Operator to Divide two numbers
            Console.WriteLine(x % y); // % is the Arithmetic Operator to get the remainder of two numbers

            Console.WriteLine(x < y); // < is the Relational Operator to check less than between two numbers return true of false
            Console.WriteLine(x <= y); // <= is the Relational Operator to check less than and equal to between two numbers return true of false 
            Console.WriteLine(x > y); // > is the Relational Operator to check greater than between two numbers return true of false
            Console.WriteLine(x >= y); // >= is the Relational Operator to check greater than and equal to between two numbers return true of false
            Console.WriteLine(x == y); // == is the Relational Operator to check equal to between two numbers return true of false
            Console.WriteLine(x != y); // != is the Relational Operator to check not equal to between two numbers return true of false

            Console.WriteLine(x++);  // ++ is the Unary Operators to increment 1 in the x
            Console.WriteLine(x--);  // -- is the Unary Operators to decrement 1 in the x

            x = 100;  // = is the Assignment Operator to Assign Values
            Console.WriteLine(x);

            Console.Read();         // Console.Read is used for hold the screen
        }
    }
}
