using System;

namespace C_Sharp_Programs
{
    class student     // Class
    {
        public int rollno;
       public string name;   // Data Members
       public int age;

        public void setValues(int a , string b,int c)  // method to initialize values
        {
            rollno = a;
            name = b;
            age = c;

        }
        public void display()  // display method
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(rollno);

        }
    }
     class ClassesandObjects
    {
        
        public static void Main(string[] args)
        {
            student s1 = new student();   // Object of a class

            s1.rollno = 39;
            s1.name = "M.Khaqan Nasir";
            s1.age = 20;
            
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.age); 
            Console.WriteLine(s1.rollno);

            student s2 = new student();   // Object of a class

            s2.setValues(12, "Ali", 23);

            Console.WriteLine(s2.name);
            Console.WriteLine(s2.age);
            Console.WriteLine(s2.rollno);

            student s3 = new student();   // Object of a class

            s3.setValues(14, "Ali", 23);
            s3.display();



            Console.Read();   // for hold the screen
        }
    }
}
