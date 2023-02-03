using System;

namespace Longest_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestWord(Console.ReadLine()));
        }

        public static string LongestWord(string sen)
        {
            string result = string.Empty;
            string longestWord = string.Empty;

            for (int i = 0; i < sen.Length; i++)
            {
                if (char.IsLetterOrDigit(sen[i]))
                {
                    result += sen[i];

                    if(longestWord.Length < result.Length)
                    {
                        longestWord = result;
                    }
                }
                else
                {
                    result = string.Empty;
                }

            }
            sen = longestWord;
            return sen;

        }
    }

}
