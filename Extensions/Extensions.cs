using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class Extensions
    {
        public static bool GetOddIndexNumbers(this IEnumerable<int> source, out List<int> lll)
        {
            lll = new List<int>();
            bool hasElement = false;
            int count = 0;
            foreach (var item in source)
            {
                if (count % 2 == 1)
                {
                    lll.Add(item);
                }
                count += 1;
                hasElement = true;
            }
            return hasElement;
        }
        public static bool GetSumOfEvenNumbers(this IEnumerable<int> source, out int sum)
        {
            bool hasElement = false;
            sum = 0;
            foreach (var item in source)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                    hasElement = true;
                }
            }
            return hasElement;
        }
        public static bool _IsNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return source != null && source.Count() > 0;
        }
        public static bool WordFromThirdLettersOfString(this string source, out string word)
        {
            bool hasElement = false;
            word = default(string);
            int count = 0;
            foreach (var item in source)
            {
                if (count % 3 == 0)
                {
                    word += item;
                }
                count += 1;
                hasElement = true;
            }
            return hasElement;
        }
        public static string FirstAndLast(this string source)
        {
            return (String.Concat( source[0] ,source[source.Length - 1]));
        }
       
    }
}
