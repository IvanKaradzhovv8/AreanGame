﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public abstract class Hero : IHero
    {
        protected Random random = new Random();
        public string Name { get; private set; }
        public double Health { get; private set; }
        public double Armor { get; private set; }
        public double Strenght { get; private set; }
        public IWeapon? Weapon { get; private set; }
        public IProWeapon? ProWeapon { get; private set; }

        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }

        public Hero(string name, double armor, double strenght, IWeapon? weapon = null, IProWeapon? proWeapon = null)
        {
            Health = 100;

            Name = name;
            Armor = armor;
            Strenght = strenght;
            Weapon = weapon;
            ProWeapon = proWeapon;
            
        }


        // returns actual damage
        public virtual double Attack()
        {
            double totalDamage = Strenght;

            if (Weapon == null && ProWeapon != null)
            {
                totalDamage +=  ProWeapon.AttackDamage;
            }
            else if (Weapon != null && ProWeapon == null)
            {
                totalDamage += Weapon.AttackDamage;
            }
            else if(Weapon != null && ProWeapon != null)
            {
                totalDamage += Strenght + Weapon.AttackDamage + ProWeapon.AttackDamage;
            }

            if (Weapon?.SpecialSkillMethod != null)
            {
                totalDamage += Weapon.SpecialSkillMethod();
                Console.WriteLine($"The {Name} uses his special attack");
            }
            double coef = random.Next(80, 120 + 1);
            double realDamage = totalDamage * (coef / 100);
            return realDamage;
        }

        public virtual double Defend(double damage)
        {
            double defendPower = Armor;
            if (Weapon == null && ProWeapon != null)
            {
                defendPower += ProWeapon.BlockingPower;
            }
            else if (Weapon != null && ProWeapon == null)
            {
                defendPower += Weapon.BlockingPower;
            }
            else if (Weapon != null && ProWeapon != null)
            {
                defendPower += Strenght + Weapon.BlockingPower + ProWeapon.BlockingPower;
            }

            if (Weapon?.SpecialSkillMethodDefence != null)
            {
                defendPower += Weapon.SpecialSkillMethodDefence();
                Console.WriteLine($"The {Name} uses his special defence");
            }
            double coef = random.Next(80, 120 + 1);
            double totalDefendPower = defendPower * (coef / 100);
            double realDamage = damage - totalDefendPower;
            if (realDamage < 0)
                realDamage = 0;
            Health -= realDamage;
            return realDamage;
        }

        public override string ToString()
        {
            return $"{Name} with health {Math.Round(Health,2)}";
        }
    }
}
