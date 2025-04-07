    using System;

    namespace calculator
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter an expression (ex. 2 + 3): ");
                string input = Console.ReadLine();

                try
                {
                    Parser parser = new Parser();
                    (double num1, string op, double num2) = parser.Parse(input);

                    Calculator calculator = new Calculator();
                    double result = calculator.Calculate(num1, op, num2);

                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        // Parser class to parse the input
        public class Parser
        {
            public (double, string, double) Parse(string input)
            {
                string[] parts = input.Split(' ');

                if (parts.Length != 3)
                {
                    throw new FormatException("Input must be in the format: number operator number");
                }

                double num1 = Convert.ToDouble(parts[0]);
                string op = parts[1];
                double num2 = Convert.ToDouble(parts[2]);

                return (num1, op, num2);
            }
        }

        // Calculator class to perform operations
        public class Calculator
        {
            // ---------- TODO ----------
            public double Calculate(double num1, string op, double num2)
            {
                switch (op)
                {
                    case "+":
                        return num1 + num2;
                    case "-":
                        return num1 - num2;
                    case "*":
                        return num1 * num2;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error!");
                            return 0;
                        }
                        return num1 / num2;

                    case "%":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error!");
                            return 0;
                        }
                        return num1 % num2;

                    case "G":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error!");
                            return 0;
                        }
                        return gcd(num1, num2);

                    case "L":
                        if (num2 == 0)
                        {
                            return 0;
                        }
                        return num1 * num2 / gcd(num1, num2);
                    case "**":
                        double result = 1;
                        if (num2 < 0)
                        {
                            for (int i = 0; i < -num2; i++)
                            {
                                result *= num1;
                            }
                            return 1 / result;
                        }
                        else if (num2 == 0) return result;
                        else
                        {
                            for (int i = 0; i < num2; i++)
                            {
                                result *= num1;
                            }
                            return result;
                        }
                    
                    default:
                        return 0;

                }
            }
            public static double gcd(double num1, double num2)
            {

                if (num1 % num2 == 0)
                {
                    return num2;
                }
                else
                {
                    return gcd(num2, num1 % num2);

                }
            }
            // --------------------
        }
    }

/* example output

Enter an expression (ex. 2 + 3):
>> 4 * 3
Result: 12

*/


/* example output (CHALLANGE)

Enter an expression (ex. 2 + 3):
>> 4 ** 3
Result: 64

Enter an expression (ex. 2 + 3):
>> 5 ** -2
Result: 0.04

Enter an expression (ex. 2 + 3):
>> 12 G 15
Result: 3

Enter an expression (ex. 2 + 3):
>> 12 L 15
Result: 60

Enter an expression (ex. 2 + 3):
>> 12 % 5
Result: 2

*/