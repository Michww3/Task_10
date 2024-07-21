using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Task_10;

abstract class MonsterAI
{
    private readonly Random random = new();

    protected int baseattackPower = 10;
    protected int basedefencePower = 10;
    protected string weapon = "None";
    protected string armor = "None";

    protected int HP = 100;

    public abstract int MaxHP { get; set; }
    public abstract int DefensePower { get; }
    public abstract int AttackPower { get; }

    public void TemplateMethod()
    {
        Attack();
        Defense();
    }

    public int Attack()
    {
        return AttackPower + random.Next(-AttackPower / 10, AttackPower / 10);
    }

    public int Defense()
    {
        return DefensePower;
    }

    protected void Heal(string potionName)
    {
        HP = Math.Min(MaxHP, HP += Potion.GetPotionHeal(potionName));
    }

    protected void Heal(int healStrength, Human entity)
    {
        entity.HP = Math.Min(MaxHP, HP += healStrength);
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
