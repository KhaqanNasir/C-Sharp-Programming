using System;
namespace A
{
    class genericClass<T>
    {
        public genericClass(T msg) {
            Console.WriteLine(msg);
        }
    }
    class genClass
    {
        public void show<T>(T msg) { Console.WriteLine(msg);}
    }
    class CSharpGenericExample
        {
        
        static void Main(string[] args)
        {
            genericClass<string> g1 = new genericClass<string>("Khaqan Nasir");
            genericClass<int> g2 = new genericClass<int>(39);
            genericClass<char> g3 = new genericClass<char>('A');
            
            genClass g4 = new genClass();
            g4.show("M.Khaqan Nasir");
            g4.show(39);
            g4.show('A');
           
          

            Console.Read();   // for hold the screen
            }
           

        }

    }