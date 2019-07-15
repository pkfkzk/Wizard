using System;
using System.Collections.Generic;

namespace Wizard
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name, 3, 3, 175, 100)
        {

        }
        public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;
            target.health -= dmg;
            Random rand = new Random();
            int critical = rand.Next(0,5);
            System.Console.WriteLine($"{Name} attacked {target.Name} for {dmg}  damage! " );
             if (critical == 4)
            {
            int criticalHit = 10;
            target.health -= criticalHit;
            System.Console.WriteLine($"Critical hit!! {criticalHit} more damage!");

            }
            else System.Console.WriteLine("Critical hit failed!! ");
            return target.health;
            
            
           
        }
        public void Steal(Human target)
        {
            target.health -= 5;
            health += 5;
        }
    }
}
