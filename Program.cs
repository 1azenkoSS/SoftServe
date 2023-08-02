using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HW_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task #1

            Console.WriteLine("Enter the string: ");
            string str = Convert.ToString(Console.ReadLine());
            int count = 0;
            foreach(char p in str)
            {
                if (p == 'a' || p == 'o' || p == 'i' || p == 'e')
                    count++;
            }
            Console.WriteLine($"The counts of characters ‘a’, ’o’, ’i’, ’e’  in this text: {count}");

            //Task #2

            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month number: ");
            int month = Convert.ToInt32(Console.ReadLine());
            int daysInThisMonth = DateTime.DaysInMonth(year, month);
            Console.WriteLine(daysInThisMonth);

            //Task #3

            
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sumOfFirstFivePositive = 0;
            int productOfLastFive = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    if (i < 5)
                    {
                        sumOfFirstFivePositive += numbers[i];
                    }
                    else
                    {
                        productOfLastFive *= numbers[i];
                    }
                }
            }

            if (sumOfFirstFivePositive > 0)
            {
                Console.WriteLine($"Sum of first five positive numbers = {sumOfFirstFivePositive}");
            }
            else
            {
                Console.WriteLine($"The product of last five numbers = {productOfLastFive}");
            }
        }
    }
}