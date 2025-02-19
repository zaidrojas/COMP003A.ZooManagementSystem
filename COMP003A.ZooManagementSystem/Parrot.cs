using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    internal class Parrot : Animal
    {
        
        public override void MakeSound()
        {
            Console.WriteLine("The parrot squawks!");
        }

    }
}
