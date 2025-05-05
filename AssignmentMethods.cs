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
    }
}
