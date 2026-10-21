using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProg2_Project1FirstPlayable_NickPD
{
    internal class Shop : Item
    {
        public (int startY, int startX, int endY, int endX) BonesTiles { get; set; }

        public Shop(int x, int y) : base(x, y, '?')
        {
            CollectMessage = "The spirits are asking for just 5 points of your health for their assistance. Do you accept? \nPress Y to accept, any other key to decline.";
            
        }

        public override void OnCollect(Player player)
        {
            Console.SetCursorPosition(0, Console.CursorTop);             // I don't know why this is needed when it works fine for health potions and sparkles
            Console.WriteLine(CollectMessage);

            var input = Console.ReadKey(true).Key;

            
        }
    }
}
