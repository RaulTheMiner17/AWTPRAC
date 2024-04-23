using UtilityLibraries;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter the String.(empty/null to end)");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                break;
            Console.WriteLine($"Input: {input}");
            Console.WriteLine("Begins with uppercase? " + $"{(input.StartsWithUpper() ? "Yes" : "No")}");
            Console.WriteLine();
        }
    }
}
