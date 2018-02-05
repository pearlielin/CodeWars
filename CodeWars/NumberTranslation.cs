using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class NumberTranslation
    {
        private static Dictionary<int, string> _dictionary = new Dictionary<int, string>()
        {
            {0,"zero"},{1,"one"},{2,"two"},{3,"three"}
            ,{4,"four"},{5,"five"},{6,"six"},{7,"seven"}
            ,{8,"eight"},{9,"nine"},{10,"ten"},{11,"eleven"}
            ,{12,"twelve"},{13,"thirteen"},{14,"fourteen"},{15,"fifteen"}
            ,{16,"sixteen"},{17,"seventeen"},{18,"eighteen"},{19,"nineteen"}
            ,{20,"twenty"},{30,"thirty"},{40,"forty"},{50,"fifty"}
            ,{60,"sixty"},{70,"seventy"},{80,"eighty"},{90,"ninety"}
            ,{100,"hundred"},{1000,"thousand"}
            //,{,""}
        };

        public static string Number2Words(int n)
        {
            if (_dictionary.ContainsKey(n))
            {
                var head = string.Empty;
                if (n == 100 || n == 1000)
                {
                    head = "one ";
                }
                return head + _dictionary[n];
            }
            else
            {
                if (n < 100)
                {
                    return NumTranslateIn100(n);
                }

                if (n < 1000)
                {
                    return TranslateNumLessThan1000(n).Trim();
                }

                if (n < 100000)
                {
                    return NumTranslateIn100(n / 1000) + " " + _dictionary[1000] + " " +
                           TranslateNumLessThan1000(n%1000).Trim();
                }
                if (n < 1000000)
                {
                    return TranslateNumLessThan1000(n / 1000) + " " + _dictionary[1000] + " " 
                           + TranslateNumLessThan1000(n % 1000);
                }
                return String.Empty;
            }
        }

        private static string TranslateNumLessThan1000(int n)
        {
            return GetHundred(n) +" "+ NumTranslateIn100(n%100);
        }


        private static string GetHundred(int n)
        {
            if (n / 100 == 0)
                return string.Empty;
            else
                return _dictionary[n / 100] + " " + _dictionary[100];
        }

        private static string NumTranslateIn100(int n)
        {
            if (n == 0)
                return String.Empty;
            if (_dictionary.ContainsKey(n))
                return _dictionary[n];
            if (n / 10 != 0 && n % 10 != 0)
                return _dictionary[n / 10 * 10] + "-" + _dictionary[n % 10];
            if (n / 10 != 0)
                return _dictionary[n / 10 * 10];
            return _dictionary[n % 10];
        }
    }
}