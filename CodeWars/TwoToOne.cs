using System;
using System.Linq;

namespace CodeWars
{
    public class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            var output = (s1 + s2).ToCharArray().Distinct().ToArray();
            Array.Sort(output);
            return new string(output);
        }
    }
}