using System;
using System.IO;
namespace A
{ 
   
        class FileStreamExample
        {
        
        static void Main(string[] args)
        {
            string path = @"D:\streamFile.txt";
            FileStream file = new FileStream(path,FileMode.OpenOrCreate);
            for(int i = 65; i <=90; i++)
            {
                file.WriteByte((byte)i);
            }

            int j=0;
            while((j=file.ReadByte()) != -1)
            {
                Console.WriteLine((char)j);
            }
            file.Close();
            
            Console.Read();   // for hold the screen
            }
           

        }

    }