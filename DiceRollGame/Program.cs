var main = new Main();
main.PlayGame();
Console.ReadKey();

class Main
{
    public void PlayGame()
    {
        Console.WriteLine("Welcome to guess the number! Press any key to continue");
        Console.ReadKey();
        var random = new Random();
        var dice = new Dice(random);
        dice.Roll();
        var guesses = new Guesses(dice);

        while (guesses.NumberOfGuesses != 0)
        {
            Console.WriteLine("Enter number: ");
            string userInput = Console.ReadLine();

            bool win = guesses.CheckGuess(userInput);
            if(win)
            {
                Console.WriteLine("You win!");
                break;
            }
        }
    }
}