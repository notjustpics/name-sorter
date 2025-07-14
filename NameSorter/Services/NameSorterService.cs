using NameSorter.Models;

namespace NameSorter.Services;

public class NameSorterService
{
    public List<PersonName> SortNames(IEnumerable<string> names)
    {
        return names
            .Select(name => new PersonName(name))
            .OrderBy(p => p.LastName)
            .ThenBy(p => string.Join(" ", p.GivenNames))
            .ToList();
    }
}