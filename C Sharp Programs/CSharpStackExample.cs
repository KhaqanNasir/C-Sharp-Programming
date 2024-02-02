using System;
using System.Collections.Generic;
namespace A
{ 
   
        class CSharpStackExample
        {
        
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("M.Khaqan Nasir");    // add elements to top
            stack.Push("Ali Raza");
            stack.Push("Abdullah Rafiq");
            stack.Push("Faizan Mustafa");

            foreach (var item in stack) { Console.WriteLine(item); }

            stack.Pop();   // delete top elements
            stack.Push("Ahsan Abdullah");

            foreach (var item in stack) { Console.WriteLine(item); }

            stack.Peek();  // display top elements

            stack.Contains(stack.Peek());

            stack.Clear();  // remove all the elements from the stack
            foreach (var item in stack) { Console.WriteLine(item); }




            Console.Read();   // for hold the screen
            }
           

        }

    }