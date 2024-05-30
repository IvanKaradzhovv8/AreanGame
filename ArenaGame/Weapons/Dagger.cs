using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Dagger : IWeapon, IProWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public SpecialSkills? SpecialSkillMethod { get; set; }

        public SpecialSkills? SpecialSkillMethodDefence { get; }

        public Dagger(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 1;
            SpecialSkillMethod = SwiftStrike;
            
        }
        public double SwiftStrike()
        {
            //There is no special skill for dagger for now
            return 0;
        }
    }
}
