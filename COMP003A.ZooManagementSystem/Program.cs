// Author: [Zaid Rojas]
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#

namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {

        // Methods that are used to verify if the inputs for
        // both ints and strings are valid
        public static bool StringVerifyNull(string variable)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(variable))
                {
                    throw new ArgumentException("Input must not be Null or Whitespace.");
                }
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("\n***************************");
                Console.WriteLine(ex.Message);
                Console.WriteLine("***************************\n");
                return false;
            }
        }


        public static bool IntVerify(out int variable)
        {
            try
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out variable))
                {
                    throw new FormatException("Choice must be a valid integer.");
                }
                return true;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("\n***************************");
                Console.WriteLine(ex.Message);
                Console.WriteLine("***************************\n");
                variable = 0; // Default value in case of failure
                return false;
            }
        }
        //////////////////////////////////


        // initialization of current animals: Lion and Parrots
        public static List<Animal> AnimalList = new List<Animal>();

        // Main method the user goes through as the program runs
        static void Main(string[] args)
        {
            int choice;
            string a_name;
            string a_species;
            int a_age;
            while (true)
            {
                Console.WriteLine("Welcome to the Zoo Management System!\n");
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1. Add a Lion");
                Console.WriteLine("2. Add a Parrot");
                Console.WriteLine("3. Display All Animals");
                Console.WriteLine("4. Describe an Animal");
                Console.WriteLine("5. Exit");

                Console.Write("\nYour Choice: ");
                // Verify if valid int, if not, it shall loop
                if (!IntVerify(out choice))
                { continue; }

                switch(choice)
                {
                    case (1):
                        // Ask user for parrot's information
                        Console.Write("Enter the name of the lion: ");
                        a_name = Console.ReadLine();
                        StringVerifyNull(a_name);

                        Console.Write("Enter the species of the lion: ");
                        a_species = Console.ReadLine();
                        StringVerifyNull(a_species);

                        Console.Write("Enter the age of the lion: ");
                        if (!IntVerify(out a_age))
                        { continue; }

                        // Creates the Parrot then adds to the list
                        Animal newLion = new Lion(a_name, a_species, a_age);
                        AnimalList.Add(newLion);

                        Console.WriteLine("\nLion added successfully!\n");
                        continue;

                    case (2):
                        // Ask user for parrot's information
                        Console.Write("Enter the name of the parrot: ");
                        a_name = Console.ReadLine();
                        StringVerifyNull(a_name);

                        Console.Write("Enter the species of the parrot: ");
                        a_species = Console.ReadLine();
                        StringVerifyNull(a_species);

                        Console.Write("Enter the age of the parrot: ");
                        if (!IntVerify(out a_age))
                        { continue; }

                        // Creates the Parrot then adds to the list
                        Animal newParrot = new Parrot(a_name, a_species, a_age);
                        AnimalList.Add(newParrot);

                        Console.WriteLine("\nLion added successfully!\n");
                        continue;

                    case (3):
                        // Introduction
                        Console.WriteLine("\nDisplaying all animals:");
                        // Describe all the animals
                        foreach(Animal animal in AnimalList)
                        {
                            animal.MakeSound();
                        }
                        // Creating a soace afterwards
                        Console.WriteLine("");
                        continue;

                    case (4):

                        continue;

                    case (5):
                        // Exits the program
                        break;

                    default:
                        Console.WriteLine("\n***************************");
                        Console.WriteLine("Choice must be options 1-5.");
                        Console.WriteLine("***************************\n");
                        continue;
                }
                break;
            }
        }
    }
}
