using System;

namespace C_Sharp_Programs
{
     class Functions
    {
        public void display()
        {
            Console.WriteLine("Hello Khaqan");
        }
        public void display(string text)
        {
            Console.WriteLine(text);
        }
        public string display1(string text)
        {
            return text;
        }
        public void show(int value)
        {
            value *= value;
            Console.WriteLine(value);
        }
        public void show2(ref int value)
        {
            value *= value;
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            Functions F1 = new Functions();

            F1.display();    // No return Type and No Arguments
            F1.display("M.Khaqan Nasir");     // No return Type but with arguments
            Console.WriteLine(F1.display1("Hello C# Developers"));    // return type with arguments

            int value = 10;
            Console.WriteLine("Before Calling Function "+value);    // CALL BY VALUE FUNCTION
            F1.show(value);
            Console.WriteLine("After  Calling Function " + value);


            int num = 10;
            Console.WriteLine("Before Calling Function " + num);    // CALL BY REFERENCE FUNCTION
            F1.show2(ref num);
            Console.WriteLine("After  Calling Function " + num);




            Console.Read();
        }
    }
}
