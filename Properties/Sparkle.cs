using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProg2_Project1FirstPlayable_NickPD
{
    public class Sparkle : Item
    {
        public Sparkle(int x, int y) : base(x, y, '*')
        {
            CollectMessage = "You found some gold";
            RemoveOnCollect = true;
        }
        
        public override void OnCollect(Player player)
        {
            GameManager.instance.gold += Settings.sparkleGold;
            GameManager.LastMessage = CollectMessage;
        }
    }
}
