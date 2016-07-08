using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = args[0];

            List<string> anagrams = GetAnagrams(input.ToLower());

            foreach (string anagram in anagrams)
                Console.WriteLine(anagram);
            
            Environment.Exit(0);
        }

        public static List<string> GetAnagrams(string word)
        {
            HashSet<string> anagrams = new HashSet<string>();
            char[] characters = word.ToCharArray();

            foreach (IEnumerable<char> permutation in characters.GetPermutations())
            {
                anagrams.Add(new String(permutation.ToArray()));
            }

            return anagrams.OrderBy(x => x).ToList();
        }
    }
}
