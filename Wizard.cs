using System;
using System.Collections.Generic;

namespace Wizard
{
    class Wizard : Human
    {
        
        public Wizard(string name) : base(name, 3 ,25, 3, 50)
        {
        }
        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.health -= dmg;
            health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            System.Console.WriteLine($"{Name} stole your {dmg} health, so Wizard's health is {health} ");
            return target.health;

            
        }
        public void Heal(Human target) 
        {
            target.health += Intelligence * 10;

        }

        
            



    }
}