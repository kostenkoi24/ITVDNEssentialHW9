using System;

namespace Homework9_3
{
    class Program
    {

        delegate int MyDelegate();

        static Random random = new Random();

        static int m1() { int a = random.Next(1, 5); Console.WriteLine(a); return a;  }
        static int m2() { int a = random.Next(1, 5); Console.WriteLine(a); return a; }
        static int m3() { int a = random.Next(1, 5); Console.WriteLine(a); return a; }


        static void Main(string[] args)
        {


            MyDelegate[] myDelegates = new MyDelegate[]
            {
                new MyDelegate(m1),
                new MyDelegate(m2),
                new MyDelegate(m3)
            };

            MyDelegate d = delegate
            {
                int sum = 0;
                for (int i = 0; i < myDelegates.Length; i++)
                {
                    sum += myDelegates[i].Invoke();
                }
                return sum / myDelegates.Length;
            };


            Console.WriteLine("Avarage = {0}", d.Invoke());
            


            Console.ReadKey();
        }
    }
}
