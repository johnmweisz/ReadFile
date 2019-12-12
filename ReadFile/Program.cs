using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfWords(@"C:\Users\johnm\Desktop\test.txt"));
            Console.WriteLine(LongestWord(@"C:\Users\johnm\Desktop\test.txt"));
        }

        static int NumberOfWords(string path)
        {
            var allWords = File.ReadAllText(path, Encoding.Default);
            var wordArr = allWords.Split(' ');
            return wordArr.Length;
        }

        static string LongestWord(string path)
        {
            var allWords = File.ReadAllText(path, Encoding.Default);
            var wordArr = allWords.Split(' ');
            var longestWord = "";
            foreach (var word in wordArr)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            return longestWord;
        }
    }
}
