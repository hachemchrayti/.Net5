using System;

namespace Net5CodingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displaying double quotes in c#
            string Name = "\"Dotnettutorials\"";
            Console.WriteLine(Name);
            // Displaying new line character in c#
            Name = "One\nTwo\nThree";
            Console.WriteLine(Name);
            // Displaying new line character in c#
            Name = "c:\\Pranaya\\Dotnettutorials\\Csharp";
            Console.WriteLine(Name);
            // C# verbatim literal
            Name = @"c:\Pranaya\Dotnettutorials\Csharp";
            Console.WriteLine(Name);
            Console.ReadKey();
        }
    }
}
