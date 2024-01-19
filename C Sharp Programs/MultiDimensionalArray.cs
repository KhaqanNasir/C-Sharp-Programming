using System;

namespace C_Sharp_Programs
{
     class MultiDimensionalArray
    {
        
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 5, 4, 3, 2, 1 }, { 6, 7, 8, 9, 1 }, { 1, 9, 8, 7, 6 },{ 0, 0, 0, 0, 0 } };
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write(array[i,j]+" ");
                }
                Console.WriteLine();
            }



            Console.Read();   // for hold the screen
        }
    }
}
