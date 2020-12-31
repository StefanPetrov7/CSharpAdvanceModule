﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_01_CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> numbers = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (numbers.ContainsKey(input[i]) == false)
                {
                    numbers.Add(input[i], 0);
                }
                numbers[input[i]]++;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}
