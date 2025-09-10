using System;
using System.Collections.Generic;
using System.Linq;

namespace FibonacciAverageApp
{
    // Getting data from the user
    public class InputReader
    {
        public int ReadDepth()
        {
            int depth;
            Console.Write("Enter depth for Fibonacci series: ");
            while (!int.TryParse(Console.ReadLine(), out depth) || depth < 1)
            {
                Console.Write("Invalid input! Please enter a positive number: ");
            }
            return depth;
        }
    }

    // Fibonacci serisi oluşturmak
    public class FibonacciGenerator
    {
        public List<int> Generate(int count)
        {
            List<int> series = new List<int>();
            if (count >= 1) series.Add(0);
            if (count >= 2) series.Add(1);

            for (int i = 2; i < count; i++)
            {
                series.Add(series[i - 1] + series[i - 2]);
            }

            return series;
        }
    }

    // Hesaplamalar yapmak
    public class Calculator
    {
        public double CalculateAverage(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                throw new ArgumentException("The list cannot be empty.");
            return numbers.Average();
        }
    }

    // Sonucu ekrana yazdırmak
    public class OutputWriter
    {
        public void PrintSeries(List<int> series)
        {
            Console.WriteLine("Fibonacci Series: " + string.Join(", ", series));
        }

        public void PrintAverage(double average)
        {
            Console.WriteLine($"Average of the Fibonacci series: {average}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var reader = new InputReader();
            var generator = new FibonacciGenerator();
            var calculator = new Calculator();
            var writer = new OutputWriter();

            int depth = reader.ReadDepth();
            List<int> fibonacciSeries = generator.Generate(depth);

            writer.PrintSeries(fibonacciSeries);
            double average = calculator.CalculateAverage(fibonacciSeries);
            writer.PrintAverage(average);
        }
    }
}
