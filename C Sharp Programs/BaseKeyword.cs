using System;

namespace C_Sharp_Programs
{  
    class Animal   // Parent Class
    {
        public string color = "White";
          
        public virtual void print()
        {
            Console.WriteLine(color);
        }

        public Animal()
        {
            Console.WriteLine("This is parent Class");
        }
      
    }
    class dog:Animal {       // child class

      public string color = "Black";
        public override void print()
        {
            Console.WriteLine(color);
            base.print();       // use base keyword to override method
        }
        public void display()
        {
            Console.WriteLine(color);
            Console.WriteLine(base.color);  // iuse base keyword to print parent class field
        }
        public dog()      // Constructor is internally invovked
        {
            Console.WriteLine("This is Child Class");      
        }
    }
    class BaseKeyword
        {
            static void Main(string[] args)
            {
                dog d1 = new dog();
                d1.display();
                d1.print();

            Console.Read();   // for hold the screen
            }

        }
    }
