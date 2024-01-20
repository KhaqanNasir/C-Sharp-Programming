using System;
namespace C_Sharp_Programs{
class Destructor
{
    int a;
    int b;

    public Destructor(int a, int b)
    { 
        this.a = a;
        this.b = b;
    }
    ~Destructor()   // Destructor of the class it can destroy the instance of he class
    {
        Console.WriteLine("Destroyed");
    }
    public void display()
    {
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
    static void Main(string[] args)
    {
        Destructor d1 = new Destructor(1, 2);
        d1.display();


        Console.Read();   // for hold the screen

    }
    }
}
