using System;
using System.Collections.Generic;
namespace A
{

    class CSharpSortedListExample
        {
        
        static void Main(string[] args)
        {
           SortedList<int,string> dictionary = new SortedList<int,string>();

            dictionary.Add(1, "M.Khaqan Nasir");
            dictionary.Add(5, "Abdullah Rafiq");
            dictionary.Add(2, "Malik Ali Raza Yar");
            dictionary.Add(6, "Faizan Mustafa");
            dictionary.Add(3, "Ahsan Abdullah");
            dictionary.Add(4, "Areeb Akram");
            
            
            foreach (var item in dictionary) { Console.WriteLine(item.Key+" "+item.Value); }

            dictionary.Remove(4);

            foreach(var item in dictionary) { Console.WriteLine(item.Key+" "+item.Value); }

           Console.WriteLine(dictionary.TryGetValue(4, out string value));

            dictionary.Clear();

            foreach(var item in dictionary) { Console.WriteLine(item); }


            Console.Read();   // for hold the screen
            }
           

        }

    }