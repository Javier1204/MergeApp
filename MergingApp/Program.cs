using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome To MergeApp");
                Console.WriteLine("To start enter the first word to merge");
                string word1 = Console.ReadLine();
                Console.WriteLine("Let's continue, enter the second word to merge");
                string word2 = Console.ReadLine();
                string result = Merge(word1, word2);
                Console.WriteLine("Result MergedString: " + result);
                Console.WriteLine("Do you wish continue? y/n");
                string yn = Console.ReadLine();
                if ("n".Equals(yn))
                {
                    break;
                }
            }
        }

        public static string Merge(string word1, string word2)
        {
            string resultWord = "";
            string extras = "";
            int size = GetMajor(word1.Length, word2.Length);
            for(int i = 0; i< size; i++)
            {
                if (i < word1.Length)
                {
                    if (Char.IsLetter(word1[i]))
                    {
                        resultWord += word1[i];
                    } else
                    {
                        extras += word1[i];
                    }
                } 
                if (i < word2.Length)
                {
                    if (Char.IsLetter(word2[i]))
                    {
                        resultWord += word2[i];
                    }
                    else
                    {
                        extras += word2[i];
                    }
                }
            }
            resultWord += extras;
            return resultWord;
        }

        public static int GetMajor(int size1, int size2)
        {
            if(size1 > size2)
            {
                return size1;
            } else
            {
                return size2;
            }
        }

    }
}
