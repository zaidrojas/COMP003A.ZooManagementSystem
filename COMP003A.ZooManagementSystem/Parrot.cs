using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    class Parrot : Animal
    {
        public Parrot(string name, string species, int age)
        {
            Name = name;
            Species = species;
            Age = age;
        }

        public override void MakeSound()
        {
            Console.Write("The parrot squawks! ");
            Console.WriteLine($"({Name}, {Species})");
        }

    }
}
