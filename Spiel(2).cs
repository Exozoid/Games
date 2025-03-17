


//Rpg ähnlichees zugbasiertes "Spiel" wo OOP und Logik benutzt werden. Aufgabe von dem Buch "The C# Player's Guide" Seite 125.
int enemyHealth = 10;
int cityHealth = 15;
int numberOfRounds = 0;

int manticoreDistance = askPlayer();


while (cityHealth > 0 && enemyHealth > 0)


{


        numberOfRounds += 1;
        Console.WriteLine($"The round number is {numberOfRounds} the health of the city is {cityHealth} and the health of the Manticore is {enemyHealth}");
        int playerGuess = askPlayer();
        if (playerGuess == manticoreDistance)
        {
            enemyHealth -= CannonDamage();
            Console.WriteLine("You hit the target");
            

        }
        else if (playerGuess > manticoreDistance)
        {
            Console.WriteLine("You guessed too high");
            cityHealth -= 1;
        }
        else if (playerGuess < manticoreDistance)
        {
            Console.WriteLine("You guessed too low");
            cityHealth -= 1;
        }

        if(cityHealth < 0)
        {
            Console.WriteLine("You're dead");
            break;
          }
        else if(enemyHealth < 0)
        {
        Console.WriteLine("You won the game");
        }
        


    
}



int askPlayer()
{
    while (true)
    {

        Console.WriteLine("What is the your guess, player ?");
        int allowedDistance = Convert.ToInt32(Console.ReadLine());
        if(allowedDistance <= 100 && allowedDistance >= 0)
        {
            Console.Clear();
            return allowedDistance;
        }
    }


}

int CannonDamage()
{
    while (true)
    {
        int cannonDamage = 0;
        
        if (numberOfRounds % 3 == 0 || numberOfRounds % 5 == 0)
        {
            Console.WriteLine("You dealt 10 dmg");
            return cannonDamage += 10;
        }
        else
        {
            Console.WriteLine("You dealt 1 dmg");
            return cannonDamage += 1;

        }
    }
}