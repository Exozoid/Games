using System;

string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

bool isComputerturn = true;
bool isPlayerturn = true;
Random random = new Random();
while (true)
{
    PrintGrid();

    if (isPlayerturn)
    {
        
        Console.WriteLine("It's the players turn, pick a number");
        string choice = Console.ReadLine();
        int gridIndex = Convert.ToInt32(choice) - 1;
        grid[gridIndex] = "X";
        bool checkWin = CheckWin();
        if (checkWin)
        {
            Console.WriteLine("You win");
            Console.ReadKey();
            break;
        }
        isPlayerturn = !isPlayerturn;
        Console.Clear();
    }
    
    else
    {
        while (true)
        {
            int newGridIndex = random.Next(0, 9);
            if (grid[newGridIndex] != "X" && grid[newGridIndex] != "O") // Check for both
            {
                grid[newGridIndex] = "O";
                isPlayerturn = !isPlayerturn;
                Console.WriteLine("Player 2 turn");
                bool _checkWin = CheckWin();
                if (_checkWin)
                {
                    Console.WriteLine("The computer has win");
                    Console.ReadKey();
                    break;
                }
                Console.Clear();
                break;
                
            }
        }

    }





}

bool CheckWin()
{
    bool row1 = grid[0] == grid[1] && grid[1] == grid[2];
    bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
    bool row3 = grid[6] == grid[7] && grid[7] == grid[8];
    bool column1 = grid[0] == grid[3] && grid[3] == grid[6];
    bool column2 = grid[1] == grid[4] && grid[4] == grid[7];
    bool column = grid[2] == grid[5] && grid[5] == grid[8];

    bool diagDown = grid[0] == grid[4] && grid[4] == grid[8];
    bool diagUp = grid[6] == grid[4] && grid[4] == grid[2];

    return row1 || row2 || row3 || column1 || column2 || column || diagDown || diagUp;
}
void PrintGrid()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(grid[i * 3 + j] + '|');
        }
        Console.WriteLine();
        Console.WriteLine("------");
    }
}


