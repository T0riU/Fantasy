using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy
{
    public class Creatures
    {
        public Creatures()
        {
            Player = new List<Player>();
            Dragon = new List<Dragon>();
            Hydra = new List<Hydra>();
            Wyvern = new List<Wyvern>();
            Ghost = new List<Ghost>();
            Skeleton = new List<Skeleton>();
            Gnome = new List<Gnome>();
            Ent = new List<Ent>();
            HighElf = new List<HighElf>();
            DarkElf = new List<DarkElf>();
            Orc = new List<Orc>();
        }
        public Creatures(List<Player> player)
        {
            Player = player;
        }
        public Creatures(List<Player> player, List<Dragon> dragon, List<Hydra> hydra, List<Wyvern> wyvern,List<Ghost> ghost, List<Skeleton> skeleton, List<Gnome> gnome,List<Ent> ent, List<HighElf> highelf, List<DarkElf> darkelf, List<Orc> orc)
        {
            Player = player;
            Dragon = dragon;
            Hydra = hydra;
            Wyvern = wyvern;
            Ghost = ghost;
            Skeleton = skeleton;
            Gnome = gnome;
            Ent = ent;
            HighElf = highelf;
            DarkElf = darkelf;
            Orc = orc;
        }
        public List<object> GetAllWithOutPlayer()
        {
            List<object> objectList = new List<object>();
            objectList = objectList.Cast<object>()
                .Concat(DarkElf)
                .Concat(Dragon)
                .Concat(Ent)
                .Concat(Ghost)
                .Concat(Gnome)
                .Concat(HighElf)
                .Concat(Hydra)
                .Concat(Orc)
                .Concat(Skeleton)
                .Concat(Wyvern)
                .ToList();
            return objectList;
        } 
        public List<Player> Player { get; set; }
        public List<Dragon> Dragon { get; set; }
        public List<Hydra> Hydra { get; set; }
        public List<Wyvern> Wyvern { get; set; }
        public List<Ghost> Ghost { get; set; }
        public List<Skeleton> Skeleton { get; set; }
        public List<Gnome> Gnome { get; set; }
        public List<Ent> Ent { get; set; }
        public List<HighElf> HighElf { get; set; }
        public List<DarkElf> DarkElf { get; set; }
        public List<Orc> Orc { get; set; }
    }
}
