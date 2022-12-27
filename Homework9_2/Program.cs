using System;

namespace Homework9_2
{
    class Program
    {

        /*
         Використовуючи Visual Studio, створіть проект за шаблоном Console 
        Application. Створіть чотири лямбда оператора для виконання арифметичних дій: 
        (Add – додавання, Sub – віднімання, Mul – множення, Div – поділ). 
        Кожен лямбда оператор повинен приймати два аргументи та повертати результат обчислення. 
        Лямбда оператор поділу повинен перевірити поділ на нуль. 
        Написати програму, яка виконуватиме арифметичні дії, вказані користувачем. 
         */

        public delegate int Op(int x, int y);

        public class Math
        {
            public static int Add(int x, int y) => x + y;
            public static int Sub(int x, int y) => x - y;
            public static int Mul(int x, int y) => x * y;
            //public static int Div(int x, int y) => x / y;

        }

        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть перше число:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть друге число:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Оберіть дію ('+' '-' '*' '/'):");
            string d = Console.ReadLine();

            Op op = default;
            bool error = false;
            
            switch (d)
            {
                case ("+"):
                    op = new Op(Math.Add);
                    break;
                case ("-"):
                    op = new Op(Math.Sub);
                    break;
                case ("*"):
                    op = new Op(Math.Mul);
                    break;
                case ("/"):
                    //op = new Op(Math.Div);
                    op = (x, y) =>
                    {
                        try { return x / y; }
                        catch (Exception e) { Console.WriteLine(e.Message); return 0; }
                    };

                    break;
                default: Console.WriteLine("Обрана дія не знайдена"); error = true;
                    break;
            };

            if (error == false)
            {
                Console.WriteLine($"{x} {d} {y} = {op(x, y)}");
            }
            



            Console.ReadKey();
        }
    }
}
