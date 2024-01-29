using System;

namespace A
{
    class zain
    {
        public string name {
            get; set;
        }
        public int age { get; set; }
    }


        class EncapsulationExample
        {
            static void Main(string[] args)
            {
             zain z1 = new zain();
            z1.name = "M.Khaqan Nasir";
            z1.age = 20;

            Console.WriteLine("Name : "+z1.name);
            Console.WriteLine("Age : "+z1.age);
              


                Console.Read();   // for hold the screen
            }

        }

    }