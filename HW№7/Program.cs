using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new();
        string path = "C:/Users/steam/OneDrive/Робочий стіл/HW phones/phones.txt";
        string line;
        try
        {
            using (StreamReader reader = new StreamReader(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(" ");
                    if (parts.Length == 2)
                    {
                        string phoneName = parts[0];
                        string phoneNumber = parts[1];
                        phoneBook[phoneName] = phoneNumber;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        string numbersPath = "C:/Users/steam/OneDrive/Робочий стіл/HW phones/Phoness.txt";

        using (StreamWriter writer = new StreamWriter(numbersPath))
            foreach (var kvp in phoneBook)
            {
                writer.WriteLine(kvp.Value);
            }

        Console.WriteLine("Enter the name: ");
        string name = Console.ReadLine();
        
        if(phoneBook.ContainsKey(name))
        {
            string phoneNumber = phoneBook[name];
            Console.WriteLine($"Phone number for {name}: {phoneNumber}");
        }
        else
        {
            Console.WriteLine($"No phone number found for {name}");
        }

        Dictionary<string, string> newPhoneBook = new Dictionary<string, string>();

        using (StreamReader read = new StreamReader(path))
        {
            while ((line = read.ReadLine()) != null)
            {
                string[] parts = line.Split(" ");
                if (parts.Length == 2)
                {
                    string newPhoneName = parts[0];
                    string newPhoneNumber = parts[1];
                    if (newPhoneNumber.Length == 11)
                        newPhoneNumber = "+3" + newPhoneNumber;
                    newPhoneBook[newPhoneNumber] = newPhoneName;
                }
            }
        }

        string newOutPath = "C:/Users/steam/OneDrive/Робочий стіл/HW phones/New.txt";

        using (StreamWriter writ = new StreamWriter(newOutPath))
        {
            foreach (var kvp in newPhoneBook)
            {
                writ.WriteLine($"{kvp.Value} : {kvp.Key}");
            }
        }
    }
}