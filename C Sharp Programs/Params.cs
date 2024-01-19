using System;

namespace C_Sharp_Programs
{
     class Params
    {
        public void display(params int[] array)     // just only write the params keyword
        {
            for(int i =0;i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public void display(params object[] array) {   // obect type
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            Params p1 = new Params();
            p1.display(1, 2, 3, 4, 5, 6, 7);    // pass infinity arguments
            Params p2 = new Params();
            p2.display("M.Khaqa Nasir","FA22-BCS-039",3.85);   //pass infinite arguments
           


            Console.Read();   // for hold the screen
        }
    }
}
