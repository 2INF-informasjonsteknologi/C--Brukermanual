using System;

class Program
{
    static void Main(string[] args)
    {
        // Velkomstmelding til spilleren
        Console.WriteLine("Velkommen til Gjett Tallet!");
        Console.WriteLine("Jeg har valgt et tilfeldig tall mellom 1 og 100.");
        Console.WriteLine("Prøv å gjette tallet!");

        // Generer et tilfeldig tall mellom 1 og 100
        Random random = new Random();
        int secretNumber = random.Next(1, 101);

        bool guessedCorrectly = false;
        int attempts = 0;

        // Fortsett å be spilleren om å gjette til de gjetter riktig tall
        while (!guessedCorrectly)
        {
            // Be spilleren om å gjette et tall
            Console.Write("Skriv inn ditt gjett: ");
            string input = Console.ReadLine();

            int guess;
            if (int.TryParse(input, out guess))
            {
                attempts++;

                // Sammenlign spillerens gjetning med det hemmelige tallet
                if (guess == secretNumber)
                {
                    guessedCorrectly = true;
                    Console.WriteLine($"Gratulerer, du gjettet riktig på {attempts} forsøk!");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Tallet er for lavt. Prøv igjen.");
                }
                else
                {
                    Console.WriteLine("Tallet er for høyt. Prøv igjen.");
                }
            }
            else
            {
                Console.WriteLine("Ugyldig inndata. Vennligst skriv inn et gyldig tall.");
            }
        }
    }
}
