using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }

            for (int i = 92; i >= 79; i--)
            {
                FizzBuzz(i);
            }

            Console.WriteLine(Yodaizer("challenge code"));

            TextStat("Let's see if the method works fine!!!");

            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string FizzBuzz(int number)
        {
            //if number is divisible by 3
            if (number % 3 == 0 && number % 5 != 0)
            {
                return "Buzz";
            }

            //if number is divisible by 3 and 5
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }

            //if number is divisible by 5
            if (number % 3 != 0 && number % 5 == 0)
            {
                return "Fizz";
            }
            if (number < 0)
            {
                return string.Empty;
            }

            return number.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Yodaizer(string text)
        {
            string[] arrayOfWords = text.Split();
            string output = "";

            if (arrayOfWords.Length == 3)
            {
                output = arrayOfWords[2] + ", " + arrayOfWords[0] + " " + arrayOfWords[1];
                return output;
            }
            else
            {
                for (int i = arrayOfWords.Length-1; i >=0 ; i--)
                {
                    output += arrayOfWords[i]+" ";

                }

            }
            return output.Trim();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        static void TextStat(string input)
        {
            int numberOfChar = 0;
            int numberOfWords = 0;
            int numberOfVowels = 0;
            int numberOfConsonants = 0;
            int numberOfSpecialCharacters = 0;

            //check the number of characters 
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]))
                    numberOfChar++;
            }
            Console.WriteLine("Number of characters: {0}",numberOfChar);

            //check the number of words
            string[] arrayOfWords = input.Split();
            Console.WriteLine("Number of words: {0}",arrayOfWords.Length);

            //check the number of vowels
            string inputLower=input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if (inputLower[i] == 'a' || inputLower[i] == 'e' || inputLower[i] == 'i' || inputLower[i] == 'o' || inputLower[i] == 'u')
                {
                    numberOfVowels++;
                }
            }
            Console.WriteLine("Number of vowels: {0}", numberOfVowels);

            //check the number of special characters
            for (int i = 0; i < input.Length; i++)
			{
                if (!Char.IsLetterOrDigit(input[i]))
                {
                    numberOfSpecialCharacters++;
                }
			}
            Console.WriteLine("Number of special characters: {0}", numberOfSpecialCharacters);

            //EXTRA: check the longest word,the second longest word and the shortest word
            string longestWord = string.Empty;
            string secondLongestWord = string.Empty;
            string shortestWord = string.Empty;
            bool found = false;

            //we assume that the first word is the longest
            longestWord = arrayOfWords[0];
           // for (int i = 1; i < arrayOfWords.Length; i++)
            //{
            //    //find the longest and the second longest word starting from the second string of the array
            //    if (arrayOfWords[i].Length >= longestWord.Length)
            //    {
            //        longestWord = arrayOfWords[i];
            //        secondLongestWord = arrayOfWords[i];
            //    }
               
            //    //if the first word was actually the longest we need to find the second longest word
            //    if (string.IsNullOrEmpty(secondLongestWord) && arrayOfWords.Length >=2)
            //    {
            //        //we assume that the second word is the second longest word of the array
            //        secondLongestWord = arrayOfWords[1];
            //        for (int j = 2; j < arrayOfWords.Length; j++)
            //        {
            //            if (arrayOfWords[j].Length > secondLongestWord.Length)
            //            {
            //                secondLongestWord = arrayOfWords[j];
            //            }
            //        }
            //    }
            //    else if (arrayOfWords.Length >= 2)
            //    {
            //        for (int x = 0; x < arrayOfWords.Length; x++)
            //        {
            //            if (arrayOfWords[x].Length > secondLongestWord.Length)
            //            {

            //                secondLongestWord = arrayOfWords[x];
            //            }
            //        }
            //    }
               


            //}

            //we create an array with the length of each word of the input
            int[] lengthEachWord = new int[arrayOfWords.Length];
            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                lengthEachWord[i] = arrayOfWords[i].Length;
            }

            //we sort the array from the shortes to the longest number
            Array.Sort(lengthEachWord);

            //now we know that the last element of the sorted array is the length of the longest word
            //so we compare each word's length of the arrayOfWords with the last element of the sorted array to find the longest word
            int index = 0;
            while (!found || index<arrayOfWords.Length)
            {
                if (arrayOfWords[index].Length == lengthEachWord[lengthEachWord.Length - 1])
                {
                    found = true;
                }
            } 
            Console.WriteLine("The longest word is: " + arrayOfWords[index]);

            //we do the same with the second-last element of the sorted array
            found = false;
            index = 0;
            while (!found || index < arrayOfWords.Length)
            {
                if (arrayOfWords[index].Length == lengthEachWord[lengthEachWord.Length - 2])
                {
                    found = true;
                }
            } 
            Console.WriteLine("The second longest word is: " + arrayOfWords[index]);

            //now the first element of the sorted array will be the length of the shortest word
            found = false;
            index = 0;
            while (!found || index < arrayOfWords.Length)
            {
                if (arrayOfWords[index].Length == lengthEachWord[0])
                {
                    found = true;
                }
            } 
            Console.WriteLine("The shortest word is: " + arrayOfWords[index]);

        }
        public static bool IsPrime(int number)
        {
            return true;
        }
        public static string DashInsert(int number)
        {
            return string.Empty;
        }
    }
}
