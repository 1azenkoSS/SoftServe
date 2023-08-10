using System;

namespace HW_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer[] programmers = new Programmer[2];
            for (int i = 0; i < programmers.Length; i++)
            {
                Console.WriteLine($"Programmer {i + 1}: ");
                programmers[i] = new Programmer();
                programmers[i].Create();
            }

            Console.WriteLine("Information about the programmers: ");
            foreach (Programmer programmer in programmers)
            {
                programmer.Output();
            }

            Builder[] builders = new Builder[2];
            for (int i = 0; i < builders.Length; i++)
            {
                Console.WriteLine($"Builder {i + 1}: ");
                builders[i] = new Builder();
                builders[i].Create();
            }

            Console.WriteLine("Information about the builders: ");
            foreach (Builder builder in builders)
            {
                builder.Output();
            }

            Console.WriteLine("Enter the language to destroy: ");
            string languageToDestroy = Console.ReadLine();
            for (int i = 0; i < programmers.Length; i++)
            {
                programmers[i].Destroy(languageToDestroy);
            }

            Console.WriteLine("\nUpdated information about programmers:\n");
            foreach (Programmer programmer in programmers)
            {
                programmer.Output();
            }

            Console.WriteLine("Enter the tool to destroy: ");
            string toolToDestroy = Console.ReadLine();
            for (int i = 0; i < builders.Length; i++)
            {
                builders[i].Destroy(toolToDestroy);
            }

            Console.WriteLine("\nUpdated information about builders:\n");
            foreach (Builder builder in builders)
            {
                builder.Output();
            }

            Array.Sort(programmers, Comparer<Programmer>.Default);
            
            Console.WriteLine("Sorted information about programmers:\n");
            foreach (Programmer programmer in programmers)
            {
                programmer.Output();
            }

            Array.Sort(builders, Comparer<Builder>.Default);

            Console.WriteLine("Sorted information about builders:\n");
            foreach (Builder builder in builders)
            {
                builder.Output();
            }
        }
    }
}