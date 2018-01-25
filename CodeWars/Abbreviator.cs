using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class Abbreviator
    {
        public static string Abbreviate(string input)
        {
            if (input.Length <= 3)
            {
                return input;
            }
            var character = input.Where(c => c < 'a' || c > 'z').ToList().FirstOrDefault();

            if (character!=0)
            {
                var wordlist = input.Split(character).Select(Abbreviate).ToList();
                return wordlist.Aggregate((a, b) => a + character + b);
            }
            return input.First() + (input.Length - 2).ToString() + input.Last();
        }
    }
}
