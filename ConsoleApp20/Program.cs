using System;
using System.Diagnostics;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string[] text = Array.Empty<string>();
            text = Console.ReadLine().Split();
            Solution solution = new(text);
            Console.WriteLine(solution.getSolution(text));
        }
    }
}