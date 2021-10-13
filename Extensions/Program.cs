using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----------------------------------------------------*/

            string a = "abcdefghijklmnop";
            bool b = a.WordFromLettersOfString(out string word);
            Console.WriteLine(word);
           
            Console.WriteLine(a.FirstAndLast());
           
            /*----------------------------------------------------*/

            List<int> numbers = new List<int>() { 12, 4, 5, 17, 2 };

            numbers.GetSumOfEvenNumbers(out int sum);
            Console.WriteLine(sum);

            numbers.GetOddIndexNumbers(out List<int> lll);
            foreach (var item in lll)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(numbers._IsNullOrEmpty());

        }
    }
}
