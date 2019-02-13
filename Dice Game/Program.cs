using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Console.WriteLine("Whats is player 1's name?");
            p1.name = Console.ReadLine();
            p1.Roll();

            Player p2 = new Player();
            Console.WriteLine("Whats is player 2's name?");
            p2.name = Console.ReadLine();
            p2.Roll();
            Console.WriteLine("{0} du slog {1}",p1.name ,p1.SumEyes);
            Console.WriteLine("{0} du slog {1}",p2.name ,p2.SumEyes);
        }
    }
}
