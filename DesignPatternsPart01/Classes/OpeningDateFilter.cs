namespace DesignPatternsPart01.Classes;

public class OpeningDateFilter : Filter
{
    private readonly DateTime _currentMonth;

    public OpeningDateFilter(DateTime currentMonth)
    {
        _currentMonth = currentMonth;
    }


    public override IList<Account> FilterAccounts(IList<Account> accounts)
    {
        return accounts.Where(account => account.OpeningDate.Month == _currentMonth.Month).ToList();
    }
}