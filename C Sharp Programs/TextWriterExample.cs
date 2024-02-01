using System;
using System.IO;
namespace A
{ 
   
        class TextWriterExample
        {
        
        static void Main(string[] args)
        {
            string path = @"D:\streamFile.txt";
           TextWriter writer = File.CreateText(path);
            writer.WriteLine("Khaqan ");
            writer.WriteLine("Nasir");
            writer.Close();

            TextReader reader = File.OpenText(path);
            Console.WriteLine(reader.ReadToEnd());  
            reader.Close();

            Console.WriteLine("Successful ");
            Console.Read();   // for hold the screen
            }
           

        }

    }