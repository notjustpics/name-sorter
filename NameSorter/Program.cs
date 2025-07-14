using NameSorter.Services;
using NameSorter.Utilities;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1 || !File.Exists(args[0]))
        {
            Console.WriteLine("Usage: name-sorter <input-file>");
            return;
        }

        var inputPath = args[0];
        var outputPath = "sorted-names-list.txt";

        var names = FileHandler.ReadNames(inputPath);
        var sorter = new NameSorterService();
        var sorted = sorter.SortNames(names);

        foreach (var name in sorted)
            Console.WriteLine(name);

        FileHandler.WriteNames(outputPath, sorted);
    }
}