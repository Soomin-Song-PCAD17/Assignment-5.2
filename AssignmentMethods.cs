using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._2
{
    internal class AssignmentMethods
    {
        public static int LengthOfLastWord(string s)
        {
            string[] words = s.Trim().Split(' ');
            Console.WriteLine(s);
            Console.WriteLine($"The last word is '{words[words.Length-1]}' with Length {words[words.Length - 1].Length}");
            return words[words.Length - 1].Length;
        }

        public static void RecursivePrintNaturalNumbers(int n)
        {
            if (n <= 0) { return; }
            RecursivePrintNaturalNumbers(n-1);
            Console.Write($"{n} ");
        }

        public static void RecursivePrintNaturalNumbersReverse(int n)
        {
            if (n <= 0) { return; }
            Console.Write($"{n} ");
            RecursivePrintNaturalNumbersReverse(n-1);
        }

        public static bool IsPalindromeRecursion(string s)
        {
            if(s.Length<=1) { return true; }
            if (s[0] != s[s.Length-1]) { return false; }
            return IsPalindromeRecursion(s.Substring(1,s.Length-2));
        }
    }
}
