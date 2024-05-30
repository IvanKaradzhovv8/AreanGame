using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public delegate double SpecialSkills();
    public interface IWeapon
    {
        string Name { get; set; }
        double AttackDamage { get; }
        double BlockingPower { get; }
        SpecialSkills? SpecialSkillMethod { get; }
        SpecialSkills? SpecialSkillMethodDefence { get; }
    }
}
