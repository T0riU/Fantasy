using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy
{
    public abstract class Undead : Creature
    {
        protected int ToggleRes;
        protected int ToggleMagicRes;
        protected bool Block = false;
        public Undead(string Name, string LastName, int HP, int Mana, int Power, int ManaUsage, int Resistance, int MagicResistance) : base(Name, LastName, HP, Mana, Power, ManaUsage, Resistance, MagicResistance)
        {
            ToggleMagicRes = new int();
            ToggleRes = new int();
        }
        protected override bool Attack(Creature obj, int type, int pow)
        {
            if (Block) {
                BlockDamage(0);
            }
            return base.Attack(obj, type, pow);
        }
        public virtual bool AB_BlockAllDamage()
        {
            return BlockDamage(100);
        }
        protected virtual bool BlockDamage(int BlockStrengh, bool BlockMagic = true, bool BlockPsysical = true)
        {
            Block = !Block;
            if (Block)
            {
                if (BlockMagic) { ToggleMagicRes = MagicResistance; MagicResistance = BlockStrengh; }
                if (BlockPsysical) { ToggleRes = Resistance; Resistance = BlockStrengh; }
            }
            else
            {
                if (BlockMagic){ MagicResistance = ToggleMagicRes; }
                if (BlockPsysical) { Resistance = ToggleRes; }
            }
            return true;
        }
    }
}
