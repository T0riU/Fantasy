using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy
{
    public abstract class Lizard : Creature
    {
        public Lizard(string name, string LastName, int HP, int Mana, int Power, int ManaUsage, int Resistance, int MagicResistance) : base(name, LastName, HP, Mana, Power, ManaUsage, Resistance, MagicResistance)
        {
            RegenStrengh = 40;
        }
        public virtual bool AB_Regen()
        {
            int temp = NowHP;
            temp = NowHP + RegenStrengh;
            if (temp >= HP)
            {
                NowHP = HP;
            }
            else { NowHP = temp; }
            return true;
        }
    }
}
