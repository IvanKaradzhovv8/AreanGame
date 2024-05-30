using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Spear : IWeapon, IProWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public SpecialSkills? SpecialSkillMethod { get; set; }

        public SpecialSkills? SpecialSkillMethodDefence { get; }

        public Spear(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockingPower = 10;
            SpecialSkillMethod = Impale;
        }

        public double Impale()
        {
            return AttackDamage * 0.5;
        }
    }
}
