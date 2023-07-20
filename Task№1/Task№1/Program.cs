using System.Collections.Generic;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First task

            Console.Write("Enter a value = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b value = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum = {a + b}");
            Console.WriteLine($"Subtraction = {a - b}");
            Console.WriteLine($"Multiplication = {a * b}");
            Console.WriteLine($"Division = {a / b}\n");

            //Second task

            Console.Write("How are you?\n");
            string how = Console.ReadLine();
            Console.WriteLine($"You are {how}\n");

            //Third task

            char ch1, ch2, ch3;

            Console.WriteLine("Write 3 char-type symbols: ");
            ch1 = Char.Parse(Console.ReadLine());
            ch2 = Char.Parse(Console.ReadLine());
            ch3 = Char.Parse(Console.ReadLine());
            Console.WriteLine($"You enter first {ch1}, second {ch2}, third {ch3}\n");

            //Fourth task

            Console.Write("Enter k value = ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n value = ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool positive = n >= 0 && k >= 0;
            
            if (positive == true)
            {
                Console.WriteLine("Both numbers are positive");
            }
            else
            {
                Console.WriteLine("Both numbers are not positive\n");
            }
        }
    }
}