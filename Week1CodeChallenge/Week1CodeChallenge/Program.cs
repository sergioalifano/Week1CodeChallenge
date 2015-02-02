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

            Console.WriteLine(Yodaizer("I like code"));

            TextStat("I am a badass programmer !!!");

            for (int i = 1; i <= 25; i += 2)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine("{0} is a prime number",i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine(DashInsert(454793));
            Console.WriteLine(DashInsert(8675309));

            Console.ReadKey();
        }

       /// <summary>
       /// This function return "Fizz" if the input number is divisible by 5, "Buzz" if is divisible by 3 and "FizzBuzz" if it's divisible by both
       /// </summary>
       /// <param name="number">the input number</param>
       /// <returns>returns either the string "Fizz","Buzz" or "FizzBuzz"</returns>
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

            //if the number is negative
            if (number < 0)
            {
                return string.Empty;
            }

            return number.ToString();
        }

        /// <summary>
        /// Takes a string and return the string in reverse order
        /// EXTRA: If the number of word is 3 output the last word first, followed by the first and the second.
        /// </summary>
        /// <param name="text">the input string to reverse</param>
        /// <returns>the string in reverse order</returns>
        public static string Yodaizer(string text)
        {
            string[] arrayOfWords = text.Split();
            string output = "";

            //check if the number of words is 3
            if (arrayOfWords.Length == 3)
            {
                //output the last word first, followed by the first and the second.
                output = arrayOfWords[2] + ", " + arrayOfWords[0] + " " + arrayOfWords[1];
                return output;
            }
            else
            {
                for (int i = arrayOfWords.Length-1; i >=0 ; i--)
                {
                    //output from the last word first
                    output += arrayOfWords[i]+" ";

                }

            }
            return output.Trim();
        }

        /// <summary>
        /// Take a sstring anf print of the number of characters,the number of words, the number of consonant and the number of special characters
        /// EXTRA: Print out the longest words, the second longest word and the shortest word
        /// </summary>
        /// <param name="input">the input string</param>
        static void TextStat(string input)
        {
            int numberOfChar = 0;
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
                //check the number of cosonants
                else if (char.IsLetter(inputLower[i]))
                {
                    numberOfConsonants++;
                }
               
            }
            Console.WriteLine("Number of vowels: {0}", numberOfVowels);
            Console.WriteLine("Number of consonants: {0}", numberOfConsonants);

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
            bool found = false;

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
            while (!found && index < arrayOfWords.Length)
            {
                if (arrayOfWords[index].Length == lengthEachWord[lengthEachWord.Length - 1])
                {
                    found = true;
                }
                else
                {
                    index++;
                }
                
            } 
            Console.WriteLine("The longest word is: " + arrayOfWords[index]);

            //we do the same with the second-last element of the sorted array to find the second longest word
            found = false;
            index = 0;
            while (!found && index < arrayOfWords.Length)
            {
                if (arrayOfWords[index].Length == lengthEachWord[lengthEachWord.Length - 2])
                {
                    found = true;
                }
                else
                {
                    index++;
                }
            } 
            Console.WriteLine("The second longest word is: " + arrayOfWords[index]);

            //now the first element of the sorted array will be the length of the shortest word
            found = false;
            index = 0;
            while (!found && index < arrayOfWords.Length)
            {
                if (arrayOfWords[index].Length == lengthEachWord[0])
                {
                    found = true;
                }
                else
                {
                    index++;
                }
            } 
            Console.WriteLine("The shortest word is: " + arrayOfWords[index]);

        }

        /// <summary>
        /// Check if the input number is a prime number
        /// </summary>
        /// <param name="number">the number to check</param>
        /// <returns>Return True if it's a prime number, False otherwise</returns>
        public static bool IsPrime(int number)
        {
            //We start the loop from the half of the number
            for (int i = number/2; i > 1; i--)
            {
                if (number % (i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// This function insert a dash between each two odd numbers
        /// </summary>
        /// <param name="number">the input number</param>
        /// <returns>Return a string with dashes bwtween each two odd numbers</returns>
        public static string DashInsert(int number)
        {
            int index = 0;
            int digit = 0;

            //we convert the number into a string
            string numberString = number.ToString();

            //the totalLenght of the string will change everytime a dashes is inserted
            int totalLength = numberString.Length;

            while (index < totalLength - 1)
            {
                //we convert each position of the string into a number
                digit = int.Parse(numberString[index].ToString());

                //if the digit is odd
                if (digit % 2 != 0)
                {
                    //we check the next digit
                    digit = int.Parse(numberString[index+1].ToString());
                    //if the next digit is odd
                    if (digit % 2 != 0)
                    {
                        //we insert a dash into the string
                        numberString = numberString.Insert(index + 1, "-");
                        index ++;

                        //the total length of the string is changed
                        totalLength++;
                    }
                    
                }
                index++;
            }
            return numberString;
        }
    }
}
