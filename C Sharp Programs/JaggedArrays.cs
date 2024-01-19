using System;

namespace C_Sharp_Programs
{
     class JaggedArrays
    {
        
        static void Main(string[] args)
        {
            int[][] array = new int[2][];   // Jagged Array
            array[0] = new int[5] { 1, 2, 3, 4, 5 };
            array[1] = new int[5] { 6, 7, 8, 9, 0 };
            
            for(int i = 0;i < array.Length; i++){
                for(int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]+" ");
                }
                Console.WriteLine();
            }


            Console.Read();   // for hold the screen
        }
    }
}
