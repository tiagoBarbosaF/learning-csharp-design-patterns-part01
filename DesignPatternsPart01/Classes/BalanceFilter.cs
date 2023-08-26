using DesignPatternsPart01.Classes.Accounts;

namespace DesignPatternsPart01.Classes;

public class BalanceFilter : Filter
{
    private readonly double _minBalance;
    private readonly double _maxBalance;

    public BalanceFilter(double minBalance, double maxBalance)
    {
        _minBalance = minBalance;
        _maxBalance = maxBalance;
    }
    
    public override IList<Account> FilterAccounts(IList<Account> accounts)
    {
        return accounts.Where(account => account.Balance < _minBalance || account.Balance > _maxBalance).ToList();
    }
}