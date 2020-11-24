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
            int random = rnd.Next(10);
            string word = wordlist[random];
            string displayWord = word.Substring(0, 1) + "****";
            bool game = true;
            string end = "apnika";
            while (game)
            {
                Dispaly:
                Console.WriteLine("Jums ir jāmin vārds " + displayWord + ", lai beigtu ievadat 'apnika'.");
                string guess = Console.ReadLine();
                if (string.Equals(guess, end))
                {
                    game = false;
                    break;
                }
                if(guess.Length > 1)
                {
                    Console.WriteLine("Jūs ievadījāt vairāk par vienu burtu.");
                    goto Dispaly;
                }
                for (int i = 1; i < word.Length; i++)
                {
                    char character = char.Parse(guess);
                    if (char.Equals(character, word[i]))
                    {
                        displayWord = displayWord.Remove(i, 1).Insert(i, guess);
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
