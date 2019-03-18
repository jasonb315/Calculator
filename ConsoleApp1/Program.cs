using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "CLI-Calc";
            string appVersion = "1.0.0";
            string appAuthor = "Jason Burns";
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.WriteLine("\"exit\" to quit");

            Calculator();
        }

        static void Calculator()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Select: Add, Subtract, Multiply, Divide: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string inputVal = Console.ReadLine().ToLower();
                if (inputVal == "add" || inputVal == "subtract" || inputVal == "multiply" || inputVal == "divide")
                {
                    string operation = inputVal;
                    int a;
                    int b;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Enter: first value: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    string numOne = Console.ReadLine();

                    if (numOne == "exit")
                    {
                        return;
                    }

                    int.TryParse(numOne, out a);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("{0}: ", operation);
                    Console.ForegroundColor = ConsoleColor.Green;
                    string numTwo = Console.ReadLine();

                    if (numTwo == "exit")
                    {
                        return;
                    }

                    int.TryParse(numTwo, out b);

                    Console.ForegroundColor = ConsoleColor.Magenta;

                    switch (operation)
                    {
                        case "add":
                            Add(a, b);
                            break;

                        case "subtract":
                            Subtract(a, b);
                            break;

                        case "multiply":
                            Multiply(a, b);
                            break;

                        case "divide":
                            Divide(a, b);
                            break;

                        default:
                            return;
                    }

                }
                else if (inputVal == "exit")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Selection Error");
                }
            }
        }

        static void Add(int a, int b)
        {
            Console.WriteLine("Result: " + (a + b));
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine("Result: " + (a - b));
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine("Result: " + (a * b));
        }

        static void Divide(int a, int b)
        {
            try
            {
                int zTest = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A black hole appears.");
            }

            int mainDivision = a / b;
            double remainder = a % b;
            Console.WriteLine("Result: " + (mainDivision + (remainder/b)));
        }

    }
}
