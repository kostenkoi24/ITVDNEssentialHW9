using System;

namespace Homework9_5
{

    delegate int MyDelegate(int a, int b, int c);

    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            int c = 6;


            MyDelegate d = delegate (int a, int b, int c) { return (a + b + c) / 3; };


            int sum = d(a, b, c);

            Console.WriteLine("Avarage of {0} {1} {2} = {3}", a, b, c, sum);

            Console.ReadKey();
        }
    }
}
