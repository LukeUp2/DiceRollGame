
class Guesses
{
    public int NumberOfGuesses { get; private set; }
    private readonly Dice _dice;

    public bool CheckGuess(string guess)
    {
        int validatedGuess = Validate(guess);
        if(validatedGuess == 0)
        {
            return false;
        }

        if (validatedGuess == _dice.NumberRolled)
        {
            return true;
        }
        else
        {
            
            UpdateNumberOfGuesses(-1);
            Console.WriteLine("Wrong number");
            if(NumberOfGuesses == 0)
            {
                Console.WriteLine("You lose :(");
            }
            return false;
        }
    }

    private int Validate(string guess)
    {
        try
        {
            int validated = int.Parse(guess);
            return validated;
        }
        catch
        {
            Console.WriteLine("Invalid Input");
            return 0;
        }
    }

    private void UpdateNumberOfGuesses(int value)
    {
        NumberOfGuesses = NumberOfGuesses + value;
    }


    public Guesses(Dice dice)
    {
        NumberOfGuesses = 3;
        _dice = dice;
    }
}
