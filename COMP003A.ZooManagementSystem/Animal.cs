using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    abstract class Animal
    {
        // Fields
        private string _name;
        private string _species;
        private int _age;

        // Public properties for fields
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                }
                _name = value;
            }
        }

        public string Species
        {
            get { return _species; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Species cannot be empty or whitespace.");
                }
                _species = value;
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be a valid integer greater than or equal to 0.");
                }
                _age = value;
            }
        }

        // Method to be overwritten
        public abstract void MakeSound();
    }
}
