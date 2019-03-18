using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // program details
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
                //check input for operation type, if valid collect values to operate
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
                        //break loop, end program.
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

                    Console.ForegroundColor = ConsoleColor.Green;

                    // send user input to specified operation function
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
                    // something other than a valid operation or exit cmd was entered
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
                int mainDivision = a / b;
                double remainder = a % b;
                // add division sans remainder to remainder for result
                Console.WriteLine("Result: " + (mainDivision + (remainder / b)));
            }
            catch (DivideByZeroException)
            {
                // ha!
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A black hole appears.");
            }

        }
    }
}
