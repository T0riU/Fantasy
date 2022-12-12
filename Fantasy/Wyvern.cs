using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy
{
    public class Wyvern : Draconian
    {
        public Wyvern(string Name, string LastName, int HP, int Mana, int Power, int ManaUsage, int Resistance, int MagicResistance) : base(Name, LastName, HP, Mana, Power, ManaUsage, Resistance, MagicResistance)
        {

        }
        public virtual bool AB_AirAttack(Creature obj)
        {
            Attack(obj, (int)AttackType.Magic, Power + 12);
            return true;
        }
    }
}
