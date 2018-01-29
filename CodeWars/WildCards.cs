using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework.Interfaces;

namespace CodeWars
{
    public class WildCards
    {
        public List<string> Possibilities(string input)
        {
            var newlist = new List<string>();
            var templist = new List<string>();
            var count = input.Count(t => t == '?');
            var regex = new Regex(Regex.Escape("?"));
            newlist.Add(regex.Replace(input, "0", 1));
            newlist.Add(regex.Replace(input, "1", 1));

            NewMethod(newlist,count);

            return newlist;
        }

        private static void NewMethod(List<string> newlist,int count)
        {
            var regex = new Regex(Regex.Escape("?"));
            for(var i=0;i<=Math.Pow(2,count);i++)
            {
                foreach (var item in newlist)
                {
                    if (item.Contains("?"))
                    {
                        newlist.Add(regex.Replace(item, "0", 1));
                        newlist.Add(regex.Replace(item, "1", 1));
                        newlist.Remove(item);
                        break;
                    }
                }
            }
        }
    }
}
