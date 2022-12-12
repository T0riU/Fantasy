using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy
{
    public class Dragon : Draconian
    {
        public Dragon(string Name, string LastName, int HP, int Mana, int Power, int ManaUsage, int Resistance, int MagicResistance) : base(Name, LastName, HP, Mana, Power, ManaUsage, Resistance, MagicResistance)
        {

        }
        public virtual bool AB_StrongBite(Creature obj)
        {
            Attack(obj, (int)AttackType.Physical, (int)((double)Power*1.5));
            return true;
        }
    }
}
