using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal static class Armor
    {
        static Dictionary <string , int> armors = new()
        {
            {"Wood Armor", 3 },
            {"Iron armor", 5 },
            {"Dragon bone armor", 10 },
            {"None", 1 },
        };
        public static int GetArmorPower(string armorName)
        {
            return armors[armorName];
        }
    }
}
