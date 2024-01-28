using System;

namespace C_Sharp_Programs
{  
    class Animal   // Parent Class
    {
        public virtual void eat()    // use virtual keyword in parent class
        {
            Console.WriteLine("This is parent Class");
        }
      
    }
    class dog:Animal {       // child class
        public override void eat()          // use overrride keyword for override the virtual method
        {
            Console.WriteLine("This is Child Class");
        }
    }
    class MethodOverriding
        {
            static void Main(string[] args)
            {

            Animal a1 = new Animal();   
            a1.eat();        // call parent class method
            
            dog d1 = new dog();
            d1.eat();       // call child class method

            Console.Read();   // for hold the screen
            }

        }
    }
