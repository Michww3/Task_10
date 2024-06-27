using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class MonsterAI
{
    public void TemplateMethod()
    {
        Attack();
        Defence();
        Heal();
        //Hook1();
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

}
