using System;

namespace Wizard
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja firstMan = new Ninja("Reza");
            Wizard Harrypotter = new Wizard("Harry");
            System.Console.WriteLine(firstMan.health);
            System.Console.WriteLine(Harrypotter.health);
            firstMan.Steal(Harrypotter);
            System.Console.WriteLine(firstMan.health);
            System.Console.WriteLine(Harrypotter.health);
        }
    }
}
