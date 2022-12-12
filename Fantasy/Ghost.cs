using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy
{
    public class Ghost : Undead
    {
        public Ghost(string Name, string LastName, int HP, int Mana, int Power, int ManaUsage, int Resistance, int MagicResistance) : base(Name, LastName, HP, Mana, Power, ManaUsage, Resistance, MagicResistance)
        {

        }
        public virtual bool AB_Scream(Creature obj)
        {
            Attack(obj, (int)AttackType.Magic, (int)((double)Power * 1.1));
            return true;
        }
    }
}
