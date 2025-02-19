using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    internal class Lion : Animal
    {
        public Lion(string name) : base(name, "Lion") { }
        public override void MakeSound()
        {
            Console.WriteLine("The lion roars!");
        }

    }
}
