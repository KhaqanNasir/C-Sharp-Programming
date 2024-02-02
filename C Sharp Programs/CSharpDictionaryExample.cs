using System;
using System.Collections.Generic;
namespace A
{ 
   
        class CSharpDictionaryExample
        {
        
        static void Main(string[] args)
        {
           Dictionary<int,string> dictionary = new Dictionary<int,string>();

            dictionary.Add(1, "M.Khaqan Nasir");
            dictionary.Add(2, "Abdullah Rafiq");
            dictionary.Add(3, "Malik Ali Raza Yar");
            dictionary.Add(4, "Faizan Mustafa");
            dictionary.Add(5, "Ahsan Abdullah");
            dictionary.Add(6, "Areeb Akram");

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