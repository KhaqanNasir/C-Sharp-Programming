using System;

namespace C_Sharp_Programs { 
 class StaticConstructor   
{
        int id;
        string name;
        static string companyName;
        static StaticConstructor()   // static constructor only initialize the static member
        {
            companyName = "Khaqan Istitute";
        }
        StaticConstructor(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        void display()
        {
            Console.WriteLine(companyName);
            Console.WriteLine(this.id);
            Console.WriteLine(this.name);
        }
        static void Main(string[] args)
        {
            StaticConstructor s1 = new StaticConstructor(11, "Ali");
            s1.display();

            StaticConstructor s2 = new StaticConstructor(12, "Abdullah");
            s2.display();
            



            Console.Read();   // for hold the screen
        }

    }
}