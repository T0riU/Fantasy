using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantasy
{
    

    public class HighElf : Elf
    {
        protected int ComboNum = 1;
        protected bool Combo = false;
        public HighElf(string name, string LastName, int HP, int Mana, int Power, int ManaUsage, int Resistance, int MagicResistance) : base(name, LastName, HP, Mana, Power, ManaUsage, Resistance, MagicResistance)
        {

        }
        protected override bool Attack(Creature obj, int type, int pow)
        {
            Combo = false;
            ComboNum = 0;
            return base.Attack(obj, type, pow);
        }
        public virtual bool AB_ComboAttack(Creature obj)
        {
            Combo = true;
            base.Attack(obj, (int)AttackType.Magic, (int)((double)Power * 0.4*ComboNum));
            ComboNum++;
            return true;
        }
    }
}
