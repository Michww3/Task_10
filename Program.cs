class Program
{
    public static void Main(string[] args)
    {
        //Gamer.GamerCode(new Orc());
        //Gamer.GamerCode(new Human());

        var human = new Human();

        human.ChangeWeapon("Dagger");
        human.ChangeArmor("Iron armor");
        human.Attack();

        Console.WriteLine(human.AttackPower);
        Console.WriteLine(human.DefensePower);
    }
}