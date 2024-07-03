using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_10;

class Human : MonsterAI
{
    public override int AttackPower
    { get { return (baseattackPower + 5) * Weapon.GetWeaponPower(weapon); } }
    public override int DefensePower
    { get { return (basedefencePower + 8) * Armor.GetArmorPower(armor); } }
}