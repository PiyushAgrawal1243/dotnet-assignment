using System;

class Program : FormateLike.FormatLike
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();

        while (true)
        {
            Console.WriteLine("Enter your name (press Enter to finish): ");
            string name = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                break;
            }

            names.Add(name);

            string message = FormatLikes(names);
            Console.WriteLine(message);
        }
    }

}
