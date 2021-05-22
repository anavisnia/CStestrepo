using System;
using System.Collections.Generic;

namespace FirstConsoleAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter a value");

            //string stringValue = Console.ReadLine();

            //int number;
            //bool outcome = int.TryParse(stringValue, out number);

            //if(outcome == true)
            //{
            //    Console.WriteLine(number + 1);
            //}
            //else
            //{
            //    Console.WriteLine("Could not parse");
            //}

            //List<int> numbers = new List<int> {3, 4, 5 };
            //numbers.Add(6);
            //numbers.Add(7);
            //numbers.Add(8);

            //int[] numbersArray = new int[] { 3, 4, 5 };
            //numbersArray[3] = 6;
            //numbersArray[4] = 7;
            //numbersArray[5] = 8;

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("");

            //for (int i = 0; i < numbersArray.Length; i++)
            //{
            //    Console.WriteLine(numbersArray[i]);
            //}

            //Console.WriteLine("");

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int output = 1 + 5;

            //var output2 = output * 20.54;

            //Console.WriteLine(output);

            //Console.WriteLine("Galime rasyti");
            //var input = Console.ReadLine();
            //int number; // by default reiksme - 0
            //var succeeded = Int32.TryParse(input, out number);
            //if(succeeded)
            //{
            //    Console.WriteLine($"Numeric input was '{number}'");
            //}
            //else
            //{
            //    Console.WriteLine("Error while parsing");
            //}

            // pagal default console nuskaito stringa
            // nullable parameter int? number - tuscia - null

            var numbers = new List<int>()
            {
                1, 2, 3
            };
            foreach (int number in numbers)
            {
                Console.WriteLine($"Number is {number}");
            }
        }
    }
}
