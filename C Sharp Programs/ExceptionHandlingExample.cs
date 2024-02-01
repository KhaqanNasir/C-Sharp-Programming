using System;

namespace A
{ 
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message) : base(message)
        {

        }
    }
        class ExceptionHandlingExample
        {
        static void vote(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("You are not eligible for vote!");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                vote(10);
            }
            catch(InvalidAgeException e)
            {
                Console.WriteLine(e.ToString());
            }
            int num = int.MinValue;
            Console.WriteLine(num + 2);

            checked
            {
                int num1 = int.MaxValue;
            //    Console.WriteLine(num1 + 2);        // System.OverflowException: 'Arithmetic operation resulted in an overflow.'
            }
            unchecked
            {
                int num2 = int.MaxValue;
                Console.WriteLine(num2 + 2);
            }

            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally { Console.WriteLine(num); }

            try
            {
                int[] arr = new int[5];
                arr[7] = 6;
            }
            catch (SystemException e){
                Console.WriteLine(e);
            }
         
            Console.Read();   // for hold the screen
            }
           

        }

    }