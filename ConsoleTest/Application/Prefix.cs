using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTest
{
    public class Prefix
    {
        public static IEnumerable<string> AllPrefixes(int prefixLength, IEnumerable<string> words)
        {
            return words
                    .Where(w => w.Length >= prefixLength)
                    .Select(a => a.Substring(0, prefixLength))
                    .Distinct();
        }
    }
}
