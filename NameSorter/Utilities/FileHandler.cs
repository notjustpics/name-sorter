using NameSorter.Models;

namespace NameSorter.Utilities;

public static class FileHandler
{
    public static IEnumerable<string> ReadNames(string filePath) =>
        File.ReadAllLines(filePath).Where(line => !string.IsNullOrWhiteSpace(line));

    public static void WriteNames(string filePath, IEnumerable<PersonName> sortedNames) =>
        File.WriteAllLines(filePath, sortedNames.Select(name => name.ToString()));
}