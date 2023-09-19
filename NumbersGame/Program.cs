﻿using System;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckGuess();
        }
        public static void CheckGuess()
        {
            Random random = new Random();
            int number = random.Next(1, 21);
            int userGuess;
            int guesses = 5;
            while (guesses != 0)
            {
                Console.Clear();
                Console.Write("Välkommen! Jag tänker på ett nummer mellan 1-20. " +
                "Kan du gissa vilket? Du får fem försök.\nGissa: ");
                if (int.TryParse(Console.ReadLine(), out userGuess))
                {
                    if (userGuess == number)
                    {
                        Console.Clear();
                        Console.WriteLine("Woho! Du gjorde det!");
                        Console.ReadLine();
                        break;
                    }
                    else if (userGuess > number)
                    {
                        guesses--;
                        Console.Clear();
                        Console.Write($"Tyvärr du gissade {userGuess}, vilket är för högt!" +
                        $"\nDu har {guesses} gissningar kvar..");
                        Console.ReadKey();
                        continue;
                    }
                    else if (userGuess < number)
                    {
                        guesses--;
                        Console.Clear();
                        Console.Write($"Tyvärr du gissade {userGuess}, vilket är för lågt!" +
                        $"\nDu har {guesses} gissningar kvar..");
                        Console.ReadKey();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Du måste skriva in siffror!");
                    Console.ReadLine();
                    continue;
                }
            }
            if (guesses == 0)
            {
                Console.Clear();
                Console.WriteLine($"Du har tyvärr slut på gissningar.\nRätt svar var {number}!");
                Console.ReadLine();
            }
        }
    }
}