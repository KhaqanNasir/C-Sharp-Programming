using System;

namespace C_Sharp_Programs { 
class StaticandThis
{
        int id;
        string name;
        static string companyName = "Khaqan Institue";   // declare static because same for every object

         StaticandThis(int id,string name) { 

            this.id = id;   
            this.name = name;  // use of this keyword because field name and parameter name is same

        }
        void display()
        {
            Console.WriteLine("Id is "+this.id);
            Console.WriteLine("Name is " + this.name);
            Console.WriteLine("Company name " + StaticandThis.companyName);   // call the static without object or call with the class name
        }
   
        static void Main(string[] args)
        {
            StaticandThis s1 = new StaticandThis(10,"M.Khaqan Nasir");
            s1.display();      // static will same for all objects

            StaticandThis s2 = new StaticandThis(11, "Malik Ali Raza");
            s2.display();
           
            Console.Read();   // for hold the screen
        }

    }
}