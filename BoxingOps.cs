// source: https://www.sanfoundry.com/csharp-program-boxing-operations/
// author: Sanfoundry
// summary: c# consol app showing boxing operations
// modifications: n/a
// student: Chris Patton
// capture date: 14 Apr 2019

namespace BoxingOps
{
    class Program
    {
        class sample
        {
            int x = 10;
            object obj;
            void boxmethod()
            {
                sample s = new sample();
                bool b;
                object ob = "CSHARP";
                b = s.obj is int;
                Console.WriteLine(b);
                s.obj = x;
                b = s.obj is int;
                Console.WriteLine("{0},{1},{2}", s.obj, s.x, b);
                s.x = (int)s.obj;
                s.x = 20;
                b = s.obj is int;
                Console.WriteLine("{0},{1},{2}", s.obj, s.x, b);
                s.obj = "CSHARP";
                b = s.obj is int;
                Console.WriteLine("{0},{1},{2}", s.obj, s.x, b);
                Console.ReadLine();
            }
            public static void Main(string[] args)
            {
                sample s = new sample();
                s.boxmethod();
            }
        }
    }
}