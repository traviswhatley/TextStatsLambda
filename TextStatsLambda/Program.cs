using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {


            TextStats("who is your daddy and what does he do?");
            Console.WriteLine();
            TextStats("how much wood could a woodchuck chuck, if a woodchuck could chuck norris?");


            Console.ReadKey();
        }

        static void TextStats(string input)
        {
            //standardize input
            input = input.ToLower();
            //# of letters
            Console.WriteLine("# of letters: " + input.Length);
            Console.WriteLine();
            //# of vowels
            Console.WriteLine("# of vowels: " + input.Where(x => "aeiou".Contains(x)).Count());
            Console.WriteLine();
            //# of consonants
            Console.WriteLine("# of consonants: " + input.Where(x => !"aeiou .!?,".Contains(x)).Count());
            Console.WriteLine();
            //# of special chars
            Console.WriteLine("# of spec chars: " + input.Where(x => ".!? ,".Contains(x)).Count());
            Console.WriteLine();
            //# of words
            Console.WriteLine("# of words: " + input.Split(' ').Count());
            Console.WriteLine();
            //longest word
            Console.WriteLine("Longest word: " + input.Replace(".", "").Split(' ').OrderByDescending(x => x.Length).First());
            Console.WriteLine();
            //second longest word
            Console.WriteLine("Second longest word: " + input.Split(' ').OrderByDescending(x => x.Length).Skip(1).Take(1).First());
            Console.WriteLine();
            //shortest word
            Console.WriteLine("Shortest word: " + input.Split(' ').OrderBy(x => x.Length).First());
            Console.WriteLine();
        }
    }
}
