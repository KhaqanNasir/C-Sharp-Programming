using System;

namespace C_Sharp_Programs
{
    interface shape
    {
         void area(float r);

    }
    class circle:shape { 
        public void area(float r)
        {
            r = 3.14f *( r * r);
            Console.WriteLine("Area of circle is " + r);
        }
    }
    class square : shape
    {
        public void area(float r)
        {
            Console.WriteLine("Area of square is " + (r * r ));
        }
    }
        class InterfaceExample
        {
            static void Main(string[] args)
            {
            circle c1 = new circle();
            c1.area(4);
            
            square s1 = new square();
            s1.area(5.5f);


                Console.Read();   // for hold the screen
            }

        }

    }