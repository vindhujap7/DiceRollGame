using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    internal class GuessingGame
    {       
        private readonly Dice _dice;
        private const int InitialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }
        public void Play()
        {
            var diceRollResult = _dice.Roll();
            int triesLeft = InitialTries;
            Console.WriteLine($"Dice rolled! Guess what number it shows in {InitialTries} tries");
            while (triesLeft > 0)
            {
                Console.WriteLine("Enter a number");
                string enteredInput = Console.ReadLine();
                int checkEnteredInput;
                if ((int.TryParse(enteredInput, out checkEnteredInput)) && (checkEnteredInput > 0) && (checkEnteredInput < 7))
                {
                    if (checkEnteredInput == diceRollResult)
                    {
                        Console.WriteLine("You win!!");                     
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Wrong guess");
                    }
                    triesLeft--;
                }
                else
                {
                    Console.WriteLine("Please enter a valid input or a number between 1 to 6");
                }
            }
            Console.WriteLine("You Lose:(");
            Console.WriteLine($"The correct number was {diceRollResult}");
        }        
    }
}
