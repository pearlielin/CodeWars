using System;
using System.Collections.Generic;

namespace CodeWars
{
    public static class CatAndDog
    {
        public static int Solve(List<char> xs, int n)
        {
            var count = 0;
            var dogs = new List<int>();
            var cats = new List<int>();
            for (var i = 0; i < xs.Count; i++)
            {
                if (xs[i] == 'D')
                    dogs.Add(i);
                else if (xs[i] == 'C')
                    cats.Add(i);
            }

            foreach (var d in dogs)
            {
                for (var k = 0; k < cats.Count; k++)
                {
                    if (Math.Abs(d - cats[k]) <= n)
                    {
                        count++;
                        cats.Remove(cats[k]);
                        break;
                    }
                }
            }

            return count;
        }
    }
}