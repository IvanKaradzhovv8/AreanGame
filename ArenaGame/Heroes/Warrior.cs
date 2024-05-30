using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Warrior : Hero
    {

        public Warrior(string name, double armor, double strenght, IWeapon? weapon = null, IProWeapon? proWeapon = null) : base(name, armor, strenght, weapon)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();
            
            return damage;
        }
        public override double Defend(double damage)
        {
            return base.Defend(damage);
        }
    }
}
