using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace GameProg2_Project1FirstPlayable_NickPD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            ItemManager itemManager = new ItemManager();
            

            while (!GameManager.instance.CheckForDeaths())
            {
                GameManager.instance.Draw();

                ConsoleKey key = Console.ReadKey(true).Key; // get player input

                GameManager.instance.Update(key); // player then enemies move
            }

            Console.Clear();
            Console.WriteLine("Game Over.");
            Console.WriteLine("Press any key to close the game.");
            Console.ReadKey();
        }
    }
}
