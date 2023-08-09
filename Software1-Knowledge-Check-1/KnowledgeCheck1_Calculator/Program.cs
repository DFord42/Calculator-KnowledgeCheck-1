using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {


                Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

                var input = Console.ReadLine();
                var calculator = new Calculator();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter 2 integers to add");
                        var addNumber1 = Console.ReadLine();
                        var addNumber2 = Console.ReadLine();

                        if (int.TryParse(addNumber1, out int addNumOne) && int.TryParse(addNumber2, out int addNumTwo))
                        {
                            Console.Write($"{addNumber1} + {addNumber2} = ");
                            Console.WriteLine(calculator.Add(addNumOne, addNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of the numbers is not an int");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter 2 integers to subtract");
                        var subtractNumber1 = Console.ReadLine();
                        var subtractNumber2 = Console.ReadLine();

                        if (int.TryParse(subtractNumber1, out int subNumOne) && int.TryParse(subtractNumber2, out int subNumTwo))
                        {
                            Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
                            Console.WriteLine(calculator.Subtract(subNumOne, subNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of the numbers is not an int");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Enter two numbers to multiply");
                        var multiplyNumber1 = Console.ReadLine();
                        var multiplyNumber2 = Console.ReadLine();

                        if (int.TryParse(multiplyNumber1, out int multNumOne) && int.TryParse(multiplyNumber2, out int multNumTwo))
                        {
                            Console.Write($"{multiplyNumber1} x {multiplyNumber2} = ");
                            Console.WriteLine(calculator.Multiply(multNumOne, multNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of those numbers are not integers");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Enter 2 integers to divide");
                        var divideNumber1 = Console.ReadLine();
                        var divideNumber2 = Console.ReadLine();

                        if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
                        {
                            Console.Write($"{divideNumber1} / {divideNumber2} = ");
                            Console.WriteLine(calculator.Divide(divNumOne, divNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of the numbers is not an int");
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown input");
                        break;
                }

                Console.WriteLine("Would you like to use the calculator again? Please enter 'yes' or 'no': ");
                string response = Console.ReadLine();

                switch (response.ToLower())
                {
                    case "yes":
                        {
                            run = true;
                            break;
                        }

                    case "no":
                        {
                            Console.Write("Goodbye!");
                            run = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("That is an invalid answer. Terminating program...");
                            run = false;
                            break;
                        }

                }
            }
        }
    }
}