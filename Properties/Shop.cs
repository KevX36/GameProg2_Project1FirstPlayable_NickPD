using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProg2_Project1FirstPlayable_NickPD
{
    internal class Shop : Item
    {
        public int healthPotionCost = Settings.healthPotionCost;
        public int repairCost = Settings.repairCost;
        
        public (int startY, int startX, int endY, int endX) BonesTiles { get; set; }

        public Shop(int x, int y) : base(x, y, '$')
        {
            CollectMessage = $"You've found a shop \nPress 1 to buy a health potion for {healthPotionCost}\npress 2 to go to weapon repair  for {repairCost}\npress 3 to go to weapon repair  for {repairCost*2}\npress 4 to go to weapon repair  for {repairCost*3}\npress 5 to go to weapon repair  for {repairCost*4}\npress anything else to return";
            RemoveOnCollect = false;
        }

        public override void OnCollect(Player player)
        {
            Console.SetCursorPosition(0, Console.CursorTop); //i reused part of the question event for the shop so this may or may not be needed
            Console.WriteLine(CollectMessage);
            RemoveOnCollect = false;
            var input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.D1)
            {
                if(GameManager.instance.gold >= healthPotionCost)
                {
                    Console.WriteLine($"you bought a health potion, you restored {Settings.HealthPotion} health");
                    GameManager.instance.gold -= healthPotionCost;
                    GameManager.instance.player.Health.Heal(Settings.HealthPotion);
                }
                else
                {
                    Console.WriteLine("you couldn't afford to buy the health potion");
                }
                    Console.ReadKey(true);
            }
            else if (input == ConsoleKey.D2)
            {
                if (GameManager.instance.gold >= repairCost)
                {
                    GameManager.instance.gold -= repairCost;
                    GameManager.instance.player.Weapons[0].Repair(Settings.bronzeSwordDurabilityRepaired);
                    Console.WriteLine("you repaired your bronze sword");
                }
                else
                {
                    Console.WriteLine("you couldn't afford the repair cost");
                }
                Console.ReadKey(true);
            }
            else if (input == ConsoleKey.D3)
            {
                if (GameManager.instance.gold >= repairCost*2)
                {
                    GameManager.instance.gold -= repairCost*2;
                    GameManager.instance.player.Weapons[1].Repair(Settings.ironSwordDurabilityRepaired);
                    Console.WriteLine("you repaired your iron sword");
                }
                else
                {
                    Console.WriteLine("you couldn't afford the repair cost");
                }
                Console.ReadKey(true);
            }
            else if (input == ConsoleKey.D4)
            {
                if (GameManager.instance.gold >= repairCost*3)
                {
                    GameManager.instance.gold -= repairCost * 3;
                    GameManager.instance.player.Weapons[2].Repair(Settings.steelSwordDurabilityRepaired);
                    Console.WriteLine("you repaired your steel sword");
                }
                else
                {
                    Console.WriteLine("you couldn't afford the repair cost");
                }
                Console.ReadKey(true);
            }
            else if (input == ConsoleKey.D5)
            {
                if (GameManager.instance.gold >= repairCost*4)
                {
                    GameManager.instance.gold -= repairCost*4;
                    GameManager.instance.player.Weapons[3].Repair(Settings.silverSwordDurabilityRepaired);
                    Console.WriteLine("you repaired your silver sword");
                }
                else
                {
                    Console.WriteLine("you couldn't afford the repair cost");
                }
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("You left without buying anything");
                Console.ReadKey(true);
                
            }

        }
    }
}
