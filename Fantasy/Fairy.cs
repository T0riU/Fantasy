using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy
{
    public abstract class Fairy : Creature
    {
        public Fairy(string name, string LastName, int HP, int Mana, int Power, int ManaUsage, int Resistance, int MagicResistance) : base(name, LastName, HP, Mana, Power, ManaUsage, Resistance, MagicResistance)
        {
        }
        public virtual bool AB_NatureMagic(Creature obj)
        {

            Attack(obj, (int)AttackType.Magic, (int)((double)HP * 0.1+(double)Power/2));
            return true;
        }
    }
}
