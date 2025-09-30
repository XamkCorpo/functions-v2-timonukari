namespace Calculator
{
    internal class Program
    {
        // Function to choose the operation
        static int ChooseOperation()
        {
            while (true)
            {
                Console.Write("Choose an operation (1: Addition, 2: Subraction, 3: Multiplication, 4: Division): ");
                string? input = Console.ReadLine();

                //First checks if input is a number, then checks if it's between 1 and 4
                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 4)
                    return choice;
                Console.WriteLine("Invalid choice. Please choose only 1, 2, 3 or 4.");
            }
        }
        // Function to ask for the first number
        static int AskNumber1()
        {
            while (true)
            {
                Console.Write("Enter the first number: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int number1))
                    return number1;
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        // Function to ask for the second number
        static int AskNumber2()
        {
            while (true)
            {
                Console.Write("Enter the second number: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int number2))
                    return number2;
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        //Function for addition
        static double Addition(int number1, int number2)
        {
            double result = number1 + number2;
            return result;
        }
        //Function for subtraction
        static double Subtraction(int number1, int number2)
        {
            double result = number1 - number2;
            return result;
        }
        //Function for multiplication
        static double Multiplication(int number1, int number2)
        {
            double result = number1 * number2;
            return result;
        }
        //Function for division, handling division by zero
        static double Division(int number1, int number2)
        {
            if (number2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return double.NaN;
            }
            double result = (double)number1 / number2;
            return result;
        }
        // Function to display the result
        static void DisplayResult(double result)
        {
            Console.WriteLine($"The result is: {result}");
        }
        static void Main(string[] args)
        {
            int choice = ChooseOperation();
            int number1 = AskNumber1();
            int number2 = AskNumber2();
            //Using switch to choose which operation to perform
            double result = choice switch
            {
                1 => Addition(number1, number2),
                2 => Subtraction(number1, number2),
                3 => Multiplication(number1, number2),
                4 => Division(number1, number2),
            };
           
            DisplayResult(result);
        }
    }
}
