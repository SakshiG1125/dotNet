using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Typecast Input");
                Console.WriteLine("2. String Manipulation");
                Console.WriteLine("3. Append to File");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        program.A1();
                        break;
                    case "2":
                        program.A2();
                        break;
                    case "3":
                        program.A3();
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
        void A1()
        {
            Console.Write("Enter a value: ");
            string input = Console.ReadLine();

            // Try to convert to integer
            if (int.TryParse(input, out int intValue))
            {
                Console.WriteLine($"Converted to Integer: {intValue}");
            }
            // Try to convert to double
            else if (double.TryParse(input, out double doubleValue))
            {
                Console.WriteLine($"Converted to Double: {doubleValue}");
            }
            // Try to convert to decimal
            else if (decimal.TryParse(input, out decimal decimalValue))
            {
                Console.WriteLine($"Converted to Decimal: {decimalValue}");
            }
            // Try to convert to boolean
            else if (bool.TryParse(input, out bool boolValue))
            {
                Console.WriteLine($"Converted to Boolean: {boolValue}");
            }
            // Try to convert to DateTime
            else if (DateTime.TryParse(input, out DateTime dateTimeValue))
            {
                Console.WriteLine($"Converted to DateTime: {dateTimeValue}");
            }
            else
            {
                Console.WriteLine("Could not convert the input to a known type.");
            }
        }

        void A2()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Using string functions
            string upperCase = input.ToUpper();
            string lowerCase = input.ToLower();
            string trimmed = input.Trim();
            string replaced = input.Replace("l", "*");

            // Finding occurrences and positions of 'l'
            int count = 0;
            string formattedOutput = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'l')
                {
                    count++;
                    Console.WriteLine($"'l' found at position {i}");
                }
                formattedOutput += "*" + input[i];
            }

            Console.WriteLine("\nString Functions Output:");
            Console.WriteLine($"UpperCase: {upperCase}");
            Console.WriteLine($"LowerCase: {lowerCase}");
            Console.WriteLine($"Trimmed: {trimmed}");
            Console.WriteLine($"Replaced 'l' with '*': {replaced}");
            Console.WriteLine($"Formatted Output: {formattedOutput}");
            Console.WriteLine($"Total occurrences of 'l': {count}");
        }

        void A3()
        {
            {
                string filePath = "output.txt";

                if (File.Exists(filePath))
                {
                    Console.WriteLine("Current contents of the file:");
                    Console.WriteLine(File.ReadAllText(filePath));
                }
                else
                {
                    Console.WriteLine("File does not exist. A new file will be created.");
                }

                Console.Write("Enter a string to append to the file: ");
                string input = Console.ReadLine();
                File.AppendAllText(filePath, input + Environment.NewLine);

                Console.WriteLine("String appended to the file successfully.");
                Console.WriteLine("Updated contents of the file:");
                Console.WriteLine(File.ReadAllText(filePath));
            }
        }
    }
}
