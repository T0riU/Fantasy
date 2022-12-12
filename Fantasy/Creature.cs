using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantasy
{
    public abstract class Creature
    {
        protected const int MAXSTAT = 1000;
        protected enum AttackType
        {
            Physical,
            Magic, 
            PhysicalAndMagic,
        }
        protected int RegenStrengh;
        protected int NumOfDeaths;
        protected int NumOfKills;
        public Creature()
        {
            this.Name = String.Empty;
            this.LastName = String.Empty;
            this.NowHP = new int();
            this.HP = new int();
            this.NowMana = new int();
            this.Mana = new int();
            this.Power = new int();
            this.ManaUsage = new int();
            this.Resistance = new int();
            this.MagicResistance = new int();
            RegenStrengh = new int();
            NumOfDeaths = new int();
        }
        protected Creature(string Name, string LastName, int HP, int Mana, int Power, int ManaUsage, int Resistance, int MagicResistance)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.NowHP = HP;
            this.HP = HP;
            this.NowMana = Mana;
            this.Mana = Mana;
            this.Power = Power;
            this.ManaUsage = ManaUsage;
            this.Resistance = Resistance;
            this.MagicResistance = MagicResistance;
            RegenStrengh = new int();
            NumOfDeaths = new int();
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        [JsonIgnore]
        private int nowhp;
        [JsonIgnore]
        public int NowHP
        {
            get { return nowhp; }
            set
            {
                if (value <= 0) { nowhp = 1; } else if (value >= MAXSTAT) { nowhp = MAXSTAT; } else { nowhp = value; }
            }
        }
        private int hp;
        public int HP
        {
            get { return hp; }
            set
            {
                if (value <= 0) { hp = 1; } else if (value >= MAXSTAT) { hp = MAXSTAT; } else { hp = value; }
            }
        }
        [JsonIgnore]
        private int nowmana;
        [JsonIgnore]
        public int NowMana
        {
            get { return nowmana; }
            set
            {
                if (value <= 0) { nowmana = 1; } else if (value >= MAXSTAT) { nowmana = MAXSTAT; } else { nowmana = value; }
            }
        }
        private int mana;
        public int Mana
        {
            get { return mana; }
            set
            {
                if (value <= 0) { mana = 1; } else if (value >= MAXSTAT) { mana = MAXSTAT; } else { mana = value; }
            }
        }
        private int power;
        public int Power
        {
            get { return power; }
            set
            {
                if (value <= 0) { power = 1; } else if (value >= MAXSTAT) { power = MAXSTAT; } else { power = value; }
            }
        }
        private int manausage;
        public int ManaUsage
        {
            get { return manausage; }
            set
            {
                if (value <= 0) { manausage = 1; } else if (value >= MAXSTAT) { manausage = MAXSTAT; } else { manausage = value; }
            }
        }
        private int resistance;
        public int Resistance
        {
            get { return resistance; }
            set
            {
                if (value <= 0) { resistance = 1; } else if (value>=100) { resistance = 100; }else { resistance = value; }
            }
        }
        private int magicresistance;
        public int MagicResistance
        {
            get { return magicresistance; }
            set
            {
                if (value <= 0) { magicresistance = 1; } else if (value >= 100) { magicresistance = 100; } else { magicresistance = value; }
            }
        }
        public virtual bool AB_ManaRegen()
        {
            NowMana += (int)((double)(Mana)/10);
            if (NowMana > Mana) { NowMana = Mana; }
            return true;
        }
        public virtual bool AB_PhysicalAttack(Creature obj)
        {
            Attack(obj, (int)AttackType.Physical, Power);
            return true;
        }
        public virtual bool AB_MagicAttack(Creature obj)
        {
            Attack(obj, (int)AttackType.Magic, Power);
            return true;
        }
        protected virtual bool Reset()
        {
            NowHP = HP;
            NumOfDeaths++;
            NowMana = Mana;
            return true;
        }
        protected virtual bool Attack(Creature obj, int type, int pow)
        {
            int Damage = new int();
            if (type == (int)AttackType.Magic)//Magic
            {
                int tempmana = NowMana - ManaUsage;
                if (tempmana < 0) { return false; }
                Damage = (int)((((double)pow) * ((100 - (double)obj.MagicResistance) / 100)));
                NowMana = tempmana;
            }
            else if (type == (int)AttackType.Physical)//Physical
            {
                Damage = (int)((((double)pow) * ((100 - (double)obj.Resistance) / 100)) / 2);
            }
            else if (type == (int)AttackType.PhysicalAndMagic)//Physical+Magic
            {
                bool ManaUse = false;
                int tempmana = NowMana - ManaUsage;
                if (tempmana >= 0) { Damage += (int)((((double)pow) * ((100 - (double)obj.MagicResistance) / 100))/1.5); ManaUse = true; }
                Damage += (int)((((double)pow) * ((100 - (double)obj.Resistance) / 100))/2);
                if (ManaUse) { NowMana = tempmana; }
            }
            else { return false; }
            obj.TakeDamage(this, Damage);
            return true;
        }
        public virtual bool TakeDamage(Creature attacker, int Damage)
        {
            if (NowHP-Damage <= 0)
            {
                Reset();
                attacker.NumOfKills++;
            }
            else
            {
                NowHP = NowHP - Damage;
            }
            return true;
        }

        public override string ToString() => $"Name: {Name}\nLast Name: {LastName}\nHP: {NowHP}\nMax HP: {HP}\nMana: {NowMana}\nMax Mana: {Mana}\nPower: {Power}\nManaUsing: {ManaUsage}\nResistance: {Resistance}%\nMagicResistance: {MagicResistance}%\nKills: {NumOfKills}\nDeaths: {NumOfDeaths}";
    }
}
