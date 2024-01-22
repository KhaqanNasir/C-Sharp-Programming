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

        public student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }   
       
    }
       public class Topper {   

        public float gpa;
        public string department ;
        public student std;   // use student class as a data member this is called HAS A Relationship

        public Topper(float gpa, string department, student std)
        {
            this.gpa = gpa;
            this.department = department;
            this.std = std;
        }
        public void display()
        {
            Console.WriteLine(this.gpa + " " + this.department+" "+this.std.name+" "+this.std.id);
            Console.WriteLine(student.uniName);
        }
    }
    class MainClass
        {
            static void Main(string[] args)
            {
            Console.WriteLine("\tEXAMPLE of HAS A Relationship\n"); 

            student s1 = new student(39, "M.Khaqan Nasir");
             Topper t1 = new Topper(3.96f,"Computer Science",s1);
            t1.display();


                Console.Read();   // for hold the screen
            }

        }
    }
