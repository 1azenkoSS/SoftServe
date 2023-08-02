using System.Transactions;

namespace Task_3
{
    internal class Program
    {


        static void Main(string[] args)
        {

            //Task #1
            Console.WriteLine("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numbers from {a} to {b} which divided by 3 without remainder: ");
            for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Task #2

            Console.WriteLine("Enter the symbols: ");
            string symbols = Convert.ToString(Console.ReadLine());
            int length = symbols.Length;
            for (int i = 0; i < length; i += 2)
            {
                Console.WriteLine(symbols[i]);
            }

            //Task #3

            Console.WriteLine("Which drink do you want? ");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "coffee":
                    Console.WriteLine($"Coffee price {200:C}");
                    break;
                case "tea":
                    Console.WriteLine($"Tea price {110:C}");
                    break;
                case "juice":
                    Console.WriteLine($"Juice price {70:C}");
                    break;
                case "water":
                    Console.WriteLine($"Water price{25:C}");
                    break;
                default:
                    Console.WriteLine("This drink is not available in our store");
                    break;
            }

            //Task #4

            Console.WriteLine("Enter a sequence of positive integers (to the first negative): ");
            int[] nums = { 1, 6, 3, 9, -8 };
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += (nums[i] >= 0) ? nums[i] : 0;
            }
            int average = sum / nums.Length - 1;
            Console.WriteLine($"Sum: {sum}\nAvarage: {average}");

            //Task #5

            Console.WriteLine("Enter the year: ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("It is a leap year");
            }
            else
            {
                Console.WriteLine("It is not a leap year");
            }

            //Task #6

            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            while(number != 0)
            {
                int digit = number % 10;
                count += digit;
                number /= 10;
            }
            Console.WriteLine($"The sum of number digits is equal: {count}");

            //Task #7

            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            bool isAllDigitsOdd = true;
            while(num != 0)
            {
                if (num % 2 == 0)
                {
                    isAllDigitsOdd = false;
                    break;
                }
                else
                    isAllDigitsOdd = true;
                number /= 10;
            }
            Console.WriteLine(isAllDigitsOdd ? "Number contains only odd digits" : "Number contains even digits");
        }
    }
}