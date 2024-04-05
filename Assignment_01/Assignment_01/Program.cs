using System;

class Program1
{
    void Shuffled()
    {
        Console.WriteLine(" ");
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        if (inputString.Length > 1)
        {
            char[] charArray = inputString.ToCharArray();
            char temp = charArray[0];
            charArray[0] = charArray[inputString.Length - 1];
            charArray[inputString.Length - 1] = temp;

            string shuffledString = new string(charArray);

            Console.WriteLine("Shuffled string: " + shuffledString);
        }
        else
        {
            Console.WriteLine("String is too short to shuffle.");
        }
    }

    void CalculateDigitSum()
    {
        Console.WriteLine(" ");
        Console.Write("Enter an integer: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            int digitSum = CalculateDigitSum(number);
            Console.WriteLine("Sum of digits: " + digitSum);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static int CalculateDigitSum(int num)
    {
        int sum = 0;

        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }

    public static void CheckPalindrome() // Changed to public static
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPalindrome(number))
            Console.WriteLine("The number is a palindrome.");
        else
            Console.WriteLine("The number is not a palindrome.");
    }

    static bool IsPalindrome(int number)
    {
        int reversedNumber = ReverseNumber(number);
        return number == reversedNumber;
    }

    static int ReverseNumber(int number)
    {
        int reversedNumber = 0;
        while (number > 0)
        {
            reversedNumber = reversedNumber * 10 + number % 10;
            number /= 10;
        }
        return reversedNumber;
    }

    void CalculateSquareRoot()
    {
        Console.WriteLine(" ");
        Console.Write("Enter a number to calculate its square root: ");
        if (double.TryParse(Console.ReadLine(), out double number))
        {
            if (number >= 0)
            {
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine($"Square root of {number} is: {squareRoot}");
            }
            else
            {
                Console.WriteLine("Cannot calculate square root of a negative number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    void CheckEvenOrOdd()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("{0} is an even number.", number);
        }
        else
        {
            Console.WriteLine("{0} is an odd number.", number);
        }
    }

    void CalculateAverage()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Enter 5 numbers:");
        double sum = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");

            if (double.TryParse(Console.ReadLine(), out double number))
            {
                sum += number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--;
            }
        }
        double average = sum / 5;

        Console.WriteLine($"The average of the 5 numbers is: {average}");
    }

    void ConvertCase()
    {
        Console.WriteLine(" ");
        Console.Write("Enter a string with capital letters: ");
        string inputString = Console.ReadLine();

        string lowercaseString = inputString.ToLower();

        Console.WriteLine("Lowercase string: " + lowercaseString);
    }

    static void Main(string[] args)
    {
        Program1 p1 = new Program1();

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Shuffle the characters of a string");
        Console.WriteLine("2. Calculate the sum of digits in an integer");
        Console.WriteLine("3. Check if a number is palindrome");
        Console.WriteLine("4. Calculate square root of a number");
        Console.WriteLine("5. Check if a number is even or odd");
        Console.WriteLine("6. Calculate the average of 5 numbers");
        Console.WriteLine("7. Convert a string to lowercase");

        Console.Write("Enter your choice (1-6): ");
        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1:
                    p1.Shuffled();
                    break;
                case 2:
                    p1.CalculateDigitSum();
                    break;
                case 3:
                    CheckPalindrome(); // Call static method directly
                    break;
                case 4:
                    p1.CalculateSquareRoot();
                    break;
                case 5:
                    p1.CheckEvenOrOdd();
                    break;
                case 6:
                    p1.CalculateAverage();
                    break;
                case 7:
                    p1.ConvertCase();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a number between 1 and 6.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
