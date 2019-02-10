using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordFinderTask
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> wordsTream = new string[] { "chill", "cold", "wind","maxi" };
            IEnumerable<string> matrix = new string[] { "abcdm", "fgwia", "chilx", "pqnsi", "uvdxy" };

            IWordFinder wordFinder = new WordFinder(matrix);

            var list = wordFinder.Find(wordsTream);

            Console.WriteLine("*********Found words*********");

            foreach (string wordFound in list)
            {
                Console.WriteLine(wordFound);
            }
            Console.ReadLine();
        }
    }
}
