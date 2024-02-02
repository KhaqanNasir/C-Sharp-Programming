using System;
using System.Collections.Generic;
namespace A
{ 
   
        class CSharpSortedSetExample
        {
        
        static void Main(string[] args)
        {
            var names = new SortedSet<string>();

            names.Add("M.Khaqan Nasir");
            names.Add("Abdullah Rafiq");
            names.Add("Ahsan ");
            names.Add("Areeb Akram");
            names.Add("Faizan Mustafa");
            names.Add("Malik Ali Raza yar");

            foreach(var a in names) { Console.WriteLine(a); }

            names.Remove("Ahsan ");   // remove one elemnt only
 
            foreach(var a in names) { Console.WriteLine(a); }


            names.Clear();  // remove all elements from SortedSet class

            foreach (var name in names) { Console.WriteLine(name); }
            
            
            Console.Read();   // for hold the screen
            }
           

        }

    }