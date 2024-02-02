using System;
using System.Collections.Generic;
namespace A
{ 
   
        class CSharpLinkedListExample
        {
        
        static void Main(string[] args)
        {
            var names = new LinkedList<string>();

            names.AddLast("M.Khaqan Nasir");
            names.AddLast("Abdullah Rafiq");
            names.AddLast("Malik Ali Raza Yar");
            names.AddFirst("Areeb Akram");
            
            foreach (var name in names) { Console.WriteLine(name); }

            LinkedListNode<string> node = names.Find("Abdullah Rafiq");

            names.AddAfter(node, "Faizan Mustafa");
            names.AddBefore(node, "Ahsan Abdullah");

            foreach(var name in names) { Console.WriteLine(name); }



            Console.Read();   // for hold the screen
            }
           

        }

    }