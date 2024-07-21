using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Cleric : Human
    {
        public void SmallHPBuff(Human human)
        {
            human.MaxHP =+ (int)(MaxHP * 0.25);
        }
    }
}
