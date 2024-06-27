using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Human : MonsterAI
{
    protected override void Heal()
    {
        Console.WriteLine("Heal human");
    }

    //protected override void Hook1() 
    //{
    //    Attack();
    //    Attack();
    //}
}