using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Shotgun : IWeapon, IProWeapon
    { 
        public string Name { get; set; }
        public double AttackDamage { get; set; }
        public double BlockingPower { get; private set; }

        public SpecialSkills? SpecialSkillMethod { get; set; }
        public SpecialSkills? SpecialSkillMethodDefence { get; set; }

        public Shotgun(string name)
        {
            Name = name;
            AttackDamage = 10;
            BlockingPower = 0;
            SpecialSkillMethod = ThunderousBlast;
            SpecialSkillMethodDefence = SpecialDefence;
        }

        public double ThunderousBlast()
        {
            return 4;
        }

        public double SpecialDefence()
        { 
            return 12.4;
        }
    }
}
