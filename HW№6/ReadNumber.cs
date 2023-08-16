using System;

namespace HW_6
{
    public class ReadNumber
    {
        public int _nums;
        public int Nums
        {
            get { return _nums; }
            set { _nums = value; }
        }

        public ReadNumber() { }

        public ReadNumber(int nums)
        {
            this._nums = nums;
        }

        public int ReadNumbers(int start, int end)
        {
            Console.WriteLine($"Enter your number between {start} and {end}: ");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);

                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException(nameof(number), $"The number {number} is not in the range [{start}...{end}]");
                }

                return number;
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid input. Please enter a valid integer.");
            }
        }

        public void Input(int start, int end)
        {
            try
            {
                Nums = ReadNumbers(start, end);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Input(start, end);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Input(start, end);
            }
        }
    }
}
