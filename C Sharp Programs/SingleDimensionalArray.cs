using System;

namespace C_Sharp_Programs
{
     class SingleDimensionalArray
    {
        static void max(int[] array)
        {
            int max = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max= array[i];
                }
            }
            Console.WriteLine("Maximum is "+max);

        }
        
        static void Main(string[] args)
        {
            int[] array = new int[5]; // Single Dimen. Array
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
            max(array);  // Pass Array as a function

            int[] array2 = { 9, 8, 7, 6, 5, 4 };     // Another method for single dim. Array
            foreach(int i in array2)
            {
                Console.WriteLine(i);
            }



            Console.Read();   // for hold the screen
        }
    }
}
