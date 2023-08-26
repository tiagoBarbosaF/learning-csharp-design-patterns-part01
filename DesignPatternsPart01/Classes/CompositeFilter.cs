using DesignPatternsPart01.Classes.Accounts;

namespace DesignPatternsPart01.Classes;

public class CompositeFilter : Filter
{
    private readonly List<Filter> _filters = new();

    public void AddFilter(Filter filter)
    {
        _filters.Add(filter);
    }

    public override IList<Account> FilterAccounts(IList<Account> accounts)
    {
        List<Account> filteredAccounts = new List<Account>();

        foreach (var filter in _filters)
        {
            // filteredAccounts = filter.FilterAccounts(filteredAccounts).ToList();
            filteredAccounts.AddRange(filter.FilterAccounts(accounts));
        }

        return filteredAccounts;
    }
}