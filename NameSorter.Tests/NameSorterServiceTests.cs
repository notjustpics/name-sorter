using NameSorter.Services;
using Xunit;
using System.Linq;

namespace NameSorter.Tests;

public class NameSorterServiceTests
{
    [Fact]
    public void SortNames_SortsCorrectly_ByLastThenGivenNames()
    {
        var names = new[] {
            "Janet Parsons",
            "Adonis Julius Archer",
            "Beau Tristan Bentley"
        };

        var expected = new[] {
            "Adonis Julius Archer",
            "Beau Tristan Bentley",
            "Janet Parsons"
        };

        var service = new NameSorterService();
        var sorted = service.SortNames(names);

        Assert.Equal(expected, sorted.Select(n => n.ToString()));
    }
}