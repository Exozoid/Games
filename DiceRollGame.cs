using System;

public class Program
{
    public static void Main()
    {
        UserDiceRoll userDiceRoll = new UserDiceRoll();
        string userInput = userDiceRoll.GetInput();
        Console.WriteLine("You entered: " + userInput);

        int diceRoll = userDiceRoll.RandomDiceRoll;
        Console.WriteLine("You rolled: " + diceRoll);
    }
}

public class UserDiceRoll
{
    private static Random _random = new Random();

    public string GetInput()
    {
        Console.WriteLine("Enter your input:");
        return Console.ReadLine();
    }

    public int RandomDiceRoll => _random.Next(1, 7);
}
