using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    class Lion : Animal
    {
        public Lion(string name, string species, int age)
        {
            Name = name;
            Species = species;
            Age = age;
        }

        public override void MakeSound()
        {
            Console.Write("The lion roars! ");
            Console.WriteLine($"({Name}, {Species})");
        }

    }
}
