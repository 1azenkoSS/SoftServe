namespace HW_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First task

            Console.Write("Enter a (side of the square) =  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Area = {Math.Pow(a,2)}");
            Console.WriteLine($"Perimeter = {a * 4}");

            //Second task

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine($"Okay, your name is {name} and you are {age}");

            //Third task

            double pi = Math.PI;
            Console.Write("Enter r (radius of a circle) =  ");
            double r = Convert.ToInt32(Console.ReadLine());
            double l = 2 * pi * r;
            double S = pi*Math.Pow(r,2);
            double volume = 4/3 * pi * Math.Pow(r,3);
            Console.Write($"The length of the citcle = {l:F2}\n The area of the citcle = {S:F2}\n The volume of the citcle = {volume:F2}\n");
        }
    }
}