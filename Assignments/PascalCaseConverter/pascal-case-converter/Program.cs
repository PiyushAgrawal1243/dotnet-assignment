using System;
using System.Globalization;
using System.Text;

class Program : ConvertToPascaCase.ConvertStringToPascal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a words separated by space:");
        string input = Console.ReadLine();

        string pascalCase = ConvertToPascal(input);
        
        Console.WriteLine("PascalCase name: " + pascalCase);
    }

    
}
