using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

namespace HW_4
{
    internal class Program : Person
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[6];
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Person {i + 1}:");
                people[i] = new Person();
                people[i].Input();
            }

            foreach (Person person in people)
            {
                person.Output();
            }

            for (int i = 0; i < people.Length; i++)
            {
                people[i].ChangeName();
            }
            foreach (Person person in people)
            {
                person.Output();
            }

            for (int j = 0; j < people.Length; j++)
            {
                for (int i = j + 1; i < people.Length - 1; i++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"{people[j].Name} and {people[i].Name} has equals name");
                    }

                }
            }
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
            Console.ReadKey();
        }
    }
}