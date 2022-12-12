using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy
{
    public abstract class Draconian : Lizard
    {
        protected Draconian(string name, string LastName, int HP, int Mana, int Power, int ManaUsage, int Resistance, int MagicResistance) : base(name, LastName, HP, Mana, Power, ManaUsage, Resistance, MagicResistance)
        {
        }
        public virtual bool AB_FireAttack(Creature obj)
        {
            Attack(obj, (int)AttackType.PhysicalAndMagic, Power * 2);
            return true;
        }
    }
}
