public class Dice
{
    public int NumberRolled { get; private set; }
    private const int SidesCount = 6;
    private Random _random;

    public Dice(Random random)
    {
        _random = random;
    }

    public void Roll()
    {
        NumberRolled = _random.Next(1, SidesCount + 1);
        Console.WriteLine($"Dice rolled. Guess what number it shows in 3 tries.");
    }

}
