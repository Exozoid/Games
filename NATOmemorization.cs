
char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                    'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };


int randomIndex = new Random().Next(0, alphabet.Length);

char randomAlphabet = alphabet[randomIndex];

Console.WriteLine($"What is the code name of {randomAlphabet}");

string input = Console.ReadLine();

foreach(string n in Enum.GetNames(typeof(NatoPhoneticAlphabet)))
{
    try
    {
        bool startsWith = input.StartsWith(randomAlphabet);

        if (startsWith)
        {
            Console.WriteLine("you guessed correctly");
            break;

        }
    }
    catch(System.InvalidCastException)
    {
        throw new InvalidCastException("Please input something valid");
    }
}


    


public enum NatoPhoneticAlphabet
{
    Alpha,
    Bravo,
    Charlie,
    Delta,
    Echo,
    Foxtrot,
    Golf,
    Hotel,
    India,
    Juliett,
    Kilo,
    Lima,
    Mike,
    November,
    Oscar,
    Papa,
    Quebec,
    Romeo,
    Sierra,
    Tango,
    Uniform,
    Victor,
    Whiskey,
    Xray,
    Yankee,
    Zulu
}
