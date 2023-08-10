namespace HW_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> personDictionary = new Dictionary<uint, string>();
            int countOfPeople = 3;

            for (uint i = 0; i < countOfPeople; i++)
            {
                Console.Write($"Enter ID for person {i + 1}: ");
                uint id = UInt32.Parse(Console.ReadLine());
                Console.Write($"Enter name for person {i + 1}: ");
                string name = Console.ReadLine();
                personDictionary[id] = name;
            }

            Console.Write("Enter an ID to find person: ");
            uint idToSearch = UInt32.Parse(Console.ReadLine());
            if (personDictionary.TryGetValue(idToSearch, out string personName))
            {
                Console.WriteLine(personName);
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }
        }
    }
}