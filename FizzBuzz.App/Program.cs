using System;
using System.Collections.Generic;

namespace FizzBuzz.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzLibrary = new FizzBuzzLibrary();

            var combinations = new List<Tuple<int, string>>
            {
                new Tuple<int, string> (3, "Fizz"),
                new Tuple<int, string> (5, "Buzz"),
            };

            for (var i = 1; i < 100; i++)
            {
                //Console.WriteLine(fizzBuzzLibrary.ChkNumber(i));
                Console.WriteLine(fizzBuzzLibrary.ChkFizzBuzz(combinations, i));
            }

            Console.ReadLine();
        }
    }
}
