

namespace COMP003A.LectureActivity3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Iterative Statements Demo!\n");

            // Prompt for a positive integer
            int num;
            Console.Write("Enter a positive integer to generate its multiplication table: ");
            num = int.Parse(Console.ReadLine());

            //  Generate multiplication table using a loop
            Console.WriteLine($"Multiplication Table for {num}:");
            // loop to generate the multiplication table
            // the first statement initializes the loop variable i to 1
            // the second statement specifies the condition for the loop to continue
            // the third statement increments the loop variable i by 1
            for (int i = 1; i <= 10; i++)
            {

                // display the multiplication table
                Console.WriteLine($"(i) x {num} = {i * num}");

                // Display table in reverse using a while loop
                Console.WriteLine("\nReversed Multiplication Table:");
                int reverse = 10; // start at 10
                // loop to generate the multiplication table in reverse
                while (reverse > 0)
                {
                    // display the multiplication table in reverse
                    Console.WriteLine($"{reverse} x {num} = {reverse * num}");
                    // decrement reverse
                    reverse--;
                }



                // Display fibonacci series using a do-while loop
                Console.WriteLine("\nFibonacci Series:");
                int FirstNumber = 0, secondNumber = 1, nextNumber; // first two numbers
                Console.WriteLine($"{FirstNumber} {secondNumber} "); // display first two numbers
                int count = 2; // count starts at 2
                // loop to generate the next 10 numbers in the series
                do
                {
                    nextNumber = FirstNumber + secondNumber; // calculate next number
                    Console.Write($"{nextNumber} ");  // display next number
                    FirstNumber = secondNumber; // update first number
                    secondNumber = nextNumber; // update second number
                    count++; // increment count
                } while (count < 10); // loop until count reaches 10


                // Display favorite fruits in a collection using a foreach loop
                // Create an array of fruits | data structure preview
                string[] fruits = { "Apple", "Banana", "Pear", "Strawberry" };

                Console.WriteLine("\n");
                // Display each fruit using a foreach loop
                Console.WriteLine("Your favorite fruits are:");
                // loop through each fruit in the array
                foreach (string fruit in fruits)
                {
                    Console.WriteLine($"-{fruit}");
                }

            }
        }
    }
}