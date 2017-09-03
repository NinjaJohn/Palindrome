using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string Word;
            string Reverse = "";
            bool Forever = true;

            while (Forever)
            {
                Console.WriteLine("Skriv in ditt ord för att kontrollera om det är en Palindrom");
                Word = Console.ReadLine();

                if (Word == "sluta")
                {
                    break;
                }

                for (int i = Word.Length - 1; i >= 0; i--)
                {
                    Reverse += Word[i].ToString();
                }

                if (Reverse == Word)
                {
                    Console.WriteLine("Strängen är en Palindrom \nDu skrev {0} och baklänges är det {1}", Word, Reverse);
                }

                else
                {
                    Console.WriteLine("Strängen är inte en Palindrom \nDu skrev {0} och baklänges är det {1}", Word, Reverse);
                }


                Console.ReadKey();
                Console.Clear();
            }

            
        }
    }
}