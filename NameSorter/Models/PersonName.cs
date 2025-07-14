namespace NameSorter.Models;

public class PersonName
{
    public List<string> GivenNames { get; }
    public string LastName { get; }

    public PersonName(string fullName)
    {
        var parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length < 2)
            throw new ArgumentException("A name must have at least one given name and one last name.");

        LastName = parts[^1];
        GivenNames = parts.Take(parts.Length - 1).ToList();
    }

    public override string ToString() =>
        string.Join(' ', GivenNames.Append(LastName));
}