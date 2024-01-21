using System;

namespace C_Sharp_Programs { 

    public struct rectangle   // struct declare
    {
        public int width;
        public int height;

        public rectangle(int width,int height)    // constructor
        {
            this.width = width;
            this.height = height;
        }
        public void display()     // display method
        {
            Console.WriteLine("Width is " + this.width);
            Console.WriteLine("Heigth is " + this.height);
            Console.WriteLine("Area is "+this.width*this.height);
        }
    }
 class StructureExample   
{
        static void Main(string[] args)
        {
            rectangle r1 = new rectangle(12,23);   // instance of struct
            r1.display();



            Console.Read();   // for hold the screen
        }

    }
}