using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Bazooka : IWeapon, IProWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public SpecialSkills? SpecialSkillMethod { get; set; }
        public SpecialSkills? SpecialSkillMethodDefence { get; set; }

        public Bazooka(string name)
        {
            Name = name;
            AttackDamage = 45;
            BlockingPower = 1;
            SpecialSkillMethodDefence = BlastShield;
            SpecialSkillMethod = ExplosiveBarrage;
        }
        public double ExplosiveBarrage()
        {
            return 0;
        }
        public double BlastShield()
        {
            return BlockingPower * 15;
        }
    }
}
