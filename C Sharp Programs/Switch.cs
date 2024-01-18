using System;

namespace C_Sharp_Programs
{
     class Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Numbers 0-5");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 0:
                    {
                        Console.WriteLine("Number is "+num);
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Number is "+num);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Number is " + num);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Number is " + num);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Number is " + num);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Number is " + num);
                        break;
                            }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }

            }


            Console.Read();
        }
    }
}
