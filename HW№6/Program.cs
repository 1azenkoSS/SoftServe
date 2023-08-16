using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HW_6
{
    internal class Program : Div
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                int result = Divide(n1, n2);
                Console.WriteLine($"Result: {n1} / {n2} = {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }
            catch (FormatException exe)
            {
                Console.WriteLine($"Message: {exe.Message}");
            }


            ReadNumber[] numbers = new ReadNumber[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number {i + 1}:");

                int start, end;
                while (true)
                {
                    try
                    {
                        Console.Write("Enter start of range: ");
                        start = int.Parse(Console.ReadLine());

                        Console.Write("Enter end of range: ");
                        end = int.Parse(Console.ReadLine());

                        if (start >= end)
                        {
                            Console.WriteLine("Start of range should be less than end of range. Please try again.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter valid integer values.");
                    }
                }

                numbers[i] = new ReadNumber();
                numbers[i].Input(start, end);
            }

            Console.WriteLine("Entered numbers:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num.Nums);
            }

        }
    }
}