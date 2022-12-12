using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantasy
{
    public class Hydra : Lizard
    {
        protected int NumOfHeads;
        public Hydra(string name, string LastName, int HP, int Mana, int Power, int ManaUsage, int Resistance, int MagicResistance) : base(name, LastName, HP, Mana, Power, ManaUsage, Resistance, MagicResistance)
        {
            NumOfHeads = 3;
        }
        public virtual bool AB_HeadsXAttack(Creature obj)
        {
            Attack(obj, (int)AttackType.Physical, ((GetHeadsNum() - NumOfHeads + 1) * (int)((double)Power * 0.6)));
            return true;
        }
        public virtual int GetHeadsNum()
        {
            return NumOfHeads+NumOfDeaths/2;
        }
        public override bool AB_Regen()
        {
            int temp = NowHP;
            temp = NowHP + RegenStrengh;
            double HydraMaxHP = (((double)(GetHeadsNum()-NumOfHeads)) * 0.05);
            HydraMaxHP = HydraMaxHP < 1 ? (HydraMaxHP * HP) + HP : HP * 2;
            if (temp >= (int)HydraMaxHP)
            {
                NowHP = (int)HydraMaxHP;
            }
            else { NowHP = temp; }
            return true;
        }
    }
}
