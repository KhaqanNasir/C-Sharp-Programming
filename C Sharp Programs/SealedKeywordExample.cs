using System;

namespace C_Sharp_Programs
{  
    sealed class Animal    // use sealed keyword
    {
        public sealed virtual void show()
        {
            Console.WriteLine("This is parent class");
        }
    }
    class dog:Animal { 
      public override void show()
        {
            Console.WriteLine("This is child class");
        }
    }
    class babydog : Animal
    {
        public override void show()
        {
            Console.WriteLine("This is smallest class");
        }
    }
    class SealedKeywordExample
        {
            static void Main(string[] args)
            {
            Animal a1 = new Animal();
            a1.show();

            a1 = new dog();
            a1.show();

            a1 = new babydog();
            a1.show();

            Console.Read();   // for hold the screen
            }

        }
    }
