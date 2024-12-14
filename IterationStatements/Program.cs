namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()

        public static void PrintEveryThirdNumber()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static bool AreNumbersEqual(int num1, int num2)
        {
            return num1 == num2;
        }
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        public static bool isEven(int number)
        {
            return number % 2 == 0;
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        static bool IsPositive(int number)
        {
            return number > 0;
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.

        static bool CanVote(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You're old enough to vote!");
                return true;
            }
            else
            {
                Console.WriteLine("You're not old enough to vote!");
                return false;
            }
        }
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        static bool IsInRange(int number)
        {
            return number >= -10 && number <= 10;
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        static void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {number * i}");
            }
        }
        
        
        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintEveryThirdNumber();
            
            Console.WriteLine("Please enter two numbers to see if they're equal.");
            Console.WriteLine("1st number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2nd number:");
            int num2 = int.Parse(Console.ReadLine());
            if (AreNumbersEqual(num1, num2))
            {
                Console.WriteLine("These numbers are equal!");
            }
            else
            {
                Console.WriteLine("These numbers are not equal!");
            }
            
            Console.WriteLine("Please enter a number to see if it's even:");
            int number = int.Parse(Console.ReadLine());
            if (isEven(number))
            {
                Console.WriteLine("It's even!");
            }
            else
            {
                Console.WriteLine("It's not even!");
            }
            
            
            Console.WriteLine("Please enter a number to see if it's a positive number:");
            int posNegNum = int.Parse(Console.ReadLine());
            if (IsPositive(posNegNum))
            {
                Console.WriteLine("It's positive!");
            }
            else
            {
                Console.WriteLine("It's negative!");
            }
            
            
            Console.WriteLine("Please your age to see if you're old enough to vote:");
            int age = int.Parse(Console.ReadLine());
            CanVote(age);
            
            Console.WriteLine("Enter a number to see if it's in the range of -10 to 10:");
            int rangeNumber = int.Parse(Console.ReadLine());
            if (IsInRange(rangeNumber))
            {
                Console.WriteLine("It's in range!");
            }
            else
            {
                Console.WriteLine("It's not in range!");
            }

            Console.WriteLine("Please enter a number to display its multiplication table (from 1 to 12):");
            int multipyNum = int.Parse(Console.ReadLine());
            DisplayMultiplicationTable(multipyNum);
        }
    }
}
