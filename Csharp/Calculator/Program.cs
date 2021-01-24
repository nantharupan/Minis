using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator !");
                        MyCalculator calculator = new MyCalculator();

            Console.Write("Enter Integer: ");
            var val1 = Console.ReadLine();
            int a = Convert.ToInt32(val1);

            Console.Write("Enter Integer: ");
            var val2 = Console.ReadLine();
            int b = Convert.ToInt32(val2);

            Console.Write("Enter Operation: ");
            var operation = Console.ReadLine();


            int result = 0;

            switch (operation)
            {
                case "+":
                    result = calculator.add(a, b);
                    break;
                case "-":
                    result = calculator.add(a, b);
                    break;
                default:
                    Console.WriteLine("Not Implemente");
                    break;
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
    public class MyCalculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int substract(int a, int b)
        {
            return a - b;
        }
    }
}
