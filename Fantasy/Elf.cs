using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy
{
    public abstract class Elf : Fairy
    {
        public Elf(string name, string LastName, int HP, int Mana, int Power, int ManaUsage, int Resistance, int MagicResistance) : base(name, LastName, HP, Mana, Power, ManaUsage, Resistance, MagicResistance)
        {
            RegenStrengh = 20;
        }

        public virtual bool AB_RegenByMagic()
        {
            int temp = NowHP + RegenStrengh;
            int tempmana = NowMana - ManaUsage;
            if (tempmana < 0) { return false; }
            if (temp >= HP)
            {
                NowHP = HP;
            }
            else { NowHP = temp; }
            NowMana = tempmana;
            return true;
        }
    }
}
