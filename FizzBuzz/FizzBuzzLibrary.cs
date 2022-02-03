using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzLibrary
    {
        public string ChkNumber(int numberToVerify)
        {
            if (numberToVerify % 3 == 0 && numberToVerify % 5 == 0)
                return "FizzBuzz";

            if (numberToVerify % 3 == 0)
                return "Fizz";

            return numberToVerify % 5 == 0
                ? "Buzz" 
                : numberToVerify.ToString("N");
        }

        public string ChkFizzBuzz(IEnumerable<Tuple<int, string>> combinations, int number)
        {
            //Func<int, int, bool> isMatch = (i, comb) => i % comb == 0;

            var matchingCombs = combinations.Where(c => IsMatch(number, c.Item1)).ToList();

            if (matchingCombs.Any())
                return string.Join("", matchingCombs.Select(c => c.Item2));

            return number.ToString("N");
        }

        private static bool IsMatch(int i, int comb) => i % comb == 0;
    }
}
