using System;

namespace C_Sharp_Programs
{  
   public class student    // One Class parent / Base Class
    {
        public int id ;
        public string name ;
     
        
    }
       public class Topper : student {    // second Class Child / Derived Class

        public float gpa;
        public string department ;
    }
    class MainClass
        {
            static void Main(string[] args)
            {
            
             Topper t1 = new Topper();

            t1.id = 39;
            t1.name = "M.Khaqan Nasir";
            t1.department = "Computer Science";
            t1.gpa = 3.96f;

            Console.WriteLine(t1.id);
            Console.WriteLine(t1.name);
            Console.WriteLine(t1.department);
            Console.WriteLine(t1.gpa);

                Console.Read();   // for hold the screen
            }

        }
    }
