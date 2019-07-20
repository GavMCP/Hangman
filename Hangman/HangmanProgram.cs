using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class HangmanProgram
    {

        public static int? Guesses = 10;
        public static string SecretWord = "";
        public static char[] SecretWordArray;
        public static List<char> PreviousGuesses = new List<char>();
        public static char LetterGuess;



        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to Hangman ***");
            Console.WriteLine("\nPlease enter your secret word...Then press enter.");
            SecretWord = Console.ReadLine();

            SecretWordArray = new char[SecretWord.Length];
            int counter = 0;
            foreach(char x in SecretWord)
            {
                SecretWordArray[counter] = x;
                counter++;
            }
            
            for(int x = 0; x < 50; x++)
            {
                Console.WriteLine("\n");
            }

            while(Guesses != 0)
            {
                Console.WriteLine("Enter your letter guess");
                LetterGuess = Convert.ToChar(Console.ReadLine());
                bool GoodGuess = false;
                foreach(char x in SecretWordArray)
                {
                    if(x == LetterGuess)
                    {
                        Console.WriteLine("Your letter is in the secret word!");
                        GoodGuess = true;
                    }
                    
                }
                if(!GoodGuess)
                {
                    Console.WriteLine($"I'm sorry, but the letter '{LetterGuess}' is not in the secret word.");
                    PreviousGuesses.Add(LetterGuess);
                }

                
                
                Console.WriteLine($"You only have {Guesses} guess left!!");
                
            }

        }
    }
}
