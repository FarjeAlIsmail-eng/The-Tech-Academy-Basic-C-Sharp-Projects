using System;

class Program
{
    static void Main()
    {
        // Welcome message to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt for package weight
        Console.WriteLine("Please enter the package weight:");
        // Read user input and convert to integer
        int weight = Convert.ToInt32(Console.ReadLine());

        // Check if the package weight is greater than 50
        if (weight > 50)
        {
            // Display error message if package is too heavy
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            // End the program early since package is too heavy
            return;
        }

        // Prompt for package width
        Console.WriteLine("Please enter the package width:");
        int width = Convert.ToInt32(Console.ReadLine());

        // Prompt for package height
        Console.WriteLine("Please enter the package height:");
        int height = Convert.ToInt32(Console.ReadLine());

        // Prompt for package length
        Console.WriteLine("Please enter the package length:");
        int length = Convert.ToInt32(Console.ReadLine());

        // Check if the total dimensions exceed 50
        if ((width + height + length) > 50)
        {
            // Display error message if package is too big
            Console.WriteLine("Package too big to be shipped via Package Express.");
            // End the program early since package is too big
            return;
        }

        // Calculate the volume multiplied by weight, then divided by 100
        int volume = width * height * length; // Calculate volume
        decimal quote = (volume * weight) / 100m; // Calculate quote as decimal, dividing by 100

        // Display the shipping quote formatted as currency
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}");
        Console.WriteLine("Thank you!");
    }
}
