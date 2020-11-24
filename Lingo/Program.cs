using System;
namespace Lingo
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            string[] wordlist = { "radio", "galds", "piens", "nazis", "pirms", "katls", "tilts", "siena", "laiks", "uguns" };
            Random rnd = new Random();
            int random = rnd.Next(wordlist.Length);
            string word = wordlist[random];
            string displayWord = word.Substring(0, 1) + "****";
            bool game = true;
            string end = "apnika";
            while (game)
            {
                Dispaly:
                Console.WriteLine("Jums ir jāmin vārds " + displayWord + ", lai minētu ivadiet vārdu, kas sastāv no pieciem burtiem, lai beigtu ievadat 'apnika'.");
                string guess = Console.ReadLine();
                if (string.Equals(guess, end))
                {
                    game = false;
                    break;
                }
                if(guess.Length > 5)
                {
                    Console.WriteLine("Jūsu ievadītais vārds ir pārāk garš.");
                    goto Dispaly;
                }
                    for (int i = 1; i < guess.Length; i++)
                    {
                        if (char.Equals(guess[i], word[i]))
                        {
                        string temp = guess[i].ToString();
                            displayWord = displayWord.Remove(i, 1).Insert(i, temp);
                        }
                    }
                char test = '*';
                if (!displayWord.Contains(test))
                {
                    Console.WriteLine("Jūs uzminējāt vārds " + displayWord + "!");
                    goto Start;
                }
            }

        }
    }
}
