using System;

namespace SumofSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the expression:");
            string inputExpression = Console.ReadLine();
            string[] numbers = inputExpression.Split('+');
            if (numbers.Length != 0)
            {
                int sum = 0;
                foreach(var elem in numbers)
                {
                    bool result = int.TryParse(elem, out int number);
                    if (result)
                    {
                        sum += number;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input value {0}. Please enter a valid expression.", elem);
                        return;
                    }
                }
                Console.WriteLine("The sum of series is:{0}", sum);
            }
            else
            {
                Console.WriteLine("No numbers found to sum.");
            }
        }
    }
}
