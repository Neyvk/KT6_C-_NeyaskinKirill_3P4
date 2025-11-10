using System;

namespace EnumExamples
{
    enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    class Program
    {
        static double Calculate(double a, double b, Operation operation)
        {
            return operation switch
            {
                Operation.Add => a + b,
                Operation.Subtract => a - b,
                Operation.Multiply => a * b,
                Operation.Divide => b != 0 ? a / b : double.NaN,
                _ => double.NaN
            };
        }
        static void Main()
        {
            Console.Write("Оператор: ");
            str = Console.ReadLine();
            Console.Write("Первое число: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            int second = Convert.ToInt32(Console.ReadLine());
            if (Enum.TryParse(str, true, out Operation math))
            {
                double result = Calculate(first, second, math);
                Console.WriteLine(result);
            }
        }
    }
}
