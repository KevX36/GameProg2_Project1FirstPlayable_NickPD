using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProg2_Project1FirstPlayable_NickPD
{
    // global or settings class that stores game data (alleviates hardcoding)
    //  variables could be set as constants so that they cannot be changed
    //  although globally accessible
    public class Settings
    {
        // Player
        public static int PlayerStartHealth = 80;

        // Enemy stats
        public static int BossBarbarianHealth = 32;
        public static int BarbarianHealth = 16;
        public static int MageHealth = 12;
        public static int TheifHealth = 16;
        public static int MyrmidonHealth = 16;
        //enemy gold dropped
        public static int BossBarbarianGold = 100;
        public static int BarbarianGold = 30;
        public static int MageGold = 20;
        public static int TheifGold = 50;
        public static int MyrmidonGold = 30;
        //shop prices
        public static int healthPotionCost = 15;
        public static int repairCost = 5;
        // Health potion amount
        public static int HealthPotion = 20;

        // weapon default durrability
        public static int bronzeSwordDurability = 19;
        public static int ironSwordDurability = 14;
        public static int steelSwordDurability = 9;
        public static int silverSwordDurability = 5;
        //amount of durability regained from fixing a sword at the shop
        public static int bronzeSwordDurabilityRepaired = 10;
        public static int ironSwordDurabilityRepaired = 7;
        public static int steelSwordDurabilityRepaired = 4;
        public static int silverSwordDurabilityRepaired = 2;

        //gold gained from sparkle
        public static int sparkleGold = 5;



    }
}
