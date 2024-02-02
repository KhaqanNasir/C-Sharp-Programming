using System;
using System.Collections.Generic;
namespace A
{ 
   
        class CSharpLHashSetExample
        {
        
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            names.Add("M.Khaqan Nasir");
            names.Add("Abdullah Rafiq");
            names.Add("Ahsan ");
            foreach(var a in names)
            {
                Console.WriteLine(a);
            }
            names.Remove("Ahsan ");   // remove one elemnt only
            foreach(var a in names)
            { Console.WriteLine(a); }

            names.Clear();  // remove all elements from HashSet class

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            
            Console.Read();   // for hold the screen
            }
           

        }

    }