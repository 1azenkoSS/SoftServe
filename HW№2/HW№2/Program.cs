namespace HW_2
{
    internal class Program
    {
        enum HTTPError
        {
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403,
            NotFound = 404
        }

        struct Dog
        {
            public string Name;
            public string Mark;
            public int Age;

            public override string ToString()
            {
                return $"{Name} ({Mark}), {Age} years old";
            }
        }


        static void Main(string[] args)
        {

            //Task #1
            
            Console.WriteLine("Enter the first number: ");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            float thirdNumber = float.Parse(Console.ReadLine());
            Console.WriteLine((firstNumber >= -5) && (firstNumber <= 5) ? $"{firstNumber} is in the ranhe [-5; 5]" 
                : $"{firstNumber} is not in the range");
            Console.WriteLine((secondNumber >= -5) && (secondNumber <= 5) ? $"{secondNumber} is in the ranhe [-5; 5]" 
                : $"{secondNumber} is not in the range");
            Console.WriteLine((thirdNumber >= -5) && (thirdNumber <= 5) ? $"{thirdNumber} is in the ranhe [-5; 5]" 
                : $"{thirdNumber} is not in the range");

            //Task #2

            int max;
            Console.WriteLine("Enter the first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int thirdNum = int.Parse(Console.ReadLine());
            Console.Write("Maximum number is: ");
            Console.WriteLine((Math.Max(Math.Max(firstNum, secondNum), thirdNum)));
            Console.Write("Minimum number is: ");
            Console.WriteLine((Math.Min(Math.Min(firstNum, secondNum), thirdNum)));

            //Task #3

            Console.Write("Enter HTTP error code: ");
            int errorCode = int.Parse(Console.ReadLine());

            string errorName = Enum.GetName(typeof(HTTPError), errorCode);

            if (errorName != null)
            {
                Console.WriteLine($"HTTP error {errorCode}: {errorName}");
            }
            else
            {
                Console.WriteLine($"HTTP error {errorCode} not recognized");
            }

            //Task #4

            Dog myDog;

            Console.Write("Enter dog name: ");
            myDog.Name = Console.ReadLine();

            Console.Write("Enter dog mark: ");
            myDog.Mark = Console.ReadLine();

            Console.Write("Enter dog age: ");
            myDog.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"My dog is {myDog.ToString()}");

        }
    }
}