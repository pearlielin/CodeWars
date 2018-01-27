using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class NotRandom
    {
        public static string NotSoRandom(double b, double w)
        {
            return b % 2 == 1 ? "Black" : "White";
        } 
    }
}
