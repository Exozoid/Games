using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.Timers;


public class GameTimer
{
    private bool didnotLose;
    private static System.Timers.Timer aTimer;
    static void Main()
    {
        
        
        Console.WriteLine("  Quick Draw                                                     \r\n                                                                 \r\n  Face your opponent and wait for the signal. Once the           \r\n  signal is given, shoot your opponent by pressing [space]       \r\n  before they shoot you. It's all about your reaction time.      \r\n                                                                 \r\n  Choose Your Opponent:                                          \r\n  [1] Easy....1000 milliseconds                                  \r\n  [2] Medium...500 milliseconds                                  \r\n  [3] Hard.....250 milliseconds                                  \r\n  [4] Harder...125 milliseconds                                  \r\n  [any other key] give up                                               ");
        int choiceOfDifficulty = Convert.ToInt32(Console.ReadLine());
        while (true)
        {
            switch (choiceOfDifficulty)
            {
                case 1:
                    SetTimer();
                    aTimer = new System.Timers.Timer(1000);
                    aTimer.Elapsed += timedEvent;
                    aTimer.Start();
                    aTimer.Enabled = true;
                    aTimer.AutoReset = false;
                    if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        Console.Clear();
                        Console.WriteLine("\t                                                        \r\n\t                                                        \r\n\t            O__╔ <                                      \r\n\t           / \\                               \\\\         \r\n\t             /\\          You Win          /\\__\\O        \r\n\t            /  |                          /             \r\n\t  ------------------------------------------------------");
                    }
                    break;
                case 2:
                    SetTimer();
                    aTimer = new System.Timers.Timer(500);
                    aTimer.Elapsed += timedEvent;
                    aTimer.Start();
                    aTimer.Enabled = true;
                    aTimer.AutoReset = false;
                    if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        Console.Clear();
                        Console.WriteLine("\t                                                        \r\n\t                                                        \r\n\t            O__╔ <                                      \r\n\t           / \\                               \\\\         \r\n\t             /\\          You Win          /\\__\\O        \r\n\t            /  |                          /             \r\n\t  ------------------------------------------------------");
                    }
                    break;
                case 3:
                    SetTimer();
                    aTimer = new System.Timers.Timer(250);
                    aTimer.Elapsed += timedEvent;
                    aTimer.Start();
                    aTimer.Enabled = true;
                    aTimer.AutoReset = false;
                    if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        Console.Clear();
                        Console.WriteLine("\t                                                        \r\n\t                                                        \r\n\t            O__╔ <                                      \r\n\t           / \\                               \\\\         \r\n\t             /\\          You Win          /\\__\\O        \r\n\t            /  |                          /             \r\n\t  ------------------------------------------------------");
                    }
                    break;
                case 4:
                    SetTimer();
                    aTimer = new System.Timers.Timer(125);
                    aTimer.Elapsed += timedEvent;
                    aTimer.Start();
                    aTimer.Enabled = true;
                    aTimer.AutoReset = false;
                    if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        Console.Clear();
                        Console.WriteLine("\t                                                        \r\n\t                                                        \r\n\t            O__╔ <                                      \r\n\t           / \\                               \\\\         \r\n\t             /\\          You Win          /\\__\\O        \r\n\t            /  |                          /             \r\n\t  ------------------------------------------------------");
                    }
                    break;
                default:
                    break;
            }
        }
    }
    private static void timedEvent(Object source, ElapsedEventArgs e)
    {
        Console.WriteLine("\t  Quick Draw\r\n\t                                                        \r\n\t                                                        \r\n\t                                                        \r\n\t                                        > ╗__O          \r\n\t           //            Too Slow           / \\         \r\n\t          O/__/\\         You Lose          /\\           \r\n\t               \\                          |  \\          \r\n\t  ------------------------------------------------------");
    }
    public static void SetTimer()
    {
        
        Console.WriteLine("                                                                 \r\n  Quick Draw                                                     \r\n                                                                 \r\n                                                                 \r\n                                                                 \r\n              _O                          O_                     \r\n             |/|_          wait          _|\\|                    \r\n             /\\                            /\\                    \r\n            /  |                          |  \\                   \r\n  ------------------------------------------------------         ");
        Random random = new Random();
        int gameLength = random.Next(2000, 5000);
        var sw = new Stopwatch();
        sw.Start();
        while (true)
        {
            if (sw.ElapsedMilliseconds > gameLength)
            {
                Console.Clear();
                Console.WriteLine("\t  Quick Draw\r\n\t                                                        \r\n\t                         ********                       \r\n\t                         * FIRE *                       \r\n\t              _O         ********         O_            \r\n\t             |/|_                        _|\\|           \r\n\t             /\\          spacebar          /\\           \r\n\t            /  |                          |  \\          \r\n\t  ------------------------------------------------------");
                sw.Stop();
                break;
            }
            else if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                
                Console.WriteLine("\t                                                        \r\n\t                                                        \r\n\t                                                        \r\n\t                         Too Fast       > ╗__O          \r\n\t           //           You Missed          / \\         \r\n\t          O/__/\\         You Lose          /\\           \r\n\t               \\                          |  \\          \r\n\t  ------------------------------------------------------");
                Console.ReadLine();
                sw.Stop();
                break;
            }
        }
    }

    
}



