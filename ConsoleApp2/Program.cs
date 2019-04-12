using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Sohit Sharma
//C0730478
namespace Assignment5_section2
{
    class Program
    {
        static void Main(string[] args)
        {

            Program a = new Program();

            Console.WriteLine(a.MyfunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical engine"));
        }
        public string MyfunctionA(string input)
        {
            string[] words = input.Split(' ');
            int wordArraylength = words.Length;
            int[] wordsLength = new int[wordArraylength];

            for (int i = 0; i < words.Length; i++)
            {
                wordsLength[i] = words[i].Length;
            }

            string currentWord = words[0];
            string nextWord;

            for (int y = 0; y < words.Length - 1; y++)
            {
                currentWord = words[y];
                nextWord = words[y + 1];
            }
            return currentWord;
        }

    }
}