namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter");
            Console.WriteLine("Enter degrees in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32d) * 5d / 9d;
            Console.WriteLine("Degrees in Celsius: " + celsius);
            Console.WriteLine("Enter degrees in Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (celsius * 9d / 5d) + 32d;
            Console.WriteLine("Degrees in Fahrenheit: " + fahrenheit);
            Console.WriteLine();
            Console.WriteLine("Continue? (y/n):");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
            Console.WriteLine();
        }
    }
}