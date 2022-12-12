using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy
{

    public class Gnome : Fairy
    {
        const int GnomeMaxResistance = 80;
        const int ResUp = 5;
        public Gnome(string name, string LastName, int HP, int Mana, int Power, int ManaUsage, int Resistance, int MagicResistance) : base(name, LastName, HP, Mana, Power, ManaUsage, Resistance, MagicResistance)
        {
        }
        public virtual bool AB_PhysicalResStatUp()
        {
            
            if(Resistance+ResUp<GnomeMaxResistance)
            {
                Resistance += ResUp;
            }else
            {
                Resistance = GnomeMaxResistance;
            }
            return true;
        }
        public virtual bool AB_MagicResStatUp()
        {

            if (MagicResistance + ResUp < GnomeMaxResistance)
            {
                MagicResistance += ResUp;
            }
            else
            {
                MagicResistance = GnomeMaxResistance;
            }
            return true;
        }
    }
}
