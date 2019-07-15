using System;
using System.Collections.Generic;

namespace Wizard
{
    class Samurai : Human
    {
        public Samurai(string name) : base(name, 3,3,3,200)
        {

        }
        public override int Attack(Human target)
        {
            base.Attack(target);
          if (target.health < 50)
          {
              target.health = 0;
              System.Console.WriteLine($"{target.Name} died by Samurai ");
          }
          return target.health;
        }
        public void Meditate(Human Samurai)
        {
            Samurai.health = 200;

        }
    }
}