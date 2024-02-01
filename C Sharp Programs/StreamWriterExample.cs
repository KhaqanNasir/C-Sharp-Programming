using System;
using System.IO;
namespace A
{ 
   
        class StreamWriterExample
        {
        
        static void Main(string[] args)
        {
            string path = @"D:\streamFile.txt";
            FileStream file = new FileStream(path,FileMode.OpenOrCreate);

            StreamWriter sr = new StreamWriter(file);
            StreamReader s = new StreamReader(file);

            sr.WriteLine("Hello i am a C# developer");
            string line = s.ReadLine();
            Console.WriteLine(line);


            s.Close();
            sr.Close();
            file.Close();
            Console.WriteLine("Successful ");
            Console.Read();   // for hold the screen
            }
           

        }

    }