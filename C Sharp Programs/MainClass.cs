using System;

namespace C_Sharp_Programs
{  

    public class University       // One Class parent / Base Class
    {
        public static string uniName = "COMSATS";
    }
   public class student : University {   // second Class Child / Derived Class
        public int id ;
        public string name ;
     
        
    }
       public class Topper : student {    // third Class Child / Derived Class

        public float gpa;
        public string department ;
    }
    class MainClass
        {
            static void Main(string[] args)
            {
            Console.WriteLine("Show the EXAMPLE of MULTI-LEVEL INHERITENCE\n");
            
             Topper t1 = new Topper();

            t1.id = 39;
            t1.name = "M.Khaqan Nasir";
            t1.department = "Computer Science";
            t1.gpa = 3.96f;

            Console.WriteLine(t1.id);
            Console.WriteLine(t1.name);
            Console.WriteLine(t1.department);
            Console.WriteLine(t1.gpa);
            Console.WriteLine(Topper.uniName);


                Console.Read();   // for hold the screen
            }

        }
    }
