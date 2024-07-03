using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal static class Potion
    {
        private static Dictionary<string, int> potions = new()
        {
            {"Small heal potion", 10 },
            {"Medium heal potion", 25 },
            {"Large heal potion", 50 },
            {"None", 0}
        };
        public static int GetPotionHeal(string potionName)
        {
            return potions[potionName];
        }
    }
}
