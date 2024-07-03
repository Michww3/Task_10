using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Task_10;

abstract class MonsterAI
{
    private Random Random = new();

    protected int baseattackPower = 10;
    protected int basedefencePower = 10;
    protected string weapon = "None";
    protected string armor = "None";
    protected int HP = 100;

    public virtual int DefensePower { get; }
    public virtual int AttackPower { get; }

    public void TemplateMethod()
    {
        Attack();
        Defense();
    }

    public int Attack()
    {
        return AttackPower + Random.Next(-AttackPower / 10 , AttackPower / 10);
    }

    public int Defense()
    {
        return DefensePower;
    }

    protected void Heal(string potionName)
    {
        HP += Potion.GetPotionHeal(potionName);
        if (HP > 100) HP = 100;
    }

    public void ChangeWeapon(string weaponName)
    {
        weapon = weaponName;
    }
    public void ChangeArmor(string armorName)
    {
        armor = armorName;
    }
}
