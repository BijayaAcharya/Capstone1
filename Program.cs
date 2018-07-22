using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to the Pig Translator!"); 

            while (true) // loop until the condition is true
            {

                Console.WriteLine("Please enter a sentence"); // user input
                string input = Console.ReadLine().ToLower().Trim(); // reading the user input and storing it in the variable input; changing it to lower case and also removing the spaces
                String[] arrayOfCharrs = input.Split(new char[] { ' ' }); // spliting the input based on space and storing them into array
                String pigLatin = ""; // declaring pigLatin variable with empty value

                foreach (string character in arrayOfCharrs) // looping through the each word in the array
                {
                    String firstWord = character; // declaring variable
                    char FirstLetter = firstWord[0]; // accessing and saving first letter of the word of the user input

                    firstWord = firstWord.Remove(0, 1); // removing the first character of the word
                    firstWord = firstWord.Insert(firstWord.Length, FirstLetter.ToString()); // inserting first letter at the end of the  word.for eg(ailus)

                    if (IsVowel(FirstLetter)) // invoking the method to check if first letter is vowel
                    {
                        firstWord = firstWord.Insert(firstWord.Length, "way"); // if it's a vowel, adding "way" 
                    }
                    else
                    {
                        firstWord = firstWord.Insert(firstWord.Length, "ay"); // if it's consonant, adding "ay"
                    }

                    pigLatin = pigLatin.Insert(pigLatin.Length, firstWord + " ");  // inserting either way or ay at the end of the firstword .for eg(ailusay)
                }

                Console.WriteLine(pigLatin); // displaying piglatin to the console

                Console.WriteLine(" Do you want to play again ? y/n");

                string inputSecond = Console.ReadLine().ToLower();
                if (inputSecond == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
                
            }
            Console.ReadLine();


        }
        
        // creating method that takes character as parameter and returns bool type
        public static bool IsVowel(char character) 
        {

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            if (vowels.Contains(character))
            {
                return true;

            }
            else
            {
                return false;
            }
        }


    }
}

    


    




