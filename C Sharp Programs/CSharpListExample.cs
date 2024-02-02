using System;
using System.Collections.Generic;
namespace A
{ 
   
        class CSharpListExample
        {
        
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("M.Khaqan Nasir");
            names.Add("Abdullah Rafiq");
            names.Add("Ahsan ");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            
            Console.Read();   // for hold the screen
            }
           

        }

    }