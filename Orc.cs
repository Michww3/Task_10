using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_10;

class Orc : MonsterAI
{
    public override int AttackPower
    { get { return (baseattackPower + 10) * Weapon.GetWeaponPower(armor); } }
    public override int DefensePower
    { get { return (basedefencePower + 5) * Armor.GetArmorPower(armor); } }
}