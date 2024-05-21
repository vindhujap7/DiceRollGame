using DiceRollGame;

Random random = new Random();
Dice dice = new Dice(random, 6);
GuessingGame game = new GuessingGame(dice);
game.Play();


Console.ReadKey();




