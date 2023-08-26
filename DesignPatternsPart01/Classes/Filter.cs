using DesignPatternsPart01.Classes.Accounts;

namespace DesignPatternsPart01.Classes;

public abstract class Filter
{
    public abstract IList<Account> FilterAccounts(IList<Account> accounts);
}