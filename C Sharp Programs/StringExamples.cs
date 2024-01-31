using System;

namespace A
{ 
        class StringExamples
        {
        static void Main(string[] args)
        {
            Console.WriteLine("CLONE EXAMPLE");
            string s1 = "M.Khaqan Nasir";
            string s2 = (string)s1.Clone();
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("\nCOMAPERE EXAMPLE");
            string s3 = "Khaqan";
            string s4 = "Khaqan";
            string s5 = "M.nasir";
            Console.WriteLine((String.Compare(s3, s4)));
            Console.WriteLine((String.Compare(s3, s5)));
            Console.WriteLine((String.Compare(s4, s5)));
            Console.WriteLine((String.Compare(s5, s4)));

            Console.WriteLine("\nCOMPAREORDINAL EXAMPLE");
            Console.WriteLine((String.CompareOrdinal(s3, s4)));
            Console.WriteLine((String.CompareOrdinal(s3, s5)));
            Console.WriteLine((String.CompareOrdinal(s4, s5)));
            Console.WriteLine((String.CompareOrdinal(s5, s4)));

            Console.WriteLine("\nCOMPARETO EXAMPLE");
            Console.WriteLine(s3.CompareTo(s4));
            Console.WriteLine(s3.CompareTo(s5));
            Console.WriteLine(s4.CompareTo(s5));

            Console.WriteLine("\nCONCATENATION EXAMPLE");
            Console.WriteLine(string.Concat(s3, s4, s5));

            Console.WriteLine("\nCONTAINS EXAMPLE");
            Console.WriteLine(s3.Contains(s4));
            Console.WriteLine(s4.Contains(s5));
            Console.WriteLine(s4.Contains(s5));

            Console.WriteLine("\nCOPY EXAMPLE");
            string s6 = "How are you? ";
            string s7 = string.Copy(s6);
            Console.WriteLine(s6 + s7);

            Console.WriteLine("\nCOPYTO EXAMPLE");
            char[] copy = new char[10];
            s6.CopyTo(5, copy, 0, 7);
            Console.WriteLine(copy);

            Console.WriteLine("\nENDSWITH EXAMPLE");
            string s8 = "khaqan";
            string s9 = "qan";
            string s10 = "c#";
            Console.WriteLine(s8.EndsWith(s9));
            Console.WriteLine(s8.EndsWith(s10));

            Console.WriteLine("\nEQUALS EXAMPLE");
            string s11 = "Khaqan";
            string s12 = "Khaqan";
            string s13 = " Khaqan ";
            Console.WriteLine(s11.Equals(s12));
            Console.WriteLine(s11.Equals(s13));

            Console.WriteLine("\nFORMAT EXAMPLE");
            string s14 = string.Format("{0:D}",DateTime.Now);
            Console.WriteLine(s14);

            Console.WriteLine("\nGETENUMERATOR EXAMPLE");
            string s15 = "I am a C# Developer";
            CharEnumerator ch = s15.GetEnumerator();
            while (ch.MoveNext())
            {
                Console.WriteLine(ch.Current);
            }

            Console.WriteLine("\nGETHASHCODE EXAMPLE");
            Console.WriteLine(s15.GetHashCode());

            Console.WriteLine("\nGETTYPE EXAMPLE");
            Console.WriteLine(s15.GetType());

            Console.WriteLine("\nGETTYPECODE EXAMPLE");
            Console.WriteLine(s15.GetHashCode());

            Console.WriteLine("\nINDEXOF EXAMPLE");
            Console.WriteLine(s15.IndexOf('D'));

            Console.WriteLine("\nINSERT EXAMPLE");
            string s16 = s15.Insert(3, "Khaqan");
            Console.WriteLine(s16);

            Console.WriteLine("\nINTERN EXAMPLE");
            string s17=string.Intern(s15);
            Console.WriteLine(s17);

            Console.WriteLine("\nISINTERN EXAMPLE");
            string s18 = "hi";
            string.IsInterned(s18);
            Console.WriteLine(string.IsInterned(s18) != null);

            Console.WriteLine("\nISNORMALIZED EXAMPLE");
            Console.WriteLine(s18.IsNormalized());

            Console.WriteLine("\nNORMALIZE EXAMPLE");
            Console.WriteLine(s18.Normalize());

            Console.WriteLine("\nISNULLOREMPTY EXAMPLE");
            string s19 = "C# Developer";
            string s20 = "";
            string s21 = " ";
            Console.WriteLine(string.IsNullOrEmpty(s19));
            Console.WriteLine(string.IsNullOrEmpty(s20));
            Console.WriteLine(string.IsNullOrEmpty(s20));

            Console.WriteLine("\nISNULLORWHITESPACE EXAMPLE");
            Console.WriteLine(string.IsNullOrWhiteSpace(s19));
            Console.WriteLine(string.IsNullOrWhiteSpace(s20));
            Console.WriteLine(string.IsNullOrWhiteSpace(s21));

            Console.WriteLine("\nJOIN EXAMPLE");
            string[] s22 = { "Khaqan", "is", "a", "C#", "Developer" };
            string s23 = string.Join("-", s22);
            Console.WriteLine(s23);

            Console.WriteLine("\nLASTINDEXOF EXAMPLE");
            string s24 = "Hello Lahore";
            Console.WriteLine(s24.LastIndexOf('L'));

            Console.WriteLine("\nLASTINDEXOFANY EXAMPLE");
            char[] ch1 = { 'L', 'o' };
            Console.WriteLine(s24.LastIndexOfAny(ch1));

            Console.WriteLine("\nPADLEFT EXAMPLE");
            string s25 = "Hello";
            Console.WriteLine(s25.PadLeft(8));

            Console.WriteLine("\nPADRIGHT EXAMPLE");
            Console.WriteLine(s25.PadRight(8));

            Console.WriteLine("\nREMOVE EXAMPLE");
            Console.WriteLine(s25.Remove(3));

            Console.WriteLine("\nREPLACE EXAMPLE");
            string s26 = "Heloo how are you?";
            Console.WriteLine(s26.Replace("Heloo","Hello"));

            Console.WriteLine("\nSTRING EXAMPLE");
            string[] split=s26.Split(' ');
            foreach(string s in split) Console.WriteLine(" " + s);
            Console.Read();   // for hold the screen
            }
           

        }

    }