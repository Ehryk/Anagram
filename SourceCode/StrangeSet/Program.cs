using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeSet
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = args[0];
            string input2 = args[1];

            List<string> strangers = GetStrange(input1.ToLower(), input2.ToLower());

            foreach (string strange in strangers)
                Console.WriteLine(strange);
            
            Environment.Exit(0);
        }

        public static List<string> GetStrange(string word1, string word2)
        {
            HashSet<string> anagrams = new HashSet<string>();
            char[] characters = word1.ToCharArray().Concat(word2).Distinct().ToArray();

            foreach (IEnumerable<char> permutation in characters.GetPermutations())
            {
                anagrams.Add(new String(permutation.ToArray()));
            }

            return anagrams.OrderBy(x => x).ToList();
        }
    }
}
