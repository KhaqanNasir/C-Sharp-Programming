using System;
using System.Collections.Generic;
namespace A
{ 
   
        class CSharpQueueExample
        {
        
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Abdullah Rafiq");
            queue.Enqueue("M.Khaqan Nasir");
            queue.Enqueue("Areeb Akram");
            queue.Enqueue("Ahsan Abdullah");
            queue.Enqueue("Faizan Mustafa");

            foreach (var item in queue) { Console.WriteLine(item); }

            Console.WriteLine("Dequeue item is "+queue.Dequeue());

            queue.Enqueue("Malik Ali Raza Yar");

            Console.WriteLine("Peek Item is "+queue.Peek());

            foreach(var item in queue) { Console.WriteLine(item); }

            queue.Clear(); // remove all elements
            
            foreach(var item in queue) { Console.WriteLine(item); }




            Console.Read();   // for hold the screen
            }
           

        }

    }