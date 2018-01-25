using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ParseAndCount
    {
        public int PaC(string str)
        {
            if (str.Contains("Enter number:"))
            {
                var index = str.IndexOf(":");
                var a = str.Length - index - 1;
                return int.Parse(str.Substring(index + 1, a));
            }
            else if (str.Contains("Enter answer:"))
            {
                var index = str.IndexOf(":");
                var b = str.Length - index - 1;
                var sub = str.Substring(index + 1, b);
                var aa = Regex.Split(sub, "[+|-]");
                if (sub.Contains("+"))
                {
                    return aa.Sum(num => int.Parse(num));
                }

                if (sub.Contains("-"))
                {
                    return int.Parse(aa[0]) - int.Parse(aa[1]);
                }
            }

            return 0;
        }
    }
}