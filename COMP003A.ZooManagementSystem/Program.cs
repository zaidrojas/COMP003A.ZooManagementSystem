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
            
            // variable is the input to be verified
            if (string.IsNullOrWhiteSpace(variable))
            {
                Console.WriteLine("\n***************************");
                Console.WriteLine("Input must not be Null or Whitespace.");
                Console.WriteLine("***************************\n");
                return false;
            }
            return true;
        }

        public static bool IntVerify(out int variable)
        {
            // variable is the input to be verified
            if (!int.TryParse(Console.ReadLine(), out variable))
            {
                Console.WriteLine("\n***************************");
                Console.WriteLine("Choice must be a valid integer.");
                Console.WriteLine("***************************\n");
                return false;
            }
            return true;
        }


        // initialization of current animals: Lion and Parrots
        // GlobalData.LionList.Add(new Lion("Simba", "panthera", 11));
        public static List<Lion> LionList = new List<Lion>();
        public static List<Parrot> ParrotList = new List<Parrot>();

        // Main method the user goes through as the program runs
        static void Main(string[] args)
        {
            int choice;
            string a_name;
            string a_species;
            int a_age;
            while (true)
            {
                Console.WriteLine("Welcome to the Zoo Management System!");

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
                        Console.Write("Enter the name of the lion: ");
                        a_name = Console.ReadLine();
                        StringVerifyNull(a_name);

                        Console.Write("Enter the species of the lion: ");
                        a_species = Console.ReadLine();
                        StringVerifyNull(a_species);

                        Console.WriteLine("Enter the age of the lion: ");
                        if (!IntVerify(out a_age))
                        { continue; }

                        Console.WriteLine();

                        continue;

                    case (2):
                        continue;

                    case (3):
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
