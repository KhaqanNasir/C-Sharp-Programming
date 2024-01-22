using System;

namespace C_Sharp_Programs
{  
   public class student
    {
        private int id;     // declare private data member
        private string name;

        public void setid(int id)   // set method inside the class and declare public
        {
            this.id = id;
        }
        public int getid()        // get value inside the class and still it is public
        {
            return id;
        }
        public void setName(string name)
        {
            this.name = name;

        }
        public string getName()
        {
            return name;
        }
     
        
    }
       
    class SetandGetExample
        {
            static void Main(string[] args)
            {
             student s1 = new student();

            s1.setid(1);
            s1.setName("test");   // initialize the values

            Console.WriteLine(s1.getid()+" "+s1.getName());
             

                Console.Read();   // for hold the screen
            }

        }
    }
