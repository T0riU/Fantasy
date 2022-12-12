using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy
{
    public class Player : Creature
    {
        public Player(string name, string LastName, int HP, int Mana, int Power, int ManaUsage, int Resistance, int MagicResistance) : base(name, LastName, HP, Mana, Power, ManaUsage, Resistance, MagicResistance)
        {
            RegenStrengh = 10;
        }

    }
}
