namespace FunctionAssigmentV1
{
    internal class Program
    {
        // Function to ask for the user's name
        static string AskName()
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                string? input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();

                Console.WriteLine("Name cannot be empty.");
            }
        }
        // Function to ask for the user's age
        static int AskAge()
        {
            while (true)
            {
                Console.Write("Enter your age: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int age) && age > 0)
                    return age;
                Console.WriteLine("Please enter a positive integer.");
            }
        }
        // Function to print the user's name and age
        static void PrintNameAndAge(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }
        // Function to check if the user is an adult
        static bool IsAdult(int age)
        {
            return age >= 18;
        }
        // Function to compare the user's name with "Matti"
        static void CompareName(string name, string compareName)
        {
            if (name.Equals(compareName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");
            if (name.Equals(compareName))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }
        static void Main(string[] args)
        {
            string name = AskName();
            int age = AskAge();
            PrintNameAndAge(name, age);
            bool adult = IsAdult(age);
            if (adult)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are not an adult.");
            CompareName(name, "Matti");
        }
    }
}