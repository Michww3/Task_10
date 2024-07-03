using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal static class Weapon
    {
        private static Dictionary<string, int> weapons = new()
        {
            {"two-handed sword", 10},
            {"Large axe", 12},
            {"Great hammer", 20},
            {"Dagger", 3},
            {"None", 1},
        };
        public static int GetWeaponPower(string weaponName)
        {
            return weapons[weaponName];
        }
    }
}
