using System;
using A;
using B;

namespace A
{
    class zain
    {
        public void show()
        {
            Console.WriteLine("Zain Class");
        }
    }
}
namespace B
{
    class ali
    {
        public void show()
        {
            Console.WriteLine("Ali Class");
        }
    }
}   
        class NamespaceExample
        {
            static void Main(string[] args)
            {
              
        Console.WriteLine("Two Namespace Example");
        zain z1 = new zain();
        z1.show();
        ali a1 = new ali();
        a1.show();
              


                Console.Read();   // for hold the screen
            }

        }

    