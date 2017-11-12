﻿using System;

namespace diceroller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();

            var random = new Random();

            Console.WriteLine($"1d6: { random.Next(1, 7)}");
            Console.WriteLine($"1d6: { random.Next(1, 7)}");
            Console.WriteLine($"1d6: { random.Next(1, 7)}");
            Console.WriteLine($"1d8: { random.Next(1, 9)}");
            Console.WriteLine($"1d8: { random.Next(1, 9)}");
            Console.WriteLine();

            Console.WriteLine("Roll total: 20");
            Console.WriteLine();
            Console.WriteLine(">");
            Console.ReadLine();
        }
    }
}
