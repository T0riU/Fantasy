using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantasy
{
    public class Orc : Elf
    {
        int TempResistance=80;
        bool PlayDead = false;
            public Orc(string name, string LastName, int HP, int Mana, int Power, int ManaUsage, int Resistance, int MagicResistance) : base(name, LastName, HP, Mana, Power, ManaUsage, Resistance, MagicResistance)
            {

            }
        public override bool TakeDamage(Creature attcaker, int Damage)
        {
            if (PlayDead) { Damage = (int)(Damage * (double)(100 - TempResistance) / 100); PlayDead = false; }
            return base.TakeDamage(attcaker, Damage);
        }
        public virtual bool AB_PlayDead()
        {
            PlayDead = true;
            return true;
        }
    }
}
