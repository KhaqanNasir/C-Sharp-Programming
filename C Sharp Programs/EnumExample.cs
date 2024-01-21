using System;

namespace C_Sharp_Programs
{  
         enum days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };   // declare Enum start from 0
         enum seasons { Winter=10,Summer,Autum,Fall};              // declare Enum start from 10
    class EnumExample
        {
            static void Main(string[] args)
            {

            Console.WriteLine(seasons.Winter);  // dislay winter
            Console.WriteLine((int)seasons.Autum);   // output 12


            Console.WriteLine((int)days.Friday);     // output 5 
            Console.WriteLine(days.Sunday);    // output sunday

            foreach(days d in Enum.GetValues(typeof(days)))     // display 7 days
            {
                Console.Write(d+" ");
            }
            Console.WriteLine();  // for new Line

            foreach(seasons s in Enum.GetValues(typeof(seasons)))   // display 4 seasons
            {
                Console.Write(s+" ");
            }


                Console.Read();   // for hold the screen
            }

        }
    }
