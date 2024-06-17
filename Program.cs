class Program
{
    public static void Main(string[] args)
    {
        Gamer.GamerCode(new Orc());
        Gamer.GamerCode(new Human());
    }
}


abstract class MonsterAI
{
    public void TemplateMethod()
    {
        Attack();
        Defence();
        Heal();
        Hook1();
    }

    protected void Attack()
    {
        Console.WriteLine("Attack");
    }
    protected void Defence()
    {
        Console.WriteLine("Defence");

    }
    protected abstract void Heal();

    protected virtual void Hook1() { }
}

class Orc : MonsterAI
{
    protected override void Heal()
    {
        Console.WriteLine("Heal");
    }
}

class Human : MonsterAI
{
    protected override void Heal()
    {
        Console.WriteLine("Heal");
    }

    protected override void Hook1() 
    {
        Attack();
        Attack();
    }
}

class Gamer
{
    public static void GamerCode(MonsterAI monster)
    {
        monster.TemplateMethod();
    }
}


